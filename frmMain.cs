using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Supervisorio
{

    public partial class frmMain : Form
    {

        private double tempoAtual = 0;
        private Stopwatch cronometro = new Stopwatch();
        private double nivel1 = 0;
        private double nivel2 = 0;
        private double vazao = 0;
        private double volume1 = 0;
        private double volume2 = 0;
        private double setpoint = 0;
        private double setpointEnviado = -1;
        private double tensaoBomba1 = 0;
        private double tensaoBomba2 = 0;
        private bool ackModoManual = false;

        bool LAL101 = false;
        bool LAH101 = false;
        bool LAH102 = false;
        bool LAL102 = false;

        bool conectado = false;
        bool P101_ligada = false;
        bool P102_ligada = false;
        bool LV102_aberta = false;
        bool emergenciaAtiva = false;
        bool setpointDefinido = false;

        //Para armazenar os dados recebidos do Controlador e processá-los de forma assíncrona
        private readonly Queue<DadosSensor> _bufferNivel1 = new Queue<DadosSensor>();
        private readonly Queue<DadosSensor> _bufferNivel2 = new Queue<DadosSensor>();
        private readonly Queue<DadosSensor> _bufferVazao = new Queue<DadosSensor>();
        private readonly TimeSpan _tempoMaximo = TimeSpan.FromSeconds(300);//guardar 5 minutos
        private readonly object _lock = new object(); // Garante segurança entre threads


        string serialDataIn = string.Empty;
        string portaCOM = string.Empty;
        TelemetriaArduino telemetria;
        public frmMain()
        {
            InitializeComponent();
            InicializaSerial();
            ConfigurarGraficos();


        }



        private void ConfigurarGraficos()
        {
            // 1. CRÍTICO: Limpa as configurações padrão do designer para evitar duplicidade
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();

            chart2.Series.Clear();
            chart2.ChartAreas.Clear();

            chart3.Series.Clear();
            chart3.ChartAreas.Clear();

            chart1.Legends[0].Docking = Docking.Top;
            chart1.Legends[0].Alignment = StringAlignment.Center;

            chart2.Legends[0].Docking = Docking.Top;
            chart2.Legends[0].Alignment = StringAlignment.Center;

            chart3.Legends[0].Docking = Docking.Top;
            chart3.Legends[0].Alignment = StringAlignment.Center;

            // 2. Cria a nossa área customizada
            ChartArea area1 = new ChartArea("AreaTanque1");
            ChartArea area2 = new ChartArea("AreaTanque2");
            ChartArea area3 = new ChartArea("Vazao");

            List<ChartArea> lista = new List<ChartArea> { area1, area2, area3 };
            //Aproveitamento de Area do Grafico

            foreach (var area in lista)
            {
                area.Position.Auto = false;
                area.Position.X = 10;
                area.Position.Y = 4;
                area.Position.Width = 90;
                area.Position.Height = 95;
                area.InnerPlotPosition.Auto = false;
                area.InnerPlotPosition.X = 5;
                area.InnerPlotPosition.Y = 5;
                area.InnerPlotPosition.Width = 85;
                area.InnerPlotPosition.Height = 76;

            }


            // Configuração do Eixo X (Tempo sempre começando em 0 até 60s)
            area1.AxisX.Title = "Tempo (s)";
            area1.AxisX.Minimum = 0;
            area1.AxisX.Maximum = 60;
            area1.AxisX.MajorGrid.LineColor = Color.LightGray;
            area1.AxisX.LabelStyle.Format = "0"; // Formata o número como inteiro
            area1.AxisX.Interval = 10;
            area1.AxisX.IsLabelAutoFit = false;
            area1.AxisX.LabelStyle.Font = new System.Drawing.Font("Arial", 7f);


            area2.AxisX.Title = "Tempo (s)";
            area2.AxisX.Minimum = 0;
            area2.AxisX.Maximum = 60;
            area2.AxisX.MajorGrid.LineColor = Color.LightGray;
            area2.AxisX.LabelStyle.Format = "0"; // Formata o número como inteiro
            area2.AxisX.Interval = 10;
            area2.AxisX.IsLabelAutoFit = false;
            area2.AxisX.LabelStyle.Font = new System.Drawing.Font("Arial", 7f);

            area3.AxisX.Title = "Tempo (s)";
            area3.AxisX.Minimum = 0;
            area3.AxisX.Maximum = 60;
            area3.AxisX.MajorGrid.LineColor = Color.LightGray;
            area3.AxisX.LabelStyle.Format = "0"; // Formata o número como inteiro
            area3.AxisX.Interval = 10;
            area3.AxisX.IsLabelAutoFit = false;
            area3.AxisX.LabelStyle.Font = new System.Drawing.Font("Arial", 7f);

            // Configuração do Eixo Y (Fixo de 0 a 20cm conforme seu sensor)
            area1.AxisY.Title = "Nível (cm)";
            area1.AxisY.Minimum = 0;
            area1.AxisY.Maximum = 16;
            area1.AxisY.Interval = 2;
            area1.AxisY.LabelStyle.IsStaggered = false;

            area2.AxisY.Title = "Nível (cm)";
            area2.AxisY.Minimum = 0;
            area2.AxisY.Maximum = 16;
            area2.AxisY.Interval = 2;
            area2.AxisY.LabelStyle.IsStaggered = false;

            area3.AxisY.Title = "Vazão (L/min)";
            area3.AxisY.Minimum = 0;
            area3.AxisY.Maximum = 1;
            area3.AxisY.Interval = 0.1;
            area3.AxisY.LabelStyle.IsStaggered = false;

            area1.AxisY.MajorGrid.LineColor = Color.LightGray;
            area2.AxisY.MajorGrid.LineColor = Color.LightGray;
            area3.AxisY.MajorGrid.LineColor = Color.LightGray;

            chart1.ChartAreas.Add(area1);
            chart2.ChartAreas.Add(area2);
            chart3.ChartAreas.Add(area3);

            // 3. Configura a série de dados
            Series serieNivel1 = new Series("Nivel TQ101 (cm)");
            Series serieNivel2 = new Series("Nivel TQ102 (cm)");
            Series serieNivel3 = new Series("Vazão Saída TQ102 (mL/min)");


            serieNivel1.ChartArea = "AreaTanque1";
            serieNivel2.ChartArea = "AreaTanque2";
            serieNivel3.ChartArea = "Vazao";

            serieNivel1.ChartType = SeriesChartType.FastLine;
            serieNivel1.BorderWidth = 3;
            serieNivel1.Color = Color.Blue;

            serieNivel2.ChartType = SeriesChartType.FastLine;
            serieNivel2.BorderWidth = 3;
            serieNivel2.Color = Color.Red;

            serieNivel3.ChartType = SeriesChartType.FastLine;
            serieNivel3.BorderWidth = 3;
            serieNivel3.Color = Color.Green;

            chart1.Series.Add(serieNivel1);
            chart2.Series.Add(serieNivel2);
            chart3.Series.Add(serieNivel3);
        }


        void InicializaSerial()
        {
            string[] listaPortas = SerialPort.GetPortNames();
            try
            {
                portaCOM = listaPortas[0];
                serialPort1.PortName = portaCOM;
                serialPort1.BaudRate = 9600;
                //serialPort1.DtrEnable = true;
                //serialPort1.RtsEnable = true;
                serialPort1.ReceivedBytesThreshold = 1;

                if (!serialPort1.IsOpen)
                {
                    try
                    {

                        serialPort1.Open();
                        if (serialPort1.IsOpen)
                        {
                            chart1.Series[0].Points.Clear();
                            chart2.Series[0].Points.Clear();
                            conectado = true;
                            cronometro.Restart();
                            lblConexao.BackColor = Color.LightGreen;
                            lblConexao.Text = "Conectado: " + portaCOM;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao abrir porta serial");
                        lblConexao.BackColor = Color.LightGray;
                        lblConexao.Text = "Erro de Conexão";
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("aberta"))
                {
                    MessageBox.Show("A porta já está conectada.");
                }
                else
                {
                    MessageBox.Show("Não foi possível conectar ao Controlador");
                    lblConexao.BackColor = Color.LightGray;
                    lblConexao.Text = "Erro de Conexão";
                }

            }
        }



        static int direcao = 1;
        int nivelAtual;

        private void frmMain_Load(object sender, EventArgs e)
        {
            p102.Ligado = false;
            p101.Ligado = false;
            lv102.Ligado = false;
            tq101.NomeTanque = "TK-101";
            tq102.NomeTanque = "TK-102";
            lblNivelTanque1.Text = "Nível TK-101: desconhecido";
            lblNivelTanque2.Text = "Nível TK-102: desconhecido";
            lblSetpoint.Text = "Setpoint: Não definido";
            lblBarraStatus.Text = "...";

            //Caracteristicas dos Tanques para calculo de volume
            tq101.Diametro = 15;
            tq101.Altura = 18;
            tq102.Diametro = 15;
            tq102.Altura = 18;

        }






        private void p101_CliqueBomba(object sender, EventArgs e)
        {
            if (serialPort1 != null && serialPort1.IsOpen)
            {
                try
                {

                    if (!P101_ligada)
                    {
                        // Envia o comando para LIGAR junto com uma quebra de linha (\n)
                        serialPort1.WriteLine("B1");

                    }
                    else
                    {
                        // Envia o comando para DESLIGAR
                        serialPort1.WriteLine("B0");
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Erro ao enviar comando para a serial: " + ex.Message);
                    MessageBox.Show("Erro ao enviar comando para a serial");
                    lblConexao.BackColor = Color.LightGray;
                    lblConexao.Text = "Erro de Conexão";
                    lblConexao.ForeColor = Color.Red;


                }
            }
            else
            {
                MessageBox.Show("A porta serial não está conectada!");
                lblConexao.BackColor = Color.LightGray;
                lblConexao.Text = "Erro de Conexão";
                lblConexao.ForeColor = Color.Red;
            }
        }





        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //Toda interação depende desse evento, é aqui que recebemos os dados do Controlador
            //e atualizamos a interface
            string txtErro = "";

            try
            {
                serialDataIn = serialPort1.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao ler dados da serial: " + ex.Message);
                txtErro = "Erro ao ler dados da serial: " + ex.Message;
            }
            Console.WriteLine("Dados recebidos: " + serialDataIn);
            try
            {
                telemetria = System.Text.Json.JsonSerializer.Deserialize<TelemetriaArduino>(serialDataIn);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao desserializar dados: " + ex.Message);
                //txtErro = "Erro ao desserializar dados: " + ex.Message;

            }

            // Bomba P101 e P102
            if (telemetria?.Bomba1 == 1)
            {
                P101_ligada = true;

            }
            else if (telemetria?.Bomba1 == 0)
            {
                P101_ligada = false;

            }


            if (telemetria?.Bomba2 == 1)
            {
                P102_ligada = true;

            }
            else if (telemetria?.Bomba2 == 0)
            {
                P102_ligada = false;

            }

            //Valvula LV102
            if (telemetria?.Valvula == 1)
            {
                LV102_aberta = true;
            }
            else
            {
                LV102_aberta = false;
            }

            // Niveis
            if (telemetria?.Nivel1 != null) nivel1 = telemetria.Nivel1;
            if (telemetria?.Nivel2 != null) nivel2 = telemetria.Nivel2;

            //Vazao

            if (telemetria?.Vazao != null) vazao = telemetria.Vazao;

            //Tensoes
            if (telemetria?.TensaoBomba1 != null) tensaoBomba1 = telemetria.TensaoBomba1;
            if (telemetria?.TensaoBomba2 != null) tensaoBomba2 = telemetria.TensaoBomba2;

            //Alarmes

            if (telemetria?.LAL101 == 1)
            {
                LAL101 = true;
            }
            else
            {
                LAL101 = false;
            }

            if (telemetria?.LAH101 == 1)
            {
                LAH101 = true;
            }
            else
            {
                LAH101 = false;
            }

            if (telemetria?.LAL102 == 1)
            {
                LAL102 = true;
            }
            else
            {
                LAL102 = false;
            }

            if (telemetria?.LAH102 == 1)
            {
                LAH102 = true;
            }
            else
            {
                LAH102 = false;
            }

            if (telemetria?.AckModo == 1)
            {
                ackModoManual = true;

            }
            else
            {
                ackModoManual = false;

            }

            if (telemetria?.Emergencia == 1)
            {
                emergenciaAtiva = true;

            }
            else
            {
                emergenciaAtiva = false;

            }



            //Recebe confirmação do valor de setpoint reconhecido pelo Controlador.
            try
            {
                string textoSetpoint = telemetria?.Setpoint != null ? telemetria.Setpoint.ToString() : "";
                setpoint = double.Parse(textoSetpoint);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            setpointDefinido = setpoint == setpointEnviado ? true : false;

            if (nivel1 < 0) { nivel1 = 0; }
            if (nivel2 < 0) { nivel2 = 0; }


            this.BeginInvoke(new Action(() =>
            {
                tempoAtual = cronometro.Elapsed.TotalSeconds;

                //Atualiza situação da bomba e válvula
                p102.Ligado = P102_ligada;
                p101.Ligado = P101_ligada;
                lv102.Ligado = LV102_aberta;

                // Atualiza o nível dos dois tanques na tela

                tq101.Nivel = (int)((nivel1 / 14.0) * 100);
                tq102.Nivel = (int)((nivel2 / 14.0) * 100);

                //Atualiza tensoes das bombas
                p101.Tensao = tensaoBomba1;
                p102.Tensao = tensaoBomba2;
                lblTensaoP101.Text = tensaoBomba1.ToString("F1") + " V";
                lblTensaoP102.Text = tensaoBomba2.ToString("F1") + " V";


                //Atualiza o label da vazão

                lblVazao.Text = "Vazão: " + vazao.ToString("F2") + " L/min";

                //Mostrando situação dos alarmes
                if (LAL101)
                {
                    picLAL101.Image = Properties.Resources.alerta_ativo;
                }
                else
                {
                    picLAL101.Image = Properties.Resources.alerta_inativo;
                }

                if (LAL102)
                {
                    picLAL102.Image = Properties.Resources.alerta_ativo;
                }
                else
                {
                    picLAL102.Image = Properties.Resources.alerta_inativo;
                }

                if (LAH101)
                {
                    picLAH101.Image = Properties.Resources.alerta_ativo;
                }
                else
                {
                    picLAH101.Image = Properties.Resources.alerta_inativo;
                }

                if (LAH102)
                {
                    picLAH102.Image = Properties.Resources.alerta_ativo;
                }
                else
                {
                    picLAH102.Image = Properties.Resources.alerta_inativo;
                }

                //Mostrando erro na interface caso tenha ocorrido algum
                if (!string.IsNullOrEmpty(txtErro))
                {
                    lblBarraStatus.Text = txtErro;
                }


                lblSetpoint.Text = "Setpoint: " + setpoint.ToString("F1") + " cm";
                if (setpoint == 0)
                {
                    lblSetpoint.ForeColor = Color.Gray;
                    lblSetpoint.Font = new Font(lblSetpoint.Font, FontStyle.Regular);
                    lblBarraStatus.Text = "Setpoint desabilitado.";

                }
                else if (!setpointDefinido && setpoint > 0)
                {
                    lblSetpoint.ForeColor = Color.Red;
                    lblSetpoint.Font = new Font(lblSetpoint.Font, FontStyle.Bold);
                    lblBarraStatus.Text = "Setpoint ANTERIOR definido e reconhecido pelo Controlador";
                }
                else if (setpointDefinido)
                {
                    lblSetpoint.ForeColor = Color.DarkGreen;
                    lblSetpoint.Font = new Font(lblSetpoint.Font, FontStyle.Bold);
                    lblBarraStatus.Text = "Setpoint definido e reconhecido pelo Controlador";
                }
                else
                {
                    //MessageBox.Show("Setpoint enviado não foi reconhecido pelo Controlador.Verifique se está entre 2 e 16 cm", "Alerta de Setpoint Recusado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lblSetpoint.ForeColor = Color.Gray;
                    lblSetpoint.Font = new Font(lblSetpoint.Font, FontStyle.Regular);
                    lblBarraStatus.Text = "Setpoint enviado não foi reconhecido pelo Controlador. Verifique se está entre 2 e 16 cm";
                }

                //Armazenando os dados recebidos do Controlador em um buffer para processamento posterior

                var novoDadoNivel1 = new DadosSensor(nivel1);

                _bufferNivel1.Enqueue(novoDadoNivel1);

                // Limpa os dados que ultrapassaram os 300 segundos
                while (_bufferNivel1.Count > 0)
                {
                    var dadoMaisAntigo = _bufferNivel1.Peek();
                    if ((novoDadoNivel1.DataHora - dadoMaisAntigo.DataHora) > _tempoMaximo)
                    {
                        _bufferNivel1.Dequeue(); // Remove o dado velho
                    }
                    else
                    {
                        break; // Se o mais antigo está dentro dos 300s, os próximos também estão
                    }
                }

                var novoDadoNivel2 = new DadosSensor(nivel2);
                _bufferNivel2.Enqueue(novoDadoNivel2);

                while (_bufferNivel2.Count > 0)
                {
                    var dadoMaisAntigo = _bufferNivel2.Peek();
                    if ((novoDadoNivel2.DataHora - dadoMaisAntigo.DataHora) > _tempoMaximo)
                    {
                        _bufferNivel2.Dequeue(); // Remove o dado velho
                    }
                    else
                    {
                        break; // Se o mais antigo está dentro dos 300s, os próximos também estão
                    }
                }

                var novoDadoVazao = new DadosSensor(vazao);
                _bufferVazao.Enqueue(novoDadoVazao);
                while (_bufferVazao.Count > 0)
                {
                    var dadoMaisAntigo = _bufferVazao.Peek();
                    if ((novoDadoVazao.DataHora - dadoMaisAntigo.DataHora) > _tempoMaximo)
                    {
                        _bufferVazao.Dequeue(); // Remove o dado velho
                    }
                    else
                    {
                        break; // Se o mais antigo está dentro dos 300s, os próximos também estão
                    }
                }

                //Emergencia
                if (emergenciaAtiva)
                {
                    lblEmergencia.Visible = true;
                    picEmergencia.Visible = true;
                    btnStop.BackColor = Color.Gray;
                    btnStop.ForeColor = Color.Black;
                }
                else
                {
                    lblEmergencia.Visible = false;
                    picEmergencia.Visible = false;
                    btnStop.BackColor = Color.Red;
                    btnStop.ForeColor = Color.White;
                }


                //Atualizando os graficos 
                chart1.Series["Nivel TQ101 (cm)"].Points.AddXY(tempoAtual, nivel1);
                chart2.Series["Nivel TQ102 (cm)"].Points.AddXY(tempoAtual, nivel2);
                chart3.Series["Vazão Saída TQ102 (mL/min)"].Points.AddXY(tempoAtual, vazao);

                if (tempoAtual > chart1.ChartAreas["AreaTanque1"].AxisX.Maximum)
                {
                    chart1.ChartAreas["AreaTanque1"].AxisX.Maximum = tempoAtual;
                    chart1.ChartAreas["AreaTanque1"].AxisX.Minimum = tempoAtual - 60; // Mantém a janela de 60s
                }

                if (tempoAtual > chart2.ChartAreas["AreaTanque2"].AxisX.Maximum)
                {
                    chart2.ChartAreas["AreaTanque2"].AxisX.Maximum = tempoAtual;
                    chart2.ChartAreas["AreaTanque2"].AxisX.Minimum = tempoAtual - 60; // Mantém a janela de 60s
                }

                if (tempoAtual > chart3.ChartAreas["Vazao"].AxisX.Maximum)
                {
                    chart3.ChartAreas["Vazao"].AxisX.Maximum = tempoAtual;
                    chart3.ChartAreas["Vazao"].AxisX.Minimum = tempoAtual - 60; // Mantém a janela de 60s
                }

                //Logica animação valvula e tubulação quando tem liquido e TK102

                if (nivel2 > 0)
                {
                    //Fluido completa a entrada da valvula e da bomba P101, mas só completa a saída da válvula se ela estiver aberta
                    pnlEntradaP101.BackColor = Color.DodgerBlue;
                    pnlEntradaVavula.BackColor = Color.DodgerBlue;

                    if (LV102_aberta)
                    {
                        pnlSaidaValvula.BackColor = Color.DodgerBlue;
                        pnlSaidaValvula0.BackColor = Color.DodgerBlue;
                        pnlSaidaValvula1.BackColor = Color.DodgerBlue;
                    }
                    else
                    {
                        pnlSaidaValvula.BackColor = Color.WhiteSmoke;
                        pnlSaidaValvula0.BackColor = Color.WhiteSmoke;
                        pnlSaidaValvula1.BackColor = Color.WhiteSmoke;
                    }

                }
                else
                {
                    pnlEntradaVavula.BackColor = Color.WhiteSmoke;
                    pnlEntradaP101.BackColor = Color.WhiteSmoke;
                    pnlSaidaValvula.BackColor = Color.WhiteSmoke;
                    pnlSaidaValvula0.BackColor = Color.WhiteSmoke;
                    pnlSaidaValvula1.BackColor = Color.WhiteSmoke;

                }


                //Logica Animação Bomba e tubulação

                if (nivel1 > 0)
                {
                    pnlEntradaP102.BackColor = Color.DodgerBlue;
                    pnlEntradaFV101.BackColor = Color.Green;

                    if (P102_ligada)
                    {
                        pnlSaidaP102_0.BackColor = Color.DodgerBlue;
                        pnlSaidaP102_1.BackColor = Color.DodgerBlue;
                        pnlSaidaP102_2.BackColor = Color.DodgerBlue;

                    }
                    else
                    {
                        pnlSaidaP102_0.BackColor = Color.WhiteSmoke;
                        pnlSaidaP102_1.BackColor = Color.WhiteSmoke;
                        pnlSaidaP102_2.BackColor = Color.WhiteSmoke;

                    }


                    if (vazao > 0.01)
                    {
                        pnlSaidaFV101.BackColor = Color.Green;
                        fv102.Ligado = true;

                    }
                    else
                    {
                        pnlSaidaFV101.BackColor = Color.WhiteSmoke;
                        fv102.Ligado = false;
                    }



                }
                else
                {
                    pnlSaidaP102_0.BackColor = Color.WhiteSmoke;
                    pnlSaidaP102_1.BackColor = Color.WhiteSmoke;
                    pnlSaidaP102_2.BackColor = Color.WhiteSmoke;
                    pnlEntradaFV101.BackColor = Color.WhiteSmoke;
                }


                //Logica do Modo Manual/Automático
                if (ackModoManual)
                {
                    rdManual.Checked = true;
                    rdAuto.Checked = false;

                }
                else
                {
                    rdManual.Checked = false;
                    rdAuto.Checked = true;

                }

            }));
        }

        private void serialPort1_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            Console.WriteLine("Erro na comunicação serial: " + e.EventType);
        }

        private void lv102_Click(object sender, EventArgs e)
        {
            return;
        }

        /// <summary>
        /// Traz o volume em litros de um tanque cilíndrico, dado seu diâmetro e altura do líquido em cm
        /// </summary>
        /// <param name="diametro">Diâmetro do tanque em cm</param>
        /// <param name="altura">Altura do líquido em cm</param>
        /// <returns>Volume em litros</returns>


        private void p102_Click(object sender, EventArgs e)
        {

            if (emergenciaAtiva)
            {
                MessageBox.Show("Sistema em emergência! Não é possível acionar a bomba P102."); return;
            }

            if (ackModoManual == false)
            {
                MessageBox.Show("Sistema em modo automático! Não é possível acionar a bomba P102."); return;
            }


            if (serialPort1 != null && serialPort1.IsOpen)
            {
                try
                {

                    if (!P102_ligada)
                    {
                        // Envia o comando para LIGAR junto com uma quebra de linha (\n)
                        serialPort1.WriteLine("B2-1");
                        Console.WriteLine("Comando enviado: B1 (Acionar Bomba 2)");
                    }
                    else
                    {
                        // Envia o comando para DESLIGAR
                        serialPort1.WriteLine("B2-0");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao enviar comando para a serial: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("A porta serial não está conectada!");
            }
        }

        private void tq102_NivelChanged(object sender, EventArgs e)
        {
            lblNivelTanque2.Text = "Nível TK-102: " + nivel2.ToString("F1") + " cm (" + volume2.ToString("F1") + " L)";

            volume1 = tq101.Volume;

        }

        private void tq101_NivelChanged(object sender, EventArgs e)
        {
            lblNivelTanque1.Text = "Nível TK-101: " + nivel1.ToString("F1") + " cm (" + volume1.ToString("F1") + " L)";
            volume2 = tq102.Volume;
            if (nivel1 > 14)
            {
                picRiscoTK101.Visible = true;
                lblRiscoTK101.Visible = true;
            }
            else
            {
                picRiscoTK101.Visible = false;
                lblRiscoTK101.Visible = false;
            }
        }

        private void pnlPlanta_Paint(object sender, PaintEventArgs e)
        {

        }



        private void btnSetpoint_Click_1(object sender, EventArgs e)
        {
            double h_set = 0;
            string texto = txtSetpoint.Text;
            string texto_envio = "";
            if (texto.Length > 0)
            {
                if (ackModoManual)
                {
                    MessageBox.Show("Sistema em modo manual!");
                    return;
                }

                try
                {
                    h_set = double.Parse(texto.Replace(".", ","));
                    texto_envio = h_set.ToString("F1", CultureInfo.InvariantCulture);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Valor de setpoint inválido. Por favor, insira um número válido.");
                    return;
                }

                if (serialPort1 != null && serialPort1.IsOpen)
                {
                    try
                    {
                        serialPort1.WriteLine("SP" + texto_envio);
                        setpointEnviado = h_set;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao enviar comando para a serial: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("A porta serial não está conectada!");
                }

                



            }

        }

        private void btnConexaoSerial_Click(object sender, EventArgs e)
        {
            InicializaSerial();
        }

        private void btnALternarModo_Click(object sender, EventArgs e)
        {

            if (emergenciaAtiva)
            {
                MessageBox.Show("Sistema em emergência! Não é possível alternar o modo."); return;
            }



            int modoSolicitado = ackModoManual ? 0 : 1;

            if (serialPort1 != null && serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.WriteLine("MO" + modoSolicitado.ToString());


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao enviar comando para a serial: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("A porta serial não está conectada!");
            }


        }

        private void p101_Click(object sender, EventArgs e)
        {

            if (emergenciaAtiva)
            {
                MessageBox.Show("Sistema em emergência! Não é possível acionar a bomba P101."); return;
            }


            if (ackModoManual == false)
            {
                MessageBox.Show("Sistema em modo automático! Não é possível acionar a bomba P101."); return;
            }


            if (serialPort1 != null && serialPort1.IsOpen)
            {
                try
                {

                    if (!P101_ligada)
                    {
                        // Envia o comando para LIGAR junto com uma quebra de linha (\n)
                        serialPort1.WriteLine("B1-1");
                        Console.WriteLine("Comando enviado: B1 (Acionar Bomba 1)");
                    }
                    else
                    {
                        // Envia o comando para DESLIGAR
                        serialPort1.WriteLine("B1-0");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao enviar comando para a serial: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("A porta serial não está conectada!");
            }
        }

        public void ExportarParaCsv(Queue<DadosSensor> buffer, string nomeSensor)
        {
            List<DadosSensor> copiaDados;

            // Fazemos uma cópia rápida para não bloquear a thread do sensor enquanto salva no disco
            //lock (_lock)
            //{
            copiaDados = buffer.ToList();
            //}

            if (copiaDados.Count == 0)
                return;

            string pastaDoExe = AppDomain.CurrentDomain.BaseDirectory;
            string caminho = Path.Combine(pastaDoExe, nomeSensor + "_" + DateTime.Now.ToString("ddMMyyyyHHmmss") + ".csv");


            try
            {
                using (StreamWriter sw = new StreamWriter(caminho, false, Encoding.UTF8))
                {
                    sw.WriteLine("sep=;");

                    // Escreve o cabeçalho
                    sw.WriteLine("DataHora,Valor");

                    // Escreve as linhas
                    foreach (var dado in copiaDados)
                    {
                        sw.WriteLine($"{dado.DataHora:yyyy-MM-dd HH:mm:ss.fff};{dado.Valor.ToString(new System.Globalization.CultureInfo("pt-BR"))}");
                       
                    }
                }
            }
            catch (Exception ex)
            {
                // Trate o erro de gravação de arquivo (ex: arquivo aberto, falta de permissão)
                Console.WriteLine($"Erro ao exportar CSV: {ex.Message}");
            }

            MessageBox.Show("Arquivo CSV exportado com sucesso para: " + caminho, "Exportação Concluída", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExportarParaCsv(_bufferNivel1, "LT101");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ExportarParaCsv(_bufferNivel2,"LT102");
        }

        private void btnExportaVazao_Click(object sender, EventArgs e)
        {
            ExportarParaCsv(_bufferVazao,"FT101");
        }

        private void btnStop_Click_1(object sender, EventArgs e)
        {
            //Envia comando para desabilitar tudo e parar o sistema. Requer reiniciar o Controllino.
            if (serialPort1 != null && serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.WriteLine("EM");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao enviar comando para a serial: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("A porta serial não está conectada!");
            }
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
