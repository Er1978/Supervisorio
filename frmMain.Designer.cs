namespace Supervisorio
{
    partial class frmMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlPlanta = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.picRiscoTK101 = new System.Windows.Forms.PictureBox();
            this.lblRiscoTK101 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblEmergencia = new System.Windows.Forms.Label();
            this.picEmergencia = new System.Windows.Forms.PictureBox();
            this.pnlSaidaValvula0 = new System.Windows.Forms.Panel();
            this.lblTensaoP102 = new System.Windows.Forms.Label();
            this.lblTensaoP101 = new System.Windows.Forms.Label();
            this.pnlSaidaValvula1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblVazao = new System.Windows.Forms.Label();
            this.fv102 = new Supervisorio.Controles.vavula();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblLAH101 = new System.Windows.Forms.Label();
            this.picLAH101 = new System.Windows.Forms.PictureBox();
            this.lv102 = new Supervisorio.Controles.vavula();
            this.p101 = new Supervisorio.Controles.bomba();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.lblBarraStatus = new System.Windows.Forms.Label();
            this.pnlSetPoint = new System.Windows.Forms.Panel();
            this.picSP = new System.Windows.Forms.PictureBox();
            this.lblSetpoint = new System.Windows.Forms.Label();
            this.pnlLAL101 = new System.Windows.Forms.Panel();
            this.lblLAL101 = new System.Windows.Forms.Label();
            this.picLAL101 = new System.Windows.Forms.PictureBox();
            this.pnlLAL102 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.picLAL102 = new System.Windows.Forms.PictureBox();
            this.pnlLAH102 = new System.Windows.Forms.Panel();
            this.lblLAH102 = new System.Windows.Forms.Label();
            this.picLAH102 = new System.Windows.Forms.PictureBox();
            this.lblNivelTanque2 = new System.Windows.Forms.Label();
            this.lblNivelTanque1 = new System.Windows.Forms.Label();
            this.tq102 = new Supervisorio.Controles.tanque();
            this.pnlSaidaP102_2 = new System.Windows.Forms.Panel();
            this.pnlSaidaP102_1 = new System.Windows.Forms.Panel();
            this.pnlSaidaP102_0 = new System.Windows.Forms.Panel();
            this.p102 = new Supervisorio.Controles.bomba();
            this.tq101 = new Supervisorio.Controles.tanque();
            this.pnlEntradaP102 = new System.Windows.Forms.Panel();
            this.pnlEntradaVavula = new System.Windows.Forms.Panel();
            this.pnlSaidaValvula = new System.Windows.Forms.Panel();
            this.pnlEntradaP101 = new System.Windows.Forms.Panel();
            this.pnlEntradaFV101 = new System.Windows.Forms.Panel();
            this.pnlSaidaFV101 = new System.Windows.Forms.Panel();
            this.tlpControles = new System.Windows.Forms.TableLayoutPanel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlComandos = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnStop = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnExportaVazao = new System.Windows.Forms.Button();
            this.btnExportaNivel2 = new System.Windows.Forms.Button();
            this.btnExportaNivel1 = new System.Windows.Forms.Button();
            this.btnSetpoint = new System.Windows.Forms.Button();
            this.txtSetpoint = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlAlertas = new System.Windows.Forms.Panel();
            this.btnALternarModo = new System.Windows.Forms.Button();
            this.grpModo = new System.Windows.Forms.GroupBox();
            this.rdManual = new System.Windows.Forms.RadioButton();
            this.rdAuto = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnConexaoSerial = new System.Windows.Forms.Button();
            this.lblConexao = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tlpMain.SuspendLayout();
            this.pnlPlanta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRiscoTK101)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmergencia)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLAH101)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.pnlSetPoint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSP)).BeginInit();
            this.pnlLAL101.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLAL101)).BeginInit();
            this.pnlLAL102.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLAL102)).BeginInit();
            this.pnlLAH102.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLAH102)).BeginInit();
            this.tlpControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.pnlComandos.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlAlertas.SuspendLayout();
            this.grpModo.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1284, 42);
            this.panel1.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(1284, 42);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "CONTROLE DE NÍVEL - ÁREA 100 - TK102";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.tlpMain);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 42);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1284, 666);
            this.panel2.TabIndex = 1;
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 762F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.pnlPlanta, 0, 0);
            this.tlpMain.Controls.Add(this.tlpControles, 1, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(2);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(1284, 666);
            this.tlpMain.TabIndex = 0;
            // 
            // pnlPlanta
            // 
            this.pnlPlanta.BackColor = System.Drawing.Color.SkyBlue;
            this.pnlPlanta.Controls.Add(this.label6);
            this.pnlPlanta.Controls.Add(this.picRiscoTK101);
            this.pnlPlanta.Controls.Add(this.lblRiscoTK101);
            this.pnlPlanta.Controls.Add(this.label5);
            this.pnlPlanta.Controls.Add(this.lblEmergencia);
            this.pnlPlanta.Controls.Add(this.picEmergencia);
            this.pnlPlanta.Controls.Add(this.pnlSaidaValvula0);
            this.pnlPlanta.Controls.Add(this.lblTensaoP102);
            this.pnlPlanta.Controls.Add(this.lblTensaoP101);
            this.pnlPlanta.Controls.Add(this.pnlSaidaValvula1);
            this.pnlPlanta.Controls.Add(this.label4);
            this.pnlPlanta.Controls.Add(this.label2);
            this.pnlPlanta.Controls.Add(this.lblVazao);
            this.pnlPlanta.Controls.Add(this.fv102);
            this.pnlPlanta.Controls.Add(this.panel5);
            this.pnlPlanta.Controls.Add(this.lv102);
            this.pnlPlanta.Controls.Add(this.p101);
            this.pnlPlanta.Controls.Add(this.pnlBottom);
            this.pnlPlanta.Controls.Add(this.pnlSetPoint);
            this.pnlPlanta.Controls.Add(this.pnlLAL101);
            this.pnlPlanta.Controls.Add(this.pnlLAL102);
            this.pnlPlanta.Controls.Add(this.pnlLAH102);
            this.pnlPlanta.Controls.Add(this.lblNivelTanque2);
            this.pnlPlanta.Controls.Add(this.lblNivelTanque1);
            this.pnlPlanta.Controls.Add(this.tq102);
            this.pnlPlanta.Controls.Add(this.pnlSaidaP102_2);
            this.pnlPlanta.Controls.Add(this.pnlSaidaP102_1);
            this.pnlPlanta.Controls.Add(this.pnlSaidaP102_0);
            this.pnlPlanta.Controls.Add(this.p102);
            this.pnlPlanta.Controls.Add(this.tq101);
            this.pnlPlanta.Controls.Add(this.pnlEntradaP102);
            this.pnlPlanta.Controls.Add(this.pnlEntradaVavula);
            this.pnlPlanta.Controls.Add(this.pnlSaidaValvula);
            this.pnlPlanta.Controls.Add(this.pnlEntradaP101);
            this.pnlPlanta.Controls.Add(this.pnlEntradaFV101);
            this.pnlPlanta.Controls.Add(this.pnlSaidaFV101);
            this.pnlPlanta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPlanta.Location = new System.Drawing.Point(2, 2);
            this.pnlPlanta.Margin = new System.Windows.Forms.Padding(2);
            this.pnlPlanta.Name = "pnlPlanta";
            this.pnlPlanta.Size = new System.Drawing.Size(758, 662);
            this.pnlPlanta.TabIndex = 0;
            this.pnlPlanta.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPlanta_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(629, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "LV-102";
            // 
            // picRiscoTK101
            // 
            this.picRiscoTK101.Image = global::Supervisorio.Properties.Resources.alerta_ativo;
            this.picRiscoTK101.Location = new System.Drawing.Point(5, 216);
            this.picRiscoTK101.Name = "picRiscoTK101";
            this.picRiscoTK101.Size = new System.Drawing.Size(28, 27);
            this.picRiscoTK101.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRiscoTK101.TabIndex = 26;
            this.picRiscoTK101.TabStop = false;
            this.picRiscoTK101.Visible = false;
            // 
            // lblRiscoTK101
            // 
            this.lblRiscoTK101.AutoSize = true;
            this.lblRiscoTK101.BackColor = System.Drawing.Color.Yellow;
            this.lblRiscoTK101.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRiscoTK101.ForeColor = System.Drawing.Color.Red;
            this.lblRiscoTK101.Location = new System.Drawing.Point(33, 221);
            this.lblRiscoTK101.Name = "lblRiscoTK101";
            this.lblRiscoTK101.Size = new System.Drawing.Size(288, 16);
            this.lblRiscoTK101.TabIndex = 25;
            this.lblRiscoTK101.Text = "RISCO DE TRANSBORDAMENTO TK101";
            this.lblRiscoTK101.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(540, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "FV-101";
            // 
            // lblEmergencia
            // 
            this.lblEmergencia.AutoSize = true;
            this.lblEmergencia.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblEmergencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmergencia.ForeColor = System.Drawing.Color.Red;
            this.lblEmergencia.Location = new System.Drawing.Point(15, 97);
            this.lblEmergencia.Name = "lblEmergencia";
            this.lblEmergencia.Size = new System.Drawing.Size(197, 16);
            this.lblEmergencia.TabIndex = 23;
            this.lblEmergencia.Text = "ESTADO DE EMERGÊNCIA";
            this.lblEmergencia.Visible = false;
            // 
            // picEmergencia
            // 
            this.picEmergencia.Image = global::Supervisorio.Properties.Resources.alerta_ativo;
            this.picEmergencia.Location = new System.Drawing.Point(72, 17);
            this.picEmergencia.Name = "picEmergencia";
            this.picEmergencia.Size = new System.Drawing.Size(84, 77);
            this.picEmergencia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEmergencia.TabIndex = 22;
            this.picEmergencia.TabStop = false;
            this.picEmergencia.Visible = false;
            // 
            // pnlSaidaValvula0
            // 
            this.pnlSaidaValvula0.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlSaidaValvula0.Location = new System.Drawing.Point(642, 305);
            this.pnlSaidaValvula0.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSaidaValvula0.Name = "pnlSaidaValvula0";
            this.pnlSaidaValvula0.Size = new System.Drawing.Size(8, 243);
            this.pnlSaidaValvula0.TabIndex = 5;
            // 
            // lblTensaoP102
            // 
            this.lblTensaoP102.AutoSize = true;
            this.lblTensaoP102.Location = new System.Drawing.Point(290, 527);
            this.lblTensaoP102.Name = "lblTensaoP102";
            this.lblTensaoP102.Size = new System.Drawing.Size(23, 13);
            this.lblTensaoP102.TabIndex = 21;
            this.lblTensaoP102.Text = "0 V";
            // 
            // lblTensaoP101
            // 
            this.lblTensaoP101.AutoSize = true;
            this.lblTensaoP101.Location = new System.Drawing.Point(545, 346);
            this.lblTensaoP101.Name = "lblTensaoP101";
            this.lblTensaoP101.Size = new System.Drawing.Size(23, 13);
            this.lblTensaoP101.TabIndex = 20;
            this.lblTensaoP101.Text = "0 V";
            // 
            // pnlSaidaValvula1
            // 
            this.pnlSaidaValvula1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlSaidaValvula1.Location = new System.Drawing.Point(632, 298);
            this.pnlSaidaValvula1.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSaidaValvula1.Name = "pnlSaidaValvula1";
            this.pnlSaidaValvula1.Size = new System.Drawing.Size(18, 8);
            this.pnlSaidaValvula1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 450);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "P-102";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(541, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "P-101";
            // 
            // lblVazao
            // 
            this.lblVazao.AutoSize = true;
            this.lblVazao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVazao.Location = new System.Drawing.Point(597, 221);
            this.lblVazao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVazao.Name = "lblVazao";
            this.lblVazao.Size = new System.Drawing.Size(113, 17);
            this.lblVazao.TabIndex = 11;
            this.lblVazao.Text = "Vazão: 0 mL/min";
            // 
            // fv102
            // 
            this.fv102.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fv102.Ligado = false;
            this.fv102.Location = new System.Drawing.Point(538, 227);
            this.fv102.Margin = new System.Windows.Forms.Padding(4);
            this.fv102.Name = "fv102";
            this.fv102.Size = new System.Drawing.Size(34, 33);
            this.fv102.TabIndex = 17;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblLAH101);
            this.panel5.Controls.Add(this.picLAH101);
            this.panel5.Location = new System.Drawing.Point(11, 313);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(104, 24);
            this.panel5.TabIndex = 13;
            // 
            // lblLAH101
            // 
            this.lblLAH101.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblLAH101.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLAH101.Location = new System.Drawing.Point(22, 0);
            this.lblLAH101.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLAH101.Name = "lblLAH101";
            this.lblLAH101.Size = new System.Drawing.Size(84, 24);
            this.lblLAH101.TabIndex = 1;
            this.lblLAH101.Text = "LAH101 (14 cm)";
            this.lblLAH101.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picLAH101
            // 
            this.picLAH101.Dock = System.Windows.Forms.DockStyle.Left;
            this.picLAH101.Image = global::Supervisorio.Properties.Resources.alerta_inativo;
            this.picLAH101.Location = new System.Drawing.Point(0, 0);
            this.picLAH101.Margin = new System.Windows.Forms.Padding(2);
            this.picLAH101.Name = "picLAH101";
            this.picLAH101.Size = new System.Drawing.Size(22, 24);
            this.picLAH101.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLAH101.TabIndex = 0;
            this.picLAH101.TabStop = false;
            // 
            // lv102
            // 
            this.lv102.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lv102.Ligado = false;
            this.lv102.Location = new System.Drawing.Point(600, 277);
            this.lv102.Margin = new System.Windows.Forms.Padding(4);
            this.lv102.Name = "lv102";
            this.lv102.Size = new System.Drawing.Size(34, 33);
            this.lv102.TabIndex = 3;
            // 
            // p101
            // 
            this.p101.Cursor = System.Windows.Forms.Cursors.Hand;
            this.p101.Ligado = false;
            this.p101.Location = new System.Drawing.Point(531, 284);
            this.p101.Margin = new System.Windows.Forms.Padding(4);
            this.p101.Name = "p101";
            this.p101.Size = new System.Drawing.Size(53, 58);
            this.p101.TabIndex = 16;
            this.p101.Tensao = 0D;
            this.p101.TensaoMaxima = 12D;
            this.p101.TensaoMinima = 6D;
            this.p101.Click += new System.EventHandler(this.p101_Click);
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.LightGray;
            this.pnlBottom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBottom.Controls.Add(this.lblBarraStatus);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 642);
            this.pnlBottom.Margin = new System.Windows.Forms.Padding(2);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(758, 20);
            this.pnlBottom.TabIndex = 15;
            // 
            // lblBarraStatus
            // 
            this.lblBarraStatus.AutoSize = true;
            this.lblBarraStatus.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblBarraStatus.Location = new System.Drawing.Point(0, 0);
            this.lblBarraStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBarraStatus.Name = "lblBarraStatus";
            this.lblBarraStatus.Size = new System.Drawing.Size(35, 13);
            this.lblBarraStatus.TabIndex = 0;
            this.lblBarraStatus.Text = "label2";
            // 
            // pnlSetPoint
            // 
            this.pnlSetPoint.Controls.Add(this.picSP);
            this.pnlSetPoint.Controls.Add(this.lblSetpoint);
            this.pnlSetPoint.Location = new System.Drawing.Point(514, 100);
            this.pnlSetPoint.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSetPoint.Name = "pnlSetPoint";
            this.pnlSetPoint.Size = new System.Drawing.Size(156, 24);
            this.pnlSetPoint.TabIndex = 13;
            // 
            // picSP
            // 
            this.picSP.Dock = System.Windows.Forms.DockStyle.Left;
            this.picSP.Image = global::Supervisorio.Properties.Resources.setpoint;
            this.picSP.Location = new System.Drawing.Point(0, 0);
            this.picSP.Margin = new System.Windows.Forms.Padding(2);
            this.picSP.Name = "picSP";
            this.picSP.Size = new System.Drawing.Size(22, 24);
            this.picSP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSP.TabIndex = 0;
            this.picSP.TabStop = false;
            // 
            // lblSetpoint
            // 
            this.lblSetpoint.AutoSize = true;
            this.lblSetpoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetpoint.Location = new System.Drawing.Point(26, 4);
            this.lblSetpoint.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSetpoint.Name = "lblSetpoint";
            this.lblSetpoint.Size = new System.Drawing.Size(77, 17);
            this.lblSetpoint.TabIndex = 10;
            this.lblSetpoint.Text = "SETPOINT";
            // 
            // pnlLAL101
            // 
            this.pnlLAL101.Controls.Add(this.lblLAL101);
            this.pnlLAL101.Controls.Add(this.picLAL101);
            this.pnlLAL101.Location = new System.Drawing.Point(11, 548);
            this.pnlLAL101.Margin = new System.Windows.Forms.Padding(2);
            this.pnlLAL101.Name = "pnlLAL101";
            this.pnlLAL101.Size = new System.Drawing.Size(104, 24);
            this.pnlLAL101.TabIndex = 13;
            // 
            // lblLAL101
            // 
            this.lblLAL101.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblLAL101.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLAL101.Location = new System.Drawing.Point(22, 0);
            this.lblLAL101.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLAL101.Name = "lblLAL101";
            this.lblLAL101.Size = new System.Drawing.Size(76, 24);
            this.lblLAL101.TabIndex = 1;
            this.lblLAL101.Text = "LAL101 (1 cm)";
            this.lblLAL101.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picLAL101
            // 
            this.picLAL101.Dock = System.Windows.Forms.DockStyle.Left;
            this.picLAL101.Image = global::Supervisorio.Properties.Resources.alerta_inativo;
            this.picLAL101.Location = new System.Drawing.Point(0, 0);
            this.picLAL101.Margin = new System.Windows.Forms.Padding(2);
            this.picLAL101.Name = "picLAL101";
            this.picLAL101.Size = new System.Drawing.Size(22, 24);
            this.picLAL101.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLAL101.TabIndex = 0;
            this.picLAL101.TabStop = false;
            // 
            // pnlLAL102
            // 
            this.pnlLAL102.Controls.Add(this.label3);
            this.pnlLAL102.Controls.Add(this.picLAL102);
            this.pnlLAL102.Location = new System.Drawing.Point(495, 361);
            this.pnlLAL102.Margin = new System.Windows.Forms.Padding(2);
            this.pnlLAL102.Name = "pnlLAL102";
            this.pnlLAL102.Size = new System.Drawing.Size(122, 24);
            this.pnlLAL102.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "LAL102 (4 cm)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picLAL102
            // 
            this.picLAL102.Dock = System.Windows.Forms.DockStyle.Left;
            this.picLAL102.Image = global::Supervisorio.Properties.Resources.alerta_inativo;
            this.picLAL102.Location = new System.Drawing.Point(0, 0);
            this.picLAL102.Margin = new System.Windows.Forms.Padding(2);
            this.picLAL102.Name = "picLAL102";
            this.picLAL102.Size = new System.Drawing.Size(22, 24);
            this.picLAL102.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLAL102.TabIndex = 0;
            this.picLAL102.TabStop = false;
            // 
            // pnlLAH102
            // 
            this.pnlLAH102.Controls.Add(this.lblLAH102);
            this.pnlLAH102.Controls.Add(this.picLAH102);
            this.pnlLAH102.Location = new System.Drawing.Point(514, 60);
            this.pnlLAH102.Margin = new System.Windows.Forms.Padding(2);
            this.pnlLAH102.Name = "pnlLAH102";
            this.pnlLAH102.Size = new System.Drawing.Size(132, 24);
            this.pnlLAH102.TabIndex = 12;
            // 
            // lblLAH102
            // 
            this.lblLAH102.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblLAH102.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLAH102.Location = new System.Drawing.Point(22, 0);
            this.lblLAH102.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLAH102.Name = "lblLAH102";
            this.lblLAH102.Size = new System.Drawing.Size(84, 24);
            this.lblLAH102.TabIndex = 1;
            this.lblLAH102.Text = "LAH102 (12 cm)";
            this.lblLAH102.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picLAH102
            // 
            this.picLAH102.Dock = System.Windows.Forms.DockStyle.Left;
            this.picLAH102.Image = global::Supervisorio.Properties.Resources.alerta_inativo;
            this.picLAH102.Location = new System.Drawing.Point(0, 0);
            this.picLAH102.Margin = new System.Windows.Forms.Padding(2);
            this.picLAH102.Name = "picLAH102";
            this.picLAH102.Size = new System.Drawing.Size(22, 24);
            this.picLAH102.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLAH102.TabIndex = 0;
            this.picLAH102.TabStop = false;
            // 
            // lblNivelTanque2
            // 
            this.lblNivelTanque2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivelTanque2.Location = new System.Drawing.Point(290, 31);
            this.lblNivelTanque2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNivelTanque2.Name = "lblNivelTanque2";
            this.lblNivelTanque2.Size = new System.Drawing.Size(296, 17);
            this.lblNivelTanque2.TabIndex = 7;
            this.lblNivelTanque2.Text = "NÍVEL TQ 102: 0 cm";
            this.lblNivelTanque2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNivelTanque1
            // 
            this.lblNivelTanque1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivelTanque1.Location = new System.Drawing.Point(56, 254);
            this.lblNivelTanque1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNivelTanque1.Name = "lblNivelTanque1";
            this.lblNivelTanque1.Size = new System.Drawing.Size(271, 17);
            this.lblNivelTanque1.TabIndex = 6;
            this.lblNivelTanque1.Text = "NÍVEL TQ 101: 0 cm";
            this.lblNivelTanque1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tq102
            // 
            this.tq102.Altura = 0D;
            this.tq102.Diametro = 0D;
            this.tq102.Location = new System.Drawing.Point(368, 52);
            this.tq102.Margin = new System.Windows.Forms.Padding(4);
            this.tq102.Name = "tq102";
            this.tq102.Nivel = 0;
            this.tq102.NomeTanque = "TK-102";
            this.tq102.Size = new System.Drawing.Size(142, 350);
            this.tq102.TabIndex = 1;
            this.tq102.NivelChanged += new System.EventHandler(this.tq102_NivelChanged);
            // 
            // pnlSaidaP102_2
            // 
            this.pnlSaidaP102_2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlSaidaP102_2.Location = new System.Drawing.Point(338, 76);
            this.pnlSaidaP102_2.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSaidaP102_2.Name = "pnlSaidaP102_2";
            this.pnlSaidaP102_2.Size = new System.Drawing.Size(49, 8);
            this.pnlSaidaP102_2.TabIndex = 9;
            // 
            // pnlSaidaP102_1
            // 
            this.pnlSaidaP102_1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlSaidaP102_1.Location = new System.Drawing.Point(338, 79);
            this.pnlSaidaP102_1.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSaidaP102_1.Name = "pnlSaidaP102_1";
            this.pnlSaidaP102_1.Size = new System.Drawing.Size(8, 411);
            this.pnlSaidaP102_1.TabIndex = 8;
            // 
            // pnlSaidaP102_0
            // 
            this.pnlSaidaP102_0.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlSaidaP102_0.Location = new System.Drawing.Point(327, 484);
            this.pnlSaidaP102_0.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSaidaP102_0.Name = "pnlSaidaP102_0";
            this.pnlSaidaP102_0.Size = new System.Drawing.Size(19, 8);
            this.pnlSaidaP102_0.TabIndex = 7;
            // 
            // p102
            // 
            this.p102.Cursor = System.Windows.Forms.Cursors.Hand;
            this.p102.Ligado = false;
            this.p102.Location = new System.Drawing.Point(274, 467);
            this.p102.Margin = new System.Windows.Forms.Padding(4);
            this.p102.Name = "p102";
            this.p102.Size = new System.Drawing.Size(53, 58);
            this.p102.TabIndex = 2;
            this.p102.Tensao = 0D;
            this.p102.TensaoMaxima = 12D;
            this.p102.TensaoMinima = 6D;
            this.p102.Click += new System.EventHandler(this.p102_Click);
            // 
            // tq101
            // 
            this.tq101.Altura = 0D;
            this.tq101.Diametro = 0D;
            this.tq101.Location = new System.Drawing.Point(118, 275);
            this.tq101.Margin = new System.Windows.Forms.Padding(4);
            this.tq101.Name = "tq101";
            this.tq101.Nivel = 0;
            this.tq101.NomeTanque = "TK-101";
            this.tq101.Size = new System.Drawing.Size(142, 350);
            this.tq101.TabIndex = 0;
            this.tq101.NivelChanged += new System.EventHandler(this.tq101_NivelChanged);
            // 
            // pnlEntradaP102
            // 
            this.pnlEntradaP102.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlEntradaP102.Location = new System.Drawing.Point(215, 502);
            this.pnlEntradaP102.Margin = new System.Windows.Forms.Padding(2);
            this.pnlEntradaP102.Name = "pnlEntradaP102";
            this.pnlEntradaP102.Size = new System.Drawing.Size(59, 8);
            this.pnlEntradaP102.TabIndex = 6;
            // 
            // pnlEntradaVavula
            // 
            this.pnlEntradaVavula.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlEntradaVavula.Location = new System.Drawing.Point(544, 299);
            this.pnlEntradaVavula.Margin = new System.Windows.Forms.Padding(2);
            this.pnlEntradaVavula.Name = "pnlEntradaVavula";
            this.pnlEntradaVavula.Size = new System.Drawing.Size(61, 8);
            this.pnlEntradaVavula.TabIndex = 5;
            // 
            // pnlSaidaValvula
            // 
            this.pnlSaidaValvula.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlSaidaValvula.Location = new System.Drawing.Point(217, 540);
            this.pnlSaidaValvula.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSaidaValvula.Name = "pnlSaidaValvula";
            this.pnlSaidaValvula.Size = new System.Drawing.Size(433, 8);
            this.pnlSaidaValvula.TabIndex = 4;
            // 
            // pnlEntradaP101
            // 
            this.pnlEntradaP101.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlEntradaP101.Location = new System.Drawing.Point(476, 321);
            this.pnlEntradaP101.Margin = new System.Windows.Forms.Padding(2);
            this.pnlEntradaP101.Name = "pnlEntradaP101";
            this.pnlEntradaP101.Size = new System.Drawing.Size(61, 8);
            this.pnlEntradaP101.TabIndex = 6;
            // 
            // pnlEntradaFV101
            // 
            this.pnlEntradaFV101.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlEntradaFV101.Location = new System.Drawing.Point(414, 247);
            this.pnlEntradaFV101.Margin = new System.Windows.Forms.Padding(2);
            this.pnlEntradaFV101.Name = "pnlEntradaFV101";
            this.pnlEntradaFV101.Size = new System.Drawing.Size(127, 8);
            this.pnlEntradaFV101.TabIndex = 8;
            // 
            // pnlSaidaFV101
            // 
            this.pnlSaidaFV101.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlSaidaFV101.Location = new System.Drawing.Point(549, 247);
            this.pnlSaidaFV101.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSaidaFV101.Name = "pnlSaidaFV101";
            this.pnlSaidaFV101.Size = new System.Drawing.Size(88, 8);
            this.pnlSaidaFV101.TabIndex = 9;
            // 
            // tlpControles
            // 
            this.tlpControles.ColumnCount = 1;
            this.tlpControles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpControles.Controls.Add(this.chart1, 0, 0);
            this.tlpControles.Controls.Add(this.chart2, 0, 1);
            this.tlpControles.Controls.Add(this.chart3, 0, 2);
            this.tlpControles.Controls.Add(this.pnlComandos, 0, 3);
            this.tlpControles.Controls.Add(this.pnlAlertas, 0, 4);
            this.tlpControles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpControles.Location = new System.Drawing.Point(764, 2);
            this.tlpControles.Margin = new System.Windows.Forms.Padding(2);
            this.tlpControles.Name = "tlpControles";
            this.tlpControles.RowCount = 5;
            this.tlpControles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33389F));
            this.tlpControles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33389F));
            this.tlpControles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33222F));
            this.tlpControles.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpControles.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpControles.Size = new System.Drawing.Size(518, 662);
            this.tlpControles.TabIndex = 1;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(2, 2);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(514, 163);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            this.chart2.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(2, 169);
            this.chart2.Margin = new System.Windows.Forms.Padding(2);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(514, 163);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // chart3
            // 
            chartArea3.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea3);
            this.chart3.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chart3.Legends.Add(legend3);
            this.chart3.Location = new System.Drawing.Point(2, 336);
            this.chart3.Margin = new System.Windows.Forms.Padding(2);
            this.chart3.Name = "chart3";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart3.Series.Add(series3);
            this.chart3.Size = new System.Drawing.Size(514, 162);
            this.chart3.TabIndex = 4;
            this.chart3.Text = "chart3";
            // 
            // pnlComandos
            // 
            this.pnlComandos.BackColor = System.Drawing.Color.DimGray;
            this.pnlComandos.Controls.Add(this.tableLayoutPanel1);
            this.pnlComandos.Location = new System.Drawing.Point(2, 502);
            this.pnlComandos.Margin = new System.Windows.Forms.Padding(2);
            this.pnlComandos.Name = "pnlComandos";
            this.pnlComandos.Size = new System.Drawing.Size(514, 77);
            this.pnlComandos.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.63158F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.36842F));
            this.tableLayoutPanel1.Controls.Add(this.btnStop, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(514, 77);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.BackColor = System.Drawing.Color.IndianRed;
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnStop.Location = new System.Drawing.Point(2, 2);
            this.btnStop.Margin = new System.Windows.Forms.Padding(2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(138, 73);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "PARAR";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click_1);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btnExportaVazao);
            this.panel3.Controls.Add(this.btnExportaNivel2);
            this.panel3.Controls.Add(this.btnExportaNivel1);
            this.panel3.Controls.Add(this.btnSetpoint);
            this.panel3.Controls.Add(this.txtSetpoint);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(144, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(368, 73);
            this.panel3.TabIndex = 2;
            // 
            // btnExportaVazao
            // 
            this.btnExportaVazao.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportaVazao.Location = new System.Drawing.Point(222, 46);
            this.btnExportaVazao.Name = "btnExportaVazao";
            this.btnExportaVazao.Size = new System.Drawing.Size(139, 20);
            this.btnExportaVazao.TabIndex = 24;
            this.btnExportaVazao.Text = "Vazão to CSV";
            this.btnExportaVazao.UseVisualStyleBackColor = true;
            this.btnExportaVazao.Click += new System.EventHandler(this.btnExportaVazao_Click);
            // 
            // btnExportaNivel2
            // 
            this.btnExportaNivel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportaNivel2.Location = new System.Drawing.Point(222, 25);
            this.btnExportaNivel2.Name = "btnExportaNivel2";
            this.btnExportaNivel2.Size = new System.Drawing.Size(139, 20);
            this.btnExportaNivel2.TabIndex = 23;
            this.btnExportaNivel2.Text = "Nivel T102 to CSV";
            this.btnExportaNivel2.UseVisualStyleBackColor = true;
            this.btnExportaNivel2.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnExportaNivel1
            // 
            this.btnExportaNivel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportaNivel1.Location = new System.Drawing.Point(222, 3);
            this.btnExportaNivel1.Name = "btnExportaNivel1";
            this.btnExportaNivel1.Size = new System.Drawing.Size(139, 20);
            this.btnExportaNivel1.TabIndex = 22;
            this.btnExportaNivel1.Text = "Nivel T101 to CSV";
            this.btnExportaNivel1.UseVisualStyleBackColor = true;
            this.btnExportaNivel1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSetpoint
            // 
            this.btnSetpoint.Location = new System.Drawing.Point(154, 8);
            this.btnSetpoint.Margin = new System.Windows.Forms.Padding(2);
            this.btnSetpoint.Name = "btnSetpoint";
            this.btnSetpoint.Size = new System.Drawing.Size(56, 22);
            this.btnSetpoint.TabIndex = 2;
            this.btnSetpoint.Text = "SET";
            this.btnSetpoint.UseVisualStyleBackColor = true;
            this.btnSetpoint.Click += new System.EventHandler(this.btnSetpoint_Click_1);
            // 
            // txtSetpoint
            // 
            this.txtSetpoint.Location = new System.Drawing.Point(74, 9);
            this.txtSetpoint.Margin = new System.Windows.Forms.Padding(2);
            this.txtSetpoint.Name = "txtSetpoint";
            this.txtSetpoint.Size = new System.Drawing.Size(76, 20);
            this.txtSetpoint.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(26, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Setpoint:";
            // 
            // pnlAlertas
            // 
            this.pnlAlertas.Controls.Add(this.btnALternarModo);
            this.pnlAlertas.Controls.Add(this.grpModo);
            this.pnlAlertas.Controls.Add(this.panel4);
            this.pnlAlertas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAlertas.Location = new System.Drawing.Point(2, 583);
            this.pnlAlertas.Margin = new System.Windows.Forms.Padding(2);
            this.pnlAlertas.Name = "pnlAlertas";
            this.pnlAlertas.Size = new System.Drawing.Size(514, 77);
            this.pnlAlertas.TabIndex = 4;
            // 
            // btnALternarModo
            // 
            this.btnALternarModo.Location = new System.Drawing.Point(258, 10);
            this.btnALternarModo.Name = "btnALternarModo";
            this.btnALternarModo.Size = new System.Drawing.Size(67, 39);
            this.btnALternarModo.TabIndex = 13;
            this.btnALternarModo.Text = "Alternar Modo";
            this.btnALternarModo.UseVisualStyleBackColor = true;
            this.btnALternarModo.Click += new System.EventHandler(this.btnALternarModo_Click);
            // 
            // grpModo
            // 
            this.grpModo.Controls.Add(this.rdManual);
            this.grpModo.Controls.Add(this.rdAuto);
            this.grpModo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grpModo.Location = new System.Drawing.Point(13, 6);
            this.grpModo.Name = "grpModo";
            this.grpModo.Size = new System.Drawing.Size(239, 52);
            this.grpModo.TabIndex = 12;
            this.grpModo.TabStop = false;
            this.grpModo.Text = "Modo";
            // 
            // rdManual
            // 
            this.rdManual.AutoSize = true;
            this.rdManual.Location = new System.Drawing.Point(162, 19);
            this.rdManual.Name = "rdManual";
            this.rdManual.Size = new System.Drawing.Size(60, 17);
            this.rdManual.TabIndex = 1;
            this.rdManual.TabStop = true;
            this.rdManual.Text = "Manual";
            this.rdManual.UseVisualStyleBackColor = true;
            // 
            // rdAuto
            // 
            this.rdAuto.AutoSize = true;
            this.rdAuto.Location = new System.Drawing.Point(32, 19);
            this.rdAuto.Name = "rdAuto";
            this.rdAuto.Size = new System.Drawing.Size(78, 17);
            this.rdAuto.TabIndex = 0;
            this.rdAuto.TabStop = true;
            this.rdAuto.Text = "Automático";
            this.rdAuto.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.btnConexaoSerial);
            this.panel4.Controls.Add(this.lblConexao);
            this.panel4.Location = new System.Drawing.Point(397, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(109, 47);
            this.panel4.TabIndex = 11;
            // 
            // btnConexaoSerial
            // 
            this.btnConexaoSerial.Location = new System.Drawing.Point(2, 2);
            this.btnConexaoSerial.Margin = new System.Windows.Forms.Padding(2);
            this.btnConexaoSerial.Name = "btnConexaoSerial";
            this.btnConexaoSerial.Size = new System.Drawing.Size(100, 20);
            this.btnConexaoSerial.TabIndex = 10;
            this.btnConexaoSerial.Text = "Conectar Serial";
            this.btnConexaoSerial.UseVisualStyleBackColor = true;
            this.btnConexaoSerial.Click += new System.EventHandler(this.btnConexaoSerial_Click);
            // 
            // lblConexao
            // 
            this.lblConexao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConexao.AutoSize = true;
            this.lblConexao.BackColor = System.Drawing.Color.LightGray;
            this.lblConexao.Location = new System.Drawing.Point(6, 24);
            this.lblConexao.Name = "lblConexao";
            this.lblConexao.Size = new System.Drawing.Size(96, 13);
            this.lblConexao.TabIndex = 8;
            this.lblConexao.Text = "DESCONECTADO";
            // 
            // serialPort1
            // 
            this.serialPort1.ErrorReceived += new System.IO.Ports.SerialErrorReceivedEventHandler(this.serialPort1_ErrorReceived);
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1284, 708);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.Text = "Supervisorio - Area 100 - TK 102";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tlpMain.ResumeLayout(false);
            this.pnlPlanta.ResumeLayout(false);
            this.pnlPlanta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRiscoTK101)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmergencia)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLAH101)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.pnlSetPoint.ResumeLayout(false);
            this.pnlSetPoint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSP)).EndInit();
            this.pnlLAL101.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLAL101)).EndInit();
            this.pnlLAL102.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLAL102)).EndInit();
            this.pnlLAH102.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLAH102)).EndInit();
            this.tlpControles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.pnlComandos.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlAlertas.ResumeLayout(false);
            this.grpModo.ResumeLayout(false);
            this.grpModo.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Panel pnlPlanta;
        private System.Windows.Forms.TableLayoutPanel tlpControles;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Panel pnlComandos;
        private System.Windows.Forms.Panel pnlAlertas;
        private System.Windows.Forms.Label lblNivelTanque1;
        private System.Windows.Forms.Label lblNivelTanque2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label lblConexao;
        private Controles.bomba bomba1;
        private Controles.vavula vavula1;
        private Controles.tanque tanque1;
        private Controles.tanque tanque2;
        private System.Windows.Forms.Panel pnlDepoisValvula;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel pnlAntesValvula;
        private Controles.tanque tq102;
        private Controles.tanque tq101;
        private Controles.bomba p102;
        private Controles.vavula lv102;
        private System.Windows.Forms.Panel pnlEntradaVavula;
        private System.Windows.Forms.Panel pnlSaidaValvula;
        private System.Windows.Forms.Panel pnlEntradaP102;
        private System.Windows.Forms.Panel pnlSaidaP102_2;
        private System.Windows.Forms.Panel pnlSaidaP102_1;
        private System.Windows.Forms.Panel pnlSaidaP102_0;
        private System.Windows.Forms.Label lblSetpoint;
        private System.Windows.Forms.Button btnConexaoSerial;
        private System.Windows.Forms.Panel pnlLAH102;
        private System.Windows.Forms.PictureBox picLAH102;
        private System.Windows.Forms.Label lblLAH102;
        private System.Windows.Forms.Panel pnlLAL101;
        private System.Windows.Forms.Label lblLAL101;
        private System.Windows.Forms.PictureBox picLAL101;
        private System.Windows.Forms.Panel pnlLAL102;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picLAL102;
        private System.Windows.Forms.Panel pnlSetPoint;
        private System.Windows.Forms.PictureBox picSP;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSetpoint;
        private System.Windows.Forms.TextBox txtSetpoint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lblBarraStatus;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox grpModo;
        private System.Windows.Forms.RadioButton rdAuto;
        private System.Windows.Forms.RadioButton rdManual;
        private System.Windows.Forms.Button btnALternarModo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private Controles.bomba p101;
        private System.Windows.Forms.Panel pnlSaidaValvula0;
        private System.Windows.Forms.Panel pnlEntradaP101;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblLAH101;
        private System.Windows.Forms.PictureBox picLAH101;
        private System.Windows.Forms.Label lblVazao;
        private Controles.vavula fv102;
        private System.Windows.Forms.Panel pnlEntradaFV101;
        private System.Windows.Forms.Panel pnlSaidaFV101;
        private System.Windows.Forms.Panel pnlSaidaValvula1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTensaoP102;
        private System.Windows.Forms.Label lblTensaoP101;
        private System.Windows.Forms.Button btnExportaNivel1;
        private System.Windows.Forms.Button btnExportaVazao;
        private System.Windows.Forms.Button btnExportaNivel2;
        private System.Windows.Forms.Label lblEmergencia;
        private System.Windows.Forms.PictureBox picEmergencia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picRiscoTK101;
        private System.Windows.Forms.Label lblRiscoTK101;
        private System.Windows.Forms.Label label6;
    }
}

