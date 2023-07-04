using ControlVentasUPN.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasUPN.Servicios
{
    public class AuthenticationService
    {
        private List<Usuario> usuarios;
        private List<Vendedor> vendedores;


        public AuthenticationService()
        {
            usuarios = new List<Usuario>();
            usuarios.Add(new Usuario(0, "piero0911", "123"));
            usuarios.Add(new Usuario(1, "aaron123", "123"));
            usuarios.Add(new Usuario(2, "carlos123", "123"));
            usuarios.Add(new Usuario(3, "dania123", "123"));

            vendedores = new List<Vendedor>();
            vendedores.Add(new Vendedor(0, "Piero", "Vargas", new List<Venta>(), 0.0, 0.0, 1025.0, 1025.0, 0.0, new DateTime(2023, 6, 20), "Breña"));
            vendedores.Add(new Vendedor(1, "Aaron", "Diaz", new List<Venta>(), 0.0, 0.0, 1025.0, 1025.0, 0.0, new DateTime(2023, 4, 9), "Surco"));
            vendedores.Add(new Vendedor(2, "Carlos", "Dongo", new List<Venta>(), 0.0, 0.0, 1025.0, 1025.0, 0.0, new DateTime(2023, 5, 12), "Breña"));
            vendedores.Add(new Vendedor(2, "Dania", "Chacaya", new List<Venta>(), 0.0, 0.0, 1025.0, 1025.0, 0.0, new DateTime(2023, 3, 25), "Los Olivos"));
        }

        public bool IniciarSesion(string username,  string password)
        {
            foreach(Usuario usuario in usuarios)
            {
                if(usuario.Username == username && usuario.Password == password)
                {
                    // Busca al vendedor correspondiente al usuario
                    Vendedor vendedor = null;

                    foreach (Vendedor vend in vendedores)
                    {
                        if(vend.IdUsuario == usuario.IdUsuario)
                        {
                            vendedor = vend;
                            break;
                        }
                    }

                    if(vendedor != null)
                    {
                        // Establece el vendedor activo
                        SessionManager.VendedorActivo = vendedor;
                        return true;
                    }
                }
            }

            return false;
        }

        
        public string ObtenerNombreVendedor(int idVendedor)
        {
            foreach (Vendedor vendedor in vendedores)
            {
                if(vendedor.IdUsuario == idVendedor)
                {
                    return $"{vendedor.Nombre} {vendedor.Apellido}";
                }
            }
            return string.Empty;
        }

        
        public Dictionary<string, int> ObtenerVentasPorVendedor(string rutaArchivoVentas)
        {
            Dictionary<string, int> ventasVendedores = new Dictionary<string, int>();

            foreach (Vendedor vendedor in vendedores)
            {
                int cantidadVentas = vendedor.ObtenerCantidadVentas(rutaArchivoVentas);
                ventasVendedores.Add(vendedor.Nombre, cantidadVentas);
            }

            return ventasVendedores;
        }

        

        

    }
}
