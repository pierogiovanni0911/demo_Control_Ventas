using ControlVentasUPN.Modelo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasUPN.Servicios
{
    // En proceso....
    public class GestorBono
    {
        /*static string rutaDirectorioProyecto = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
        static string rutaArchivoVentas = Path.Combine(rutaDirectorioProyecto, "Resources", "ventas.csv");

        public void OtorgarBono()
        {
            CsvVenta csvVenta = new CsvVenta();
            List<Venta> ventas = csvVenta.CargarVentas(rutaArchivoVentas);

            // Crear pila
            Stack<KeyValuePair<int, int>> vendedoresVentas = new Stack<KeyValuePair<int, int>>();

            // Contar ventas realizadas por cada vendedor
            foreach (Venta venta in ventas)
            {
                bool vendedorEncontrado = false;

                foreach (KeyValuePair<int, int> vendedor in vendedoresVentas)
                {
                    if(vendedor.Key == venta.IdVendedor)
                    {
                        vendedorEncontrado = true;
                        vendedoresVentas.Push(new KeyValuePair<int, int>(vendedor.Key, vendedor.Value + 1));
                        break;
                    }
                }

                if (!vendedorEncontrado)
                {
                    vendedoresVentas.Push(new KeyValuePair<int, int>(venta.IdVendedor, 1));
                }
            }

            // Ordenar la pila en función de las cantidades de ventas (de mayor a menor)
            List<KeyValuePair<int, int>> sortedVendedores = new List<KeyValuePair<int, int>>();
            while (vendedoresVentas.Count > 0)
            {
                KeyValuePair<int, int> maxVendedor = new KeyValuePair<int, int>(0, int.MinValue);
                foreach (KeyValuePair<int, int> vendedor in vendedoresVentas)
                {
                    if (vendedor.Value > maxVendedor.Value)
                    {
                        maxVendedor = vendedor;
                    }
                }

                sortedVendedores.Add(maxVendedor);
                vendedoresVentas.Remove(maxVendedor);
            }
        }*/
    }
}
