using System.Windows.Forms;
using System;
namespace Supervisorio.Controles
{





    public partial class vavula : UserControl
    {

        bool _ligado;

       public event EventHandler LigadoChanged;

        public bool Ligado
        {
            get { return _ligado; }
            set
            {
                _ligado = value;
                if (_ligado)
                {
                    picValvula.Image = Properties.Resources.valvula_azul;
                }
                else
                {
                    picValvula.Image = Properties.Resources.valvula_vermelha;
                }

                LigadoChanged?.Invoke(this, EventArgs.Empty);

            }
        }



        public vavula()
        {
            InitializeComponent();
        }

        private void picValvula_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
    }
}
