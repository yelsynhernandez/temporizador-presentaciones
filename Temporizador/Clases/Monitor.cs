using System;
using System.Windows.Forms;

namespace Temporizador.Clases
{
    internal class Monitor
    {   
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
                string pantalla = @"\\.\DISPLAY" + idMonitor;
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

        
    }
}
