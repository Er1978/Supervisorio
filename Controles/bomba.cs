using System;
using System.Windows.Forms;

namespace Supervisorio.Controles
{
    public partial class bomba : UserControl
    {
        bool _ligado;
        double _tensao;
        double _tensaoMin;
        double _tensaoMax;
        private Timer _timerAnimacao;
        private int intervalo=800;

        public event EventHandler LigadoChanged;
     
        public bool Ligado
        {
            get { return _ligado; }
            set
            {
                _ligado = value;

                LigadoChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public double Tensao
        {
            get { return _tensao; }
            set
            {
                _tensao    = value;
                intervalo = ConverteIntervalo(_tensao, _tensaoMin, _tensaoMax);
                _timerAnimacao.Interval = intervalo;
            }
        }

        public double TensaoMinima
        { get { return _tensaoMin; } set { _tensaoMin = value; } } 

        public double TensaoMaxima
        { get { return _tensaoMax; } set { _tensaoMax = value; } } 

        public bomba()
        {
            InitializeComponent();
            IniciarAnimacao(intervalo);
        }


        private void IniciarAnimacao(int intervalo)
        {
           
            
            _timerAnimacao = new Timer();
            _timerAnimacao.Interval = intervalo; // Tempo em milissegundos para alternar a imagem
            _timerAnimacao.Tick += TimerAnimacao_Tick;
            _timerAnimacao.Start();
        }

        private bool _frameAlternado = false;
        private void TimerAnimacao_Tick(object sender, EventArgs e)
        {
            if (_ligado)
            {
                // Alterna entre a imagem A e B usando o booleano de controle
                if (_frameAlternado)
                {
                    picBomba.Image = Properties.Resources.bomba_vd_b;
                }
                else
                {
                    picBomba.Image = Properties.Resources.bomba_vd_a;
                }

                // Inverte o estado para o próximo tick do timer
                _frameAlternado = !_frameAlternado;
            }
            else
            {
                picBomba.Image = Properties.Resources.bomba_vm_a;
                _frameAlternado = false; // Reseta o estado quando desligado
            }

           

        }


        int ConverteIntervalo(double tensao, double minima, double maxima)
        {
            //150, 200,250,300,350,400,450,500

            // Define o passo com base na faixa de tensão
            int passo = maxima > minima ? (int)((tensao-minima)/(maxima - minima) * 8) : 1; 
            

            if (tensao < 1)
                return 900;
            else if (tensao <= 2)
                return 800;
            else if (tensao <= 3)
                return 600;
            else if (tensao <= 4)
                return 350;
            else if (tensao <= 5)
                return 200;
            else if (tensao <= 6)
                return 100;
            else if (tensao <= 7)
                return 75;
            else 
                return 40;
            
        }


        private void picBomba_Click(object sender, EventArgs e)
        {
           this.OnClick(e); // Propaga o evento de clique para o controle pai
        }
    }
}