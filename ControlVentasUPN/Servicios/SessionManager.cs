using ControlVentasUPN.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasUPN.Servicios
{
    public class SessionManager
    {
        private static Vendedor vendedorActivo;

        public static Vendedor VendedorActivo
        {
            get { return vendedorActivo; }
            set {  vendedorActivo = value; }
        }
    }
}
