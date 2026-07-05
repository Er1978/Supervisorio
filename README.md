# Protótipo de Controle de Nível em Tanques

Este repositório contém o código-fonte do sistema de controle e da interface supervisória desenvolvidos para o projeto físico de **Controle de Nível de Líquidos em Tanques**, parte integrante do curso de Engenharia de Controle e Automação da Universidade Federal da Bahia (UFBA).

## 📋 Sobre o Projeto

O projeto consiste em um sistema de controle em malha fechada projetado para manter a estabilidade do nível de um tanque superior (TK-102), simulando a dinâmica de um processo industrial contínuo com fluido turbulento. O controle lógico, o processamento de sinais e o intertravamento de segurança são realizados por um Controlador Lógico Programável (CLP) de padrão industrial. A operação, o monitoramento e a aquisição de dados em tempo real ocorrem através de uma interface gráfica customizada de supervisão (SCADA).

## 🗂️ Estrutura do Repositório

* **/**: Contém a solução completa da interface gráfica desenvolvida em C#. É responsável pela comunicação serial com a planta, definição de *setpoints*, controle manual/automático, exibição gráfica dinâmica e exportação de relatórios (datalogger) em `.csv`.
* **`controllino.ino`**: Firmware principal desenvolvido para o **Controllino Maxi Automation Pure**. Contém a lógica de busca do *setpoint*, cálculo de margens e zonas mortas (histerese), modulação PWM das bombas de engrenagem e rotinas de intertravamento de segurança contra transbordamento.
* **/fotos/**: Registro fotográfico detalhando a montagem da estrutura física em MDF, o arranjo do sistema hidráulico, os componentes eletrônicos e a fixação da placa de interface (*level shifter*).

## ⚙️ Hardware Utilizado

A planta física foi construída com os seguintes componentes principais:
* **Controlador Lógico:** Controllino Maxi Automation Pure (Alimentação 20-24V).
* **Instrumentação de Nível:** Sensores ultrassônicos HC-SR04 (com interface de conversão lógica 5V/20V) e Chave de nível magnética tipo boia horizontal (LSH).
* **Instrumentação de Vazão:** Sensor por efeito Hall YF-S401.
* **Elementos Finais de Controle:** Minibombas de engrenagem RS-385 (Motor DC 6-12V) e Válvula Solenoide Diafragma (24V NF).
* **Eletrônica Auxiliar:** Placa de circuito customizada atuando como conversor de nível lógico (*Level Shifter* bidirecional TTL/CLP) com CIs ULN2803A e 74AHC04.

## 🚀 Como Utilizar

1.  **Hardware (Firmware):** Abra o arquivo `controllino.ino` na IDE do Arduino. Certifique-se de ter a placa *Controllino* instalada no Gerenciador de Placas. Selecione "Controllino MAXI Automation" e faça o upload para o equipamento.
2.  **Software (Supervisório):** Abra a solução `.sln` localizada na pasta C# no Visual Studio. Compile e inicie a aplicação. Na interface principal, selecione a porta COM correspondente à conexão USB do controlador e clique em "Conectar Serial".

## 👨‍💻 Autores

* Cláudio Kauê Ribeiro Oliveira
* Eliezer Rocha Nogueira
* Francisco Belon Soares da Silva
* Italo Conceição Santana Silva
* Wallace Fábio Ferreira Cruz

**Universidade Federal da Bahia (UFBA) - Escola Politécnica**
Salvador - BA, 2026.
