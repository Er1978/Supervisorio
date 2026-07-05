#include <Controllino.h>
#include <NewPing.h>

// --- VARIÁVEIS GLOBAIS DE CONTROLE DOS SENSORES LT101 E LT 102---
unsigned long ultimoDisparo = 0;
const int intervaloDisparo = 80; // ms entre disparos
static bool vezDoSensor1 = true; // Multiplexar os sensores

//Rele de Energia
#define RELE0_LV102 22
#define RELE1_P102 23
#define RELE2_P101 24
#define BOTAO_EMERGENCIA A1 // AI1

//#define AI2 A2 //

//Variavel para desligamento de Emergência
int EMERGENCIA=0;

//SENSORES LT101 E LT102
#define TRIG_PIN1 2 // DO1 OUTPUT
#define ECHO_PIN1 A13 // DI0   18 IN0 INPUT

#define TRIG_PIN2 3 // DO1 OUTPUT
#define ECHO_PIN2 10 // DI2 A13 INPUT

//SENSOR DE VAZÃO E BOIA
#define LSH102 A0//AI0 => LEVEL SWITCH 102 (BOIA COM SWITCH) ACIONA EM 12 cm APROX
#define SENSOR_VAZAO 18 //IN0 - PARA USAR A INTERRUPÇÃO DO ARDUINO

//CONSTANTES
const float CUSTOM_US_ROUNDTRIP_CM= 57.72;
#define MAX_DISTANCE 30
#define ON 1
#define OFF 0

#define OPEN 1
#define CLOSE 0

//BOMBAS E VALVULA
#define LV102 4 // DO2 OUTPUT
#define P101 5 // DO3 OUTPUT
#define P102 6 // DO4 OUTPUT


// Variável GLOBAL para não perder o valor entre os ciclos do loop
float TK101_DISTANCIA_CM = 0;
float TK102_DISTANCIA_CM = 0;
float V_MAX_BOMBA=12; // Tensão max BOMBA
float V_MIN_BOMBA=6; // Tensão min  BOMBA
static int POWER=0;// Energiza o comum dos equipamentos de maior consumo de corrente

//Calibração da Altura do Sensor em relação ao fundo do tanque EM CM
float H_LT101 = 24.5;
float H_LT102 = 22.95;
float SETPOINT_TK102_MIN=2;
float SETPOINT_TK102_MAX=16;

// Controle de tempo para envio de dados
unsigned long tempoAnterior = 0;
unsigned long tempoAnteriorFlow = 0;
const long intervaloEnvio = 1000; // Envia telemetria a cada 1 segundo

//Parametros para o alarmes de Alta e Baixa
float valorLAL101=2.0;
float valorLAL102=4.0;
float valorLAH101=14;

int LAH102=0; //ON OFF que vem da Boia por isso nao vamos especificar um valor aqui.
int LAL102=0;
int LAL101=0;
int LAH101=0;

// Variáveis de Estado (Memória do que está ligado/desligado)

float nivelTK101 = 0.0;
float nivelTK102 = 0.0;
float nivel2_anterior=0.00;
float nivel1_anterior=0.00;
static float SETPOINT_TK102=0.0;

bool SETPOINT_VALIDO = false;
int ackModoManual=0; //Reconhece o Modo Manual
float  V_P101=0; //Tensão da bomba P101
float  V_P102=0; //Tensão da bomba P102
int estadoLV102=CLOSE; //Estado da válvula LV102
int sinal_OVL=0;   //Sinal de Overload do CLP

//Dados de leitura dos sensores ultrassonicos
volatile unsigned int tempoEcoLT101 = 0;
volatile unsigned int tempoEcoLT102 = 0;
volatile bool novaLeituraLT101 = false;
volatile bool novaLeituraLT102 = false;

//Dados Sensor de Vazão
volatile int COUNT_FLOW; //SENSOR DE VAZAO
float flowRate=0;
float mediaFLow=0;
int itemMedia=0;

