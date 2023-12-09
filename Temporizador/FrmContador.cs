using System;
using System.Drawing;
using System.Windows.Forms;

namespace Temporizador
{
    public partial class FrmContador : Form
    {
        private int horas { get; set; }
        private int minutos { get; set; }
        private int segundos { get; set; }
        private Timer timer;
        private Label lbl;
        private int contador;
        public FrmContador(int[] tiempo, Label _lbl)
        {
            InitializeComponent();
            horas = tiempo[0];
            minutos = tiempo[1];
            segundos = tiempo[2];
            lbl = _lbl;
        }

        public void ActualizarTiempo(int[] tiempo)
        {
            horas = tiempo[0];
            minutos = tiempo[1];
            segundos = tiempo[2];
        }

        private void FrmContador_FormClosing(object sender, FormClosingEventArgs e)
        {

            DetenerTemporizador();
        }

        private void FrmContador_Load(object sender, EventArgs e)
        {
            lblContador.Text = Tiempo(horas,minutos,segundos);
        }

        public string Tiempo(int horas, int minutos, int segundos)
        {
            string hh;
            string mm;
            string ss;

            hh = horas < 10 ? "0" + horas : horas.ToString();
            mm = minutos < 10 ? "0" + minutos : minutos.ToString();
            ss = segundos < 10 ? "0" + segundos : segundos.ToString();

            return $"{hh}:{mm}:{ss}";
        }

        public void IniciarContador()
        {
            try
            { 
                lbl.Text = Tiempo(horas, minutos, segundos);
                contador = (horas * 3600) + (minutos * 60) + segundos;

                string tiempo;
                bool contar = true;

                timer = new Timer();
                timer.Interval = 970;
                timer.Tick += (sender, e) =>
                {
                    tiempo = Tiempo(horas, minutos, segundos);
                    lblContador.Text = tiempo;
                    lbl.Text = tiempo;

                    if (minutos == 0 && horas > 0)
                    {
                        horas--;
                        minutos = 59;
                        contar = false;
                    }

                    if (segundos == 0 && minutos > 0 && contar)
                    {
                        minutos--;
                        segundos = 59;
                        contar = false;
                    }

                    if (contar)
                    {
                        segundos--;
                        if (segundos == 0)
                        {
                            if (minutos > 0)
                            {
                                minutos--;
                                segundos = 59;
                            }

                            if (minutos == 0)
                            {

                                if (horas > 0)
                                {
                                    minutos = 59;
                                    horas--;
                                }
                            }
                        }
                    }
                    contador--; 

                    if (contador < 0)
                    {
                        timer.Stop();
                    }
                    
                    contar = true;
                };
                timer.Start();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DetenerTemporizador()
        {
            if (timer != null)
            {
                timer.Stop();
                timer.Dispose();
                timer = null;
            }
        }

        public int TiempoRestante()
        {
            return contador;
        }
    }
}
