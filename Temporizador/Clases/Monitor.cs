using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temporizador.Clases
{
    internal class Monitor
    {
        private static string monitor = @"\\.\DISPLAY";
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

        public void CargarTemporizador(int idMonitor, int[] tiempo)
        {
            string pantalla = monitor + idMonitor;
            foreach(Screen screen in Screen.AllScreens)
            {   
                if (screen.DeviceName == pantalla)
                {
                    FrmContador frmContador = new FrmContador(tiempo[0], tiempo[1], tiempo[2]);
                    frmContador.StartPosition = FormStartPosition.Manual;
                    frmContador.Location = screen.Bounds.Location;
                    frmContador.Show();
                }
            }
        }
    }
}
