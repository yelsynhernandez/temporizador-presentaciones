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
        public FrmContador(int _horas, int _minutos, int _segundos)
        {
            InitializeComponent();
            horas = _horas;
            minutos = _minutos;
            segundos = _segundos;
        }

        public void iniciarContador()
        {
            try
            {
                int contador = (horas * 3600) + (minutos * 60) + segundos;
                string hh;
                string mm;
                string ss;
                bool contar = true;

                Timer timer = new Timer();
                timer.Interval = 900;
                timer.Tick += (sender, e) =>
                {
                    hh = (horas < 10 ? "0" + horas : horas.ToString());
                    mm = (minutos < 10 ? "0" + minutos : minutos.ToString());
                    ss = (segundos < 10 ? "0" + segundos : segundos.ToString());

                    lblContador.Text = $"{hh}:{mm}:{ss}";

                    if(minutos == 0 && horas > 0)
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmContador_Load(object sender, EventArgs e)
        {
            iniciarContador();
        }
    }
}
