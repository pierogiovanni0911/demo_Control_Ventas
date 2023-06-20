using ControlVentasUPN.Modelo;
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

            MenuPrincipal formPrincipal = new MenuPrincipal();
            formPrincipal.WindowState = FormWindowState.Normal;
            Application.Run(formPrincipal);

            
        }
    }
}