// Objetos para os dois sensores
NewPing sonarLT101(TRIG_PIN1, ECHO_PIN1, MAX_DISTANCE);
NewPing sonarLT102(TRIG_PIN2, ECHO_PIN2, MAX_DISTANCE);

// ==========================================
// CONFIGURAÇÃO DO FILTRO DE MEDIANA MÓVEL
// ==========================================
const int TAMANHO_AMOSTRA = 5; // Recomendo 5. Use sempre números ímpares (3, 5, 7)
float bufferNivelA[TAMANHO_AMOSTRA];
int indiceFiltroA = 0;
bool bufferCheioA = false; // Impede cálculos errados antes de ler 5 vezes
//fILTRO BRUSCO
float medidaAnterior = 0.0;
bool primeiraLeitura = true;
int falhasConsecutivas = 0;
// Quantos ruídos seguidos vamos ignorar antes de aceitar o novo valor
const int MAX_FALHAS_PERMITIDAS = 5;

float filtrarVariacaoRobusto(float novaMedida) {
  if (primeiraLeitura) {
    medidaAnterior = novaMedida;
    primeiraLeitura = false;
    return novaMedida;
  }

  float variacao = abs(novaMedida - medidaAnterior);

  if (variacao > 1.0) {
    falhasConsecutivas++;
    
    // Se a medida se manteve fora do padrão por várias leituras seguidas, 
    // assumimos que é uma mudança real na dinâmica do processo.
    if (falhasConsecutivas >= MAX_FALHAS_PERMITIDAS) {
      medidaAnterior = novaMedida; // Atualiza forçadamente
      falhasConsecutivas = 0;      // Zera o contador
      return novaMedida;
    }
    
    // Ignora a leitura pontual e retorna a anterior
    return medidaAnterior; 
    
  } else {
    // Leitura normal e dentro do limite
    medidaAnterior = novaMedida;
    falhasConsecutivas = 0; // Zera o contador, pois a leitura voltou ao normal
    return novaMedida;
  }
}


void Flow()
{
    COUNT_FLOW++; //Quando essa função é chamada, soma-se 1 a variável "COUNT_FLOW"
}

void Bomba_P101(int estado, float tensao=0) 
{

  //BOMBA P101 : PROTEÇÃO TRANSBORDO DO TANQUE 101 E TANQUE VAZIO DO TANQUE 102
  if (LAH101+LAL102>0)
  {
    estado=OFF; //Impede ligar a bomba P101
  }
    
  tensao = constrain(tensao, V_MIN_BOMBA, V_MAX_BOMBA);

  //Bombeia do Tanque 102 para 101, abre e fecha a válvula LV102, e envia a tensão para a bomba P101
  if (estado == ON) 
  {
    estadoLV102=OPEN; // Abre a válvula LV102
    analogWrite(P101, map(tensao, V_MIN_BOMBA, V_MAX_BOMBA, 77, 153 )); // Ajusta a tensão da bomba P101
  } 
  else 
  {
    estadoLV102=CLOSE; // Fecha a válvula LV102
    analogWrite(P101, 0);
    
  }

  V_P101 = tensao*estado; // Atualiza a variável global com a tensão da bomba P101
  digitalWrite(LV102, estadoLV102 ); // Controla a válvula LV102

}

void Bomba_P102(int estado, float tensao=0) 
{
  tensao = constrain(tensao, V_MIN_BOMBA, V_MAX_BOMBA);
  //Bombeia do Tanque 102 para 101, abre e fecha a válvula LV102, e envia a tensão para a bomba P102


  //BOMBA P102 : PROTEÇÃO TRANSBORDO DO TANQUE 102 E TANQUE 101 VAZIO
  if (LAH102+LAL101>0)
  {
    estado=OFF; //Impede ligar a bomba P102
  }
   
  if (estado == ON) 
  {
    
    analogWrite(P102, map(tensao, V_MIN_BOMBA, V_MAX_BOMBA, 77, 153 )); // Ajusta a tensão da bomba P102
  } 
  else 
  {
    analogWrite(P102, 0);
    
  }

  V_P102 = tensao*estado; // Atualiza a variável global com a tensão da bomba P102
}

