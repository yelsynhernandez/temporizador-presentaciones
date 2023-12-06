using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temporizador.Clases
{
    internal class Acciones
    {
        public bool CerrarFormulario(Type formType)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == formType)
                {
                    form.Close();
                    return true; 
                }
            }
            return false; 
        }

    }
}
