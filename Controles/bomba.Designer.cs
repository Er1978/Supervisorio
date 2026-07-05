namespace Supervisorio.Controles
{
    partial class bomba
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
            this.picBomba = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBomba)).BeginInit();
            this.SuspendLayout();
            // 
            // picBomba
            // 
            this.picBomba.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBomba.Image = global::Supervisorio.Properties.Resources.bomba_vm_a;
            this.picBomba.Location = new System.Drawing.Point(0, 0);
            this.picBomba.Name = "picBomba";
            this.picBomba.Size = new System.Drawing.Size(100, 100);
            this.picBomba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBomba.TabIndex = 0;
            this.picBomba.TabStop = false;
            this.picBomba.Click += new System.EventHandler(this.picBomba_Click);
            // 
            // bomba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picBomba);
            this.Name = "bomba";
            this.Size = new System.Drawing.Size(100, 100);
            ((System.ComponentModel.ISupportInitialize)(this.picBomba)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBomba;
    }
}