// Função que calcula a Mediana sem bagunçar a ordem do tempo real
float calcularMediana(float* array, int tamanho) {
  float temp[tamanho];
  
  // Passo 1: Faz uma cópia do buffer para poder ordenar sem destruir o original
  for (int i = 0; i < tamanho; i++) {
    temp[i] = array[i];
  }

  // Passo 2: Ordena a cópia do menor para o maior (Bubble Sort simples)
  for (int i = 0; i < tamanho - 1; i++) {
    for (int j = i + 1; j < tamanho; j++) {
      if (temp[i] > temp[j]) {
        float aux = temp[i];
        temp[i] = temp[j];
        temp[j] = aux;
      }
    }
  }
  
  // Passo 3: Retorna exatamente o valor central (a mediana geométrica)
  return temp[tamanho / 2]; 
}

void setup() {


  // Zera o buffer de memória na inicialização
  for (int i = 0; i < TAMANHO_AMOSTRA; i++) {
    bufferNivelA[i] = 0.0;
  }

  Serial.begin(9600);
  Serial.println("INICIANDO CONTROLADOR DE NIVEL .."); 
   
  //pinMode(OVL, INPUT);
  //pinMode(AI2, OUTPUT);
  //Bombas e válvulas
  pinMode(P101, OUTPUT);
  pinMode(P102, OUTPUT);
  pinMode(LV102, OUTPUT);

  pinMode(RELE0_LV102, OUTPUT);
  pinMode(RELE1_P102, OUTPUT);
  pinMode(RELE2_P101, OUTPUT);

  // Garante que tudo inicie desligado
  Bomba_P101(OFF, 0);
  Bomba_P102(OFF, 0);
 
  // Pinos dos sensores
  pinMode(TRIG_PIN1, OUTPUT);
  pinMode(ECHO_PIN1, INPUT);
  pinMode(TRIG_PIN2, OUTPUT);
  pinMode(ECHO_PIN2, INPUT);
  pinMode(BOTAO_EMERGENCIA, INPUT);
  pinMode(LSH102, INPUT);
  pinMode(SENSOR_VAZAO, INPUT);

  digitalWrite(TRIG_PIN1,LOW);
  digitalWrite(TRIG_PIN2,LOW);

  attachInterrupt(digitalPinToInterrupt(SENSOR_VAZAO), Flow, RISING); // Interrupção do Sensor de Vazão

  delay(500); //Aguarda 0,5 segundo para que todas as tensões e saidas PWM estejam zeradas

 //Energiza equipamentos
  digitalWrite(RELE0_LV102, HIGH);
  digitalWrite(RELE2_P101, HIGH);
  digitalWrite(RELE1_P102, HIGH);

  //digitalWrite(AI2, HIGH);
}


