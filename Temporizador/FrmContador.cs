using System;
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
        public FrmContador(int[] tiempo, Label _lbl)
        {
            InitializeComponent();
            horas = tiempo[0];
            minutos = tiempo[1];
            segundos = tiempo[2];
            lbl = _lbl;
        }

        public void ActualizarTiempo(int[] _tiempo)
        {
            horas = _tiempo[0];
            minutos = _tiempo[1];
            segundos = _tiempo[2];
        }

        private void FrmContador_FormClosing(object sender, FormClosingEventArgs e)
        {
            DetenerTemporizador();
        }

        private void FrmContador_Load(object sender, EventArgs e)
        {
            FormatoTiempo();
        }

        public void FormatoTiempo()
        {
            string hh;
            string mm;
            string ss;
            string tiempo;

            hh = horas < 10 ? "0" + horas : horas.ToString();
            mm = minutos < 10 ? "0" + minutos : minutos.ToString();
            ss = segundos < 10 ? "0" + segundos : segundos.ToString();

            tiempo = $"{hh}:{mm}:{ss}";

            lbl.Text = tiempo;
            lblContador.Text = tiempo;
        }

        public void IniciarTemporizador()
        {
            try
            {
                DetenerTemporizador();
                timer = new Timer
                {
                    Interval = 995
                };

                timer.Tick += (sender, e) =>
                {
                    FormatoTiempo();
                    if (segundos == 0)
                    {
                        if (minutos > 0)
                        {
                            minutos--;
                            segundos = 60;
                        }
                        else
                        {
                            if (horas > 0)
                            {
                                horas--;
                                minutos = 59;
                                segundos = 60;
                            }
                        }
                    }

                    segundos--;

                    if (segundos < 0 && minutos == 0 && horas == 0)
                    {
                        timer.Stop();
                    }
                };
                timer.Start();
            }
            catch(Exception ex) 
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public bool TiempoRestante()
        {
            return (segundos > 0 || minutos > 0 || horas > 0);
        }

    }
}
