using System.Windows.Forms;
using System;

namespace Temporizador.Clases
{
    internal class Acciones
    {
        private FrmContador frmContador;
        public void CargarTemporizador(int idMonitor, int[] tiempo, Label lbl)
        {
            try
            {
                string pantalla = @"\\.\DISPLAY" + idMonitor;
                foreach (Screen screen in Screen.AllScreens)
                {
                    if (screen.DeviceName == pantalla)
                    {
                        frmContador = new FrmContador(tiempo, lbl)
                        {
                            StartPosition = FormStartPosition.Manual,
                            Location = screen.Bounds.Location
                        };
                        frmContador.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void IniciarTemporizador()
        {
            frmContador.IniciarTemporizador();
        }

        public void CerrarTemporizador()
        {
            if (frmContador != null)
            {
                frmContador.Close();
                frmContador = null;
            }
        }

        public void DetenerTemporizador()
        {
            frmContador.DetenerTemporizador();
        }

        public void ActualizarTiempo(int[] tiempo)
        {
            frmContador.ActualizarTiempo(tiempo);
        }

        public bool TiempoRestante()
        {
            return frmContador.TiempoRestante();
        }
    }
}
