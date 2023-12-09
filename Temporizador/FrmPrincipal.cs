using System;
using System.Windows.Forms;
using Temporizador.Clases;

namespace Temporizador
{
    public partial class FrmPrincipal : Form
    {
        private bool contadorIniciado = false;
        private bool temporizadorCargado = false;
        private bool pausa = false;
        private int[] tiempo = new int[3];
        Monitor monitor = new Monitor();
        Acciones acciones = new Acciones();

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            monitor.CargarMonitores(cbMonitores);
            if (!pausa)
            {
                btnPausar.Text = "Pausa";
            }
            btnIniciar.Enabled = false;
            btnPausar.Enabled = false;
        }

        private void BtnIdentificar_Click(object sender, EventArgs e)
        {
            monitor.IdentificarMonitor(cbMonitores.SelectedIndex + 1);
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            bool continuar = true;
            if (temporizadorCargado && !contadorIniciado)
            {
                acciones.IniciarTemporizador();
                btnPausar.Enabled = true;
                contadorIniciado = true;
                continuar = false;
            }

            if (continuar && contadorIniciado)
            {
                if(acciones.TiempoRestante() > 0)
                {
                    DialogResult result = MessageBox.Show("Ya existe un temporizador ejecutándose\n¿Desea reiniciarlo?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (!pausa)
                        {
                            acciones.DetenerTemporizador();
                        }
                        pausa = false;
                        btnPausar.Text = "Pausar";
                        AsignarTiempo();
                        acciones.ActualizarTiempo(tiempo);
                        acciones.IniciarTemporizador();
                        contadorIniciado = true;
                    }
                }
                else
                {
                    pausa = false;
                    btnPausar.Text = "Pausar";
                    AsignarTiempo();
                    acciones.ActualizarTiempo(tiempo);
                    acciones.IniciarTemporizador();
                    contadorIniciado = true;
                }
                
            }
        }

        

        private void NudHoras_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDecimal(sender, e);
        }

        private void NudMinutos_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDecimal(sender, e);
        }

        private void NudSegundos_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDecimal(sender, e);
        }

        private void BtnPausar_Click(object sender, EventArgs e)
        {
            if (!pausa)
            {
                acciones.DetenerTemporizador();
                pausa = true;
                btnPausar.Text = "Reanudar";
            }
            else
            {
                acciones.IniciarTemporizador();
                pausa = false;
                btnPausar.Text = "Pausar";
            }
        }

        private void BtnInformacion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Autor: YH\nVersión 1.0");
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            bool continuar = true;
            string mensaje = String.Empty;
            AsignarTiempo();

            if (tiempo[0] > 23)
            {
                mensaje = "No se pueden asignar más de 23 horas al temporizador.\n";
            }

            if (tiempo[1] > 59)
            {
                mensaje = "No se puede asignar más de 59 minutos al temporizador\n";
            }

            if (tiempo[2] > 59)
            {
                mensaje = "No se puede asiganr más de 59 segundos al temporizador\n";
            }

            if (tiempo[0] == 0 && tiempo[1] == 0 && tiempo[2] == 0)
            {
                mensaje = "Debe establecerse el tiempo para iniciar el temporizador";
            }

            if (temporizadorCargado)
            {
                mensaje = "Ya se ha cargado la ventana del temporizador\n";
            }

            if (!String.IsNullOrEmpty(mensaje))
            {
                MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                continuar = false;
            }

            if (continuar)
            {
                string hh;
                string mm;
                string ss;

                hh = tiempo[0] < 10 ? "0" + tiempo[0] : tiempo[0].ToString();
                mm = tiempo[1] < 10 ? "0" + tiempo[1] : tiempo[1].ToString();
                ss = tiempo[2] < 10 ? "0" + tiempo[2] : tiempo[2].ToString();

                lblTiempo.Text = $"{hh}:{mm}:{ss}";

                acciones.CargarTemporizador(cbMonitores.SelectedIndex + 1, tiempo,lblTiempo);
                cbIniciar.Visible = false;

                temporizadorCargado = true;
                btnIniciar.Enabled = true;

                if (cbIniciar.Checked)
                {
                    acciones.IniciarTemporizador();
                    contadorIniciado = true;
                    btnPausar.Enabled = true;
                    contadorIniciado = true;
                    btnIniciar.Text = "Reiniciar";
                    btnPausar.Text = "Pausar";
                }
                else
                {
                    contadorIniciado = false;
                    btnIniciar.Text = "Iniciar";
                    btnPausar.Text = "Pausar";
                }
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOcultar_Click(object sender, EventArgs e)
        {
            if (temporizadorCargado)
            {
                if(contadorIniciado)
                {
                    DialogResult result = MessageBox.Show("Hay un temporizador ejecutándose.\n¿Desea continuar?","Aviso", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        CerrarTemporizador();
                    }
                }
                else
                {
                    CerrarTemporizador();
                }
            }
            else
            {
                MessageBox.Show("No se ha cargado un temporizador", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AsignarTiempo()
        {
            tiempo[0] = Convert.ToInt32(nudHoras.Value);
            tiempo[1] = Convert.ToInt32(nudMinutos.Value);
            tiempo[2] = Convert.ToInt32(nudSegundos.Value);
        }

        private void ValidarDecimal(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.Handled = true;
            }
        }

        private void CerrarTemporizador()
        {
            acciones.CerrarTemporizador();
            temporizadorCargado = false;

            lblTiempo.Text = $"00:00:00";
            btnIniciar.Text = "Iniciar";

            btnIniciar.Enabled = false;
            btnPausar.Enabled = false;
            cbIniciar.Visible = true;
        }
    }
}
