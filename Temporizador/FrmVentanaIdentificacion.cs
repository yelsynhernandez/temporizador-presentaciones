using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temporizador
{
    public partial class FrmVentanaIdentificacion : Form
    {
        private int idMonitor { get; set; }
        public FrmVentanaIdentificacion(int _idMonitor)
        {
            InitializeComponent();
            idMonitor = _idMonitor;
        }

        private void FrmVentanaIdentificacion_Load(object sender, EventArgs e)
        {
            lblId.Text = idMonitor.ToString();
        }
    }
}