void loop()
{



  //ativar emrgencia no campo
  if(EMERGENCIA==0)
  {
    EMERGENCIA=digitalRead(BOTAO_EMERGENCIA);
    if(EMERGENCIA==1)
    {
      digitalWrite(RELE0_LV102, LOW);
      digitalWrite(RELE2_P101, LOW);
      digitalWrite(RELE1_P102, LOW);
      Bomba_P101(OFF,0); 
      Bomba_P102(OFF,0);    
    }
    
  }
  


  //INTERTRAVAMENTO
  LAH102=digitalRead(LSH102);

  //IMPEDIR TRANSBORDO DO TANQUE 101
  if (nivelTK101 >= valorLAH101)
  {
    Bomba_P101(OFF, 0); //Desliga a bomba P101
    LAH101=1; //Sinaliza que o tanque 101 está em nível alto
  }
  else
  {
    LAH101=0; 
  }
  //IMPEDIR BOMEBAR COM TANQUE VAZIO
  if(nivelTK101 <= valorLAL101)
  {
    Bomba_P102(OFF, 0); //Desliga a bomba P102
    LAL101=1; //Sinaliza que o tanque 101 está em nível baixo
  }
  else
  {
    LAL101=0; 
  }

  //IMPEDIR TRANSBORDO DO TANQUE 102
  if(LAH102==1)
  {
    Bomba_P102(OFF, 0); //Desliga a bomba P102
  }

  //IMPEDIR BOMBEAR COM TANQUE VAZIO
  if(nivelTK102 <= valorLAL102)
  {
    Bomba_P101(OFF, 0); //Desliga a bomba P101
    LAL102=1; //Sinaliza que o tanque 102 está em nível baixo
  }
  else
  {
    LAL102=0; //Sinaliza que o tanque 102 não está em nível baixo
  }


  float FOLGA = 1.5;     // Proximidade para atuar com tensão reduzida e evitar perder o SP
  float INCERTEZA = 0.40 ;// Zona morta: se estiver dentro desse range, aceita o nível por conta da imprecisao do sensor
  float tensaoREDUZIDA = 6.0;

  //BUSCA DO SETPOINT DO TANQUE 102
  if (SETPOINT_VALIDO && ackModoManual==0 && EMERGENCIA==0) 
  {
    // #1. Nível muito abaixo (Enchendo Rápido P102 a 12 Volts)
    if (nivelTK102 < (SETPOINT_TK102 - FOLGA)) 
    {
      Bomba_P102(ON, V_MAX_BOMBA); 
      Bomba_P101(OFF, 0); 
    } 
    // #2 Nível se aproximando por baixo (Enchendo Devagar) p102 6V
    else if (nivelTK102 >= (SETPOINT_TK102 - FOLGA) && nivelTK102 < (SETPOINT_TK102 - INCERTEZA)) 
    {
      Bomba_P102(ON, tensaoREDUZIDA); 
      Bomba_P101(OFF, 0); 
    } 
    // #3. ZONA MORTA: Alvo Atingido (Ambas Desligadas)
    else if (nivelTK102 >= (SETPOINT_TK102 - INCERTEZA) && nivelTK102 <= (SETPOINT_TK102 + INCERTEZA)) 
    {
      Bomba_P102(OFF, 0);
      Bomba_P101(OFF, 0); 
    } 
    // #4. Nível passou um pouco (Esvaziando Devagar)
    else if (nivelTK102 > (SETPOINT_TK102 + INCERTEZA) && nivelTK102 <= (SETPOINT_TK102 + FOLGA)) 
    {
      Bomba_P102(OFF, 0); 
      Bomba_P101(ON, tensaoREDUZIDA); 
    } 
    // #5. Nível muito acima (Esvaziando Rápido)
    else if (nivelTK102 > (SETPOINT_TK102 + FOLGA))
    {
      Bomba_P102(OFF, 0); 
      Bomba_P101(ON, V_MAX_BOMBA); 
    }
  } 
 

  //LEITURA DE COMANDOS NA SERIAL:
  if (Serial.available() > 0) {
    String comando = Serial.readStringUntil('\n');
    comando.trim(); // Remove espaços e caracteres de controle
    
      if (ackModoManual==1) 
      {
        //Só aceita acionamento manual em modo manual


        //Ligar Bomba P102 => Pode transbordar TK102 então LAH102 tem que estar desligado

        if (comando == "B2-1" && LAH102==0 && LAL101==0) 
        { 
          Bomba_P102(ON,V_MAX_BOMBA );
        
        }
        else if (comando == "B2-0") 
        { 
        Bomba_P102(OFF,0);
        }

        //Ligar Bomba P101 => Pode transbordar TK101 então LAH101 tem que estar desligado
        if (comando == "B1-1" && LAH101==0 && LAL102==0) 
        { 
          Bomba_P101(ON,V_MAX_BOMBA );
        
        }
        else if (comando == "B1-0") 
        { 
        Bomba_P101(OFF,0);
        }

        if (comando == "V1" && LAH101==0) 
        { 
          digitalWrite(LV102, OPEN ); // Controla a válvula LV102       
        }
        else if (comando == "V0") 
        { 
        digitalWrite(LV102, CLOSE ); // Controla a válvula LV102
        Bomba_P101(OFF,0); // Desliga a vomba P101 por precaução    
        }
        
      }


      if (comando == "EM") 
      { 
        EMERGENCIA=1;
        digitalWrite(RELE0_LV102, LOW ); // Desliga Tudo     
        digitalWrite(RELE1_P102, LOW ); // Desliga Tudo     
        digitalWrite(RELE2_P101, LOW ); // Desliga Tudo     
        Bomba_P101(OFF,0); 
        Bomba_P102(OFF,0);  
      }
       
    if (comando.startsWith("SP")) 
    { 
       
        String valorTexto = comando.substring(2); 
      
        float novoSetpoint = valorTexto.toFloat();
        
        SETPOINT_VALIDO = ((novoSetpoint >= SETPOINT_TK102_MIN && novoSetpoint <= SETPOINT_TK102_MAX));

        if(SETPOINT_VALIDO ||novoSetpoint==0) 
        {
          SETPOINT_TK102=novoSetpoint;
          //vERIFICAR NECESSIDADE DE DESLIGAR AS BOMBAS SE O SETPOINT FOR ZERO

          if(SETPOINT_TK102==0)
          {
              Bomba_P101(OFF, 0);
              Bomba_P102(OFF, 0);
          }


        }
       
    }

    if (comando.startsWith("MO")) 
    { 
       
        String valorTexto = comando.substring(2); 
       
       
        ackModoManual=valorTexto.toInt();

        
        SETPOINT_TK102=0; //Zera o setpoint se alterar o modo
        SETPOINT_VALIDO=false;
        Bomba_P101(OFF, 0);
        Bomba_P102(OFF, 0);
        
       
    }
      
  }


  //SENSOR DE VAZÃO
  unsigned long tempoAtualFlow = millis();

    // Verifica se a diferença entre o tempo atual e o anterior atingiu 1 segundo
    if (tempoAtualFlow - tempoAnteriorFlow >= 1000) {
      
      tempoAnteriorFlow = tempoAtualFlow; // Atualiza a marcação de tempo para o próximo ciclo

      // ZONA CRÍTICA: Desabilita interrupções APENAS para copiar a variável
      noInterrupts();
      int contagemAtual = COUNT_FLOW; // Copia o valor de forma segura
      COUNT_FLOW = 0;                 // Reseta o contador imediatamente
      interrupts();              // Reabilita as interrupções o mais rápido possível

        
      flowRate = (contagemAtual*15.84/1000 );  //      L/min
      //flowRate = (flowRate ) ;
    }


 // DISPARO MULTIPLEXADO DOS SENSORES LT101 E LT102
  if (millis() - ultimoDisparo >= intervaloDisparo) 
  { 
      ultimoDisparo = millis(); 
      
      if (vezDoSensor1) 
      { 
        // ==========================================
        // LÓGICA DO SENSOR 1
        // ==========================================
        float leitura1 = sonarLT101.ping();
        
        if (leitura1 == 0) 
        {
          TK101_DISTANCIA_CM = MAX_DISTANCE; 
        } 
        else 
        {
          
          TK101_DISTANCIA_CM = (float)leitura1 / CUSTOM_US_ROUNDTRIP_CM;
        }
       // Serial.println(TK101_DISTANCIA_CM);
        nivelTK101 = (TK101_DISTANCIA_CM > 0 && TK101_DISTANCIA_CM < H_LT101) ? (H_LT101 - TK101_DISTANCIA_CM) : nivelTK101;
        //Serial.println(nivelTK101);
        // PARA ESTABILIZAR A LEITURA DEVIDO A VARIACOES BRUSCAS QUE O SENSOR DÁ
        //if(abs(nivelTK101_novo - nivel1_anterior) < 20 || nivel1_anterior == 0)
        //{
        //  nivelTK101 = round(nivelTK101_novo * 10) / 10.0;
        //  nivel1_anterior = nivelTK101_novo;
        //}
      } 
      else 
      {
        // ==========================================
        // LÓGICA DO SENSOR 2
        // ==========================================
        float fator_ajuste_sensor=0;
        float leitura2 = sonarLT102.ping();
        //Serial.println(leitura2);
        if(leitura2>500 && leitura2<600)
        {
          fator_ajuste_sensor=60;
        }
        else
        {
          fator_ajuste_sensor=0;
        }
        
        //leitura2-=fator_ajuste_sensor;
                   
        if (leitura2 == 0) 
        {
          TK102_DISTANCIA_CM = MAX_DISTANCE;
        } 
        else 
        {
          TK102_DISTANCIA_CM = (float)leitura2 / CUSTOM_US_ROUNDTRIP_CM;
        }
      
        float nivelTK102_lido = (TK102_DISTANCIA_CM > 0 && TK102_DISTANCIA_CM < H_LT102) ? (H_LT102 - TK102_DISTANCIA_CM) : nivelTK102;

        // Insere a nova leitura na posição atual do buffer
        bufferNivelA[indiceFiltroA] = filtrarVariacaoRobusto(nivelTK102_lido);;
        indiceFiltroA++; // Avança para a próxima "gaveta"

        // Se chegou no final do buffer, volta para o começo (Buffer Circular)
        if (indiceFiltroA >= TAMANHO_AMOSTRA) {
          indiceFiltroA = 0;
          bufferCheioA = true; // Agora temos 5 leituras reais para calcular a mediana
        }

        // Exibe os resultados (só calcula se já encheu as 5 gavetas)
        if (bufferCheioA) {
          nivelTK102 = calcularMediana(bufferNivelA, TAMANHO_AMOSTRA);
         
     
          
        } 

        
      } 

      // Alterna o sensor para a próxima execução do loop (DENTRO do timer de 50ms)
      vezDoSensor1 = !vezDoSensor1;
  }

  //Envio de Telemetria para o C# a cada 1 segundo
    unsigned long tempoAtual = millis();
  if (tempoAtual - tempoAnterior >= intervaloEnvio) 
  {
      tempoAnterior = tempoAtual; 
      
      // Constrói e envia a string JSON para o C#
      Serial.print("{\"n1\": "); Serial.print(nivelTK101);
      Serial.print(", \"n2\": "); Serial.print(nivelTK102);
      Serial.print(", \"b1\": "); Serial.print(V_P101 > 0 ? 1 : 0);
      Serial.print(", \"b2\": "); Serial.print(V_P102 > 0 ? 1 : 0);
      Serial.print(", \"LAL101\": "); Serial.print(LAL101 ? 1 : 0);
      Serial.print(", \"LAH101\": "); Serial.print(LAH101 ? 1 : 0);
      Serial.print(", \"LAL102\": "); Serial.print(LAL102 ? 1 : 0);
      Serial.print(", \"LAH102\": "); Serial.print(LAH102 ? 1 : 0);
      Serial.print(", \"ackM\": "); Serial.print(ackModoManual ? 1 : 0);
      Serial.print(", \"ackSP\": "); Serial.print(SETPOINT_TK102);
      Serial.print(", \"VB1\": "); Serial.print(V_P101); 
      Serial.print(", \"VB2\": "); Serial.print(V_P102); 
      Serial.print(", \"VZ\": "); Serial.print(flowRate); 
      Serial.print(", \"LV\": "); Serial.print(estadoLV102);
      Serial.print(", \"RL\": "); Serial.print(EMERGENCIA);
      Serial.println("}");
      
  }

      
}