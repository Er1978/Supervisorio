namespace Supervisorio.Controles
{
    partial class vavula
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
            this.picValvula = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picValvula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picValvula
            // 
            this.picValvula.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picValvula.Image = global::Supervisorio.Properties.Resources.valvula_vermelha;
            this.picValvula.Location = new System.Drawing.Point(0, 0);
            this.picValvula.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picValvula.Name = "picValvula";
            this.picValvula.Size = new System.Drawing.Size(200, 185);
            this.picValvula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picValvula.TabIndex = 1;
            this.picValvula.TabStop = false;
            this.picValvula.Click += new System.EventHandler(this.picValvula_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 62);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // vavula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picValvula);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "vavula";
            this.Size = new System.Drawing.Size(200, 185);
            ((System.ComponentModel.ISupportInitialize)(this.picValvula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picValvula;
    }
}
