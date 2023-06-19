using ControlVentasUPN.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlVentasUPN
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            RegistroUsuario formPrincipal = new RegistroUsuario();
            
            Application.Run(formPrincipal);
        }
    }
}
