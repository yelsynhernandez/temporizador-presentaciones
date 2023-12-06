using System;
using System.Windows.Forms;
using Temporizador.Clases;

namespace Temporizador
{
    public partial class FrmPrincipal : Form
    {
        Monitor monitor = new Monitor();
        Acciones a = new Acciones();
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            monitor.CargarMonitores(cbMonitores);
        }

        private void btnIdentificar_Click(object sender, EventArgs e)
        {
            monitor.IdentificarMonitor(cbMonitores.SelectedIndex + 1);
        }

        private void btnContador_Click(object sender, EventArgs e)
        {
            bool continuar = true;
            string mensaje = String.Empty;
            int[] tiempo = new int[3];
            tiempo[0] = Convert.ToInt32(nudHoras.Value);
            tiempo[1] = Convert.ToInt32(nudMinutos.Value);
            tiempo[2] = Convert.ToInt32(nudSegundos.Value);

            if (tiempo[0] > 23)
            {
                mensaje = "No se pueden programar más de 23 horas de temporizador.\n" ;
                continuar = false;
            }

            if (tiempo[1] > 59)
            {
                mensaje = "No se pueden programar más de 23 horas de temporizador\n";
                continuar = false;
            }

            if( tiempo[2] > 59)
            {
                mensaje = "No se pueden programar más de 23 horas de temporizador\n";
                continuar = false;
            }

            if (tiempo[0] == 0 && tiempo[1] == 0 && tiempo[2] == 0)
            {
                mensaje = "Debe establecerse el tiempo para iniciar el temporizador";
                continuar = false;
            }

            if (!String.IsNullOrEmpty(mensaje))
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (continuar)
            {
                monitor.CargarTemporizador(cbMonitores.SelectedIndex + 1, tiempo);
            }
        }

        private void validarDecimal(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.Handled = true;
            }
        }

        private void nudHoras_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarDecimal(sender, e);
        }

        private void nudMinutos_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarDecimal(sender, e);
        }

        private void nudSegundos_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarDecimal(sender, e);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (!a.CerrarFormulario(typeof(FrmContador))){
                MessageBox.Show("No se ha iniciado un contador");
            }
        }
    }
}
