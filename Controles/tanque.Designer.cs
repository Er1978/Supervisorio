namespace Supervisorio.Controles
{
    partial class tanque
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.picTanque = new System.Windows.Forms.PictureBox();
            this.pnlNivel = new System.Windows.Forms.Panel();
            this.pnlReservatorio = new System.Windows.Forms.Panel();
            this.lblNivel = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picTanque)).BeginInit();
            this.pnlReservatorio.SuspendLayout();
            this.SuspendLayout();
            // 
            // picTanque
            // 
            this.picTanque.BackColor = System.Drawing.Color.Transparent;
            this.picTanque.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picTanque.Image = global::Supervisorio.Properties.Resources.tanque1;
            this.picTanque.Location = new System.Drawing.Point(0, 0);
            this.picTanque.Name = "picTanque";
            this.picTanque.Size = new System.Drawing.Size(142, 350);
            this.picTanque.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTanque.TabIndex = 0;
            this.picTanque.TabStop = false;
            // 
            // pnlNivel
            // 
            this.pnlNivel.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlNivel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlNivel.Location = new System.Drawing.Point(0, 209);
            this.pnlNivel.Name = "pnlNivel";
            this.pnlNivel.Size = new System.Drawing.Size(130, 26);
            this.pnlNivel.TabIndex = 1;
            // 
            // pnlReservatorio
            // 
            this.pnlReservatorio.BackColor = System.Drawing.Color.LightGray;
            this.pnlReservatorio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlReservatorio.Controls.Add(this.lblNivel);
            this.pnlReservatorio.Controls.Add(this.pnlNivel);
            this.pnlReservatorio.Location = new System.Drawing.Point(3, 32);
            this.pnlReservatorio.Name = "pnlReservatorio";
            this.pnlReservatorio.Size = new System.Drawing.Size(134, 239);
            this.pnlReservatorio.TabIndex = 2;
            // 
            // lblNivel
            // 
            this.lblNivel.BackColor = System.Drawing.Color.Transparent;
            this.lblNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNivel.Location = new System.Drawing.Point(33, 105);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(60, 15);
            this.lblNivel.TabIndex = 2;
            this.lblNivel.Text = "0";
            this.lblNivel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNome
            // 
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(28, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(81, 20);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "TK";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tanque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.pnlReservatorio);
            this.Controls.Add(this.picTanque);
            this.Name = "tanque";
            this.Size = new System.Drawing.Size(142, 350);
            ((System.ComponentModel.ISupportInitialize)(this.picTanque)).EndInit();
            this.pnlReservatorio.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picTanque;
        private System.Windows.Forms.Panel pnlNivel;
        private System.Windows.Forms.Panel pnlReservatorio;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblNivel;
    }
}
