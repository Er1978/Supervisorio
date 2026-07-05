using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supervisorio.Controles
{
    public partial class tanque : UserControl
    {   
        int _nivel;
        double _percentual;
        double _volume;
        double _diametro;
        double _altura;
        

        public event EventHandler NivelChanged;
        public int Nivel
        {
            get { return _nivel; }
            set
            {
                _nivel = value;
                _percentual = (double)_nivel / 100;
                int alturaMaxima = pnlReservatorio.Height;
                float alturaNivel = (float)(_percentual * alturaMaxima);
                float h= (float)(_percentual * 14);
               
                _volume = Math.PI * Math.Pow(_diametro / 2, 2) * (_altura * _percentual/1000);
                lblNivel.Text = $"{_nivel}%";


                pnlNivel.Height = (int)alturaNivel;

                NivelChanged?.Invoke(this, EventArgs.Empty);

            }
            
        }

        public string NomeTanque
        {
            get { return lblNome.Text; }
            set { lblNome.Text = value; }
        }


        public double Volume
        {
            get { return _volume; }
           
        }

        public double Diametro
        {
            get { return _diametro; }
            set
            {
                _diametro = value;
                // Recalcular o volume com o novo diâmetro
                _volume = Math.PI * Math.Pow(_diametro / 2, 2) * (_altura * _percentual/1000);
            }
        }


        public double Altura
        {
            get { return _altura; }
            set
            {
                _altura = value;
                // Recalcular o volume com a nova altura
                _volume = Math.PI * Math.Pow(_diametro / 2, 2) * (_altura * _percentual/1000);
            }
        }

       

        public tanque()
        {
            InitializeComponent();
        }
    }
}
