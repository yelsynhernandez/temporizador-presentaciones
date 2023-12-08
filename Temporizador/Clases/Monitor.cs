using System;
using System.Windows.Forms;

namespace Temporizador.Clases
{
    internal class Monitor
    {
        private static string monitor = @"\\.\DISPLAY";
        private FrmContador frmContador;
        public void CargarMonitores(ComboBox cb)
        {
            try
            {
                int id = 1;
                Screen[] screens = Screen.AllScreens;
                foreach (Screen screen in screens)
                {
                    cb.Items.Add($"Monitor {id}");
                    id++;
                }

                if(cb.Items.Count > 0)
                {
                    cb.SelectedIndex = 0;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Ha ocurrido un error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        public void IdentificarMonitor(int idMonitor)
        {
            try
            {
                string pantalla = monitor + idMonitor;
                foreach (Screen screen in Screen.AllScreens)
                {
                    if (screen.DeviceName == pantalla)
                    {
                        FrmVentanaIdentificacion frmVentanaIdentificacion = new FrmVentanaIdentificacion(idMonitor);
                        frmVentanaIdentificacion.StartPosition = FormStartPosition.Manual;
                        frmVentanaIdentificacion.Location = screen.Bounds.Location;

                        frmVentanaIdentificacion.Show();

                        Timer timer = new Timer();
                        timer.Interval = 5000;
                        timer.Tick += (sender, e) =>
                        {
                            frmVentanaIdentificacion.Close();
                            timer.Stop();
                        };
                        timer.Start();

                        break;
                    }
                }
            }
            catch( Exception ex )
            {
                MessageBox.Show(ex.Message, "Ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CargarTemporizador(int idMonitor, int[] tiempo, Label lbl)
        {
            try
            {
                string pantalla = monitor + idMonitor;
                foreach (Screen screen in Screen.AllScreens)
                {
                    if (screen.DeviceName == pantalla)
                    {
                        //FrmContador frmContador = new FrmContador(tiempo);
                        frmContador = new FrmContador(tiempo);
                        frmContador.StartPosition = FormStartPosition.Manual;
                        frmContador.Location = screen.Bounds.Location;
                        frmContador.Show();
                        frmContador.iniciarContador(lbl);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void CancelarTemporizador(Type formType)
        {
            if(frmContador != null)
            {
                frmContador.Close();
                frmContador = null;
            }
            //foreach (Form form in Application.OpenForms)
            //{
            //    if (form.GetType() == formType)
            //    {
            //        form.Close();
            //        return true;
            //    }
            //}
            //return false;
        }
    }
}
