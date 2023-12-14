using System;
using System.Windows.Forms;
using Temporizador.Clases;

namespace Temporizador
{
    public partial class FrmPrincipal : Form
    {
        private bool contadorIniciado = false;
        private bool temporizadorCargado = false;
        private bool _pausa = false;
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
            BotonPausa(false);
            IniciarControles();
        }

        private void BtnIdentificar_Click(object sender, EventArgs e)
        {
            monitor.IdentificarMonitor(cbMonitores.SelectedIndex + 1);
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                bool continuar = true;
                if (temporizadorCargado && !contadorIniciado)
                {
                    acciones.IniciarTemporizador();
                    HabilitarPausa(true);
                    contadorIniciado = true;
                    continuar = false;
                }

                if (continuar && contadorIniciado)
                {
                    if (acciones.TiempoRestante())
                    {
                        DialogResult result = MessageBox.Show("Ya existe un temporizador ejecutándose\n¿Desea reiniciarlo?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            if (!_pausa)
                            {
                                acciones.DetenerTemporizador();
                            }
                            BotonPausa(false);
                            AsignarTiempo();
                            acciones.ActualizarTiempo(tiempo);
                            acciones.IniciarTemporizador();
                            contadorIniciado = true;
                        }
                    }
                    else
                    {
                        BotonPausa(false);
                        AsignarTiempo();
                        acciones.ActualizarTiempo(tiempo);
                        acciones.IniciarTemporizador();
                        contadorIniciado = true;
                    }
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (!_pausa)
            {
                acciones.DetenerTemporizador();
                BotonPausa(true);
            }
            else
            {
                acciones.IniciarTemporizador();
                BotonPausa(false);
            }
        }

        private void BtnInformacion_Click(object sender, EventArgs e)
        {
            string mensaje = "Autor: YH\n";
            mensaje += "Versión 1.3\n";
            mensaje += "https://github.com/yelsynhernandez/temporizador-presentaciones.git";

            MessageBox.Show(mensaje, "Créditos", MessageBoxButtons.OK, MessageBoxIcon.Question);
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
                acciones.CargarTemporizador(cbMonitores.SelectedIndex + 1, tiempo, lblTiempo);
                cbIniciar.Visible = false;
                temporizadorCargado = true;
                HabilitarInicio(true);

                if (cbIniciar.Checked)
                {
                    acciones.IniciarTemporizador();
                    contadorIniciado = true;
                    HabilitarPausa(true);
                    BotonPausa(false);
                }
                else
                {
                    contadorIniciado = false;
                    HabilitarPausa(false);
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
            cbIniciar.Enabled = true;
            lblTiempo.Text = "00:00:00";
            IniciarControles();
        }

        private void BotonPausa(bool detener)
        {
            if (detener)
            {
                _pausa = true;
                btnPausa.Image = Properties.Resources.seguir;
                lblTiempo.Text += "(En pausa)";
                btnPausa.BackColor = System.Drawing.Color.LightGreen;
            }
            else
            {
                _pausa = false;
                btnPausa.Image = Properties.Resources.pausa;
                btnPausa.BackColor = System.Drawing.Color.LightSalmon;
            }
        }

        private void HabilitarInicio(bool habilitar)
        {
            btnIniciar.Enabled = habilitar;
            if (habilitar)
            {
                btnIniciar.BackColor = System.Drawing.Color.LightGreen;
            }
            else
            {
                btnIniciar.BackColor = System.Drawing.Color.Gray;
            }
        }

        private void HabilitarPausa(bool habilitar)
        {
            btnPausa.Enabled = habilitar;
            if (habilitar)
            {
                btnPausa.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                btnPausa.BackColor = System.Drawing.Color.Gray;
            }
        }

        private void IniciarControles()
        {
            cbIniciar.Checked = true;
            btnPausa.Enabled = false;
            btnIniciar.Enabled = false;
            HabilitarInicio(false);
            HabilitarPausa(false);
            btnInformación.Image = Properties.Resources.info;
            btnIdentificar.Image = Properties.Resources.check;
            btnCargar.Image = Properties.Resources.cargar;
            btnIniciar.Image = Properties.Resources.play;
            btnPausa.Image = Properties.Resources.pausa;
            btnRecargar.Image = Properties.Resources.recargar;
            btnOcultar.Image = Properties.Resources.ocultar;
            btnSalir.Image = Properties.Resources.salir;
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            monitor.CargarMonitores(cbMonitores);
            MessageBox.Show("Se ha actualizado la lista de monitores", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
