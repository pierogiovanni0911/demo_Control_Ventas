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

            InicioSesion formPrincipal = new InicioSesion();
            formPrincipal.WindowState = FormWindowState.Normal;
            Application.Run(formPrincipal);
            int cantidadVentanasAbiertas = Application.OpenForms.Count;
            Console.WriteLine(cantidadVentanasAbiertas);

        }
    }
}
