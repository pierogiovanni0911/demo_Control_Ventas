using ControlVentasUPN.Modelo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasUPN.Controlador
{
    public class ProductoController
    {
        private CsvProducto csvProducto;
        static string rutaDirectorioProyecto = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
        static string rutaArchivoProdGen = Path.Combine(rutaDirectorioProyecto, "Resources", "adidas_usa.csv");

        public ProductoController()
        {
            csvProducto = new CsvProducto();
        }

        public List<Producto> BuscarProductoGenPorNombre(string nombreBusqueda)
        {
            List<Producto> productos = csvProducto.LeerProductosDesdeCsv(rutaArchivoProdGen);
            List<Producto> resultados = new List<Producto>();

            foreach (Producto producto in productos)
            {
                if (producto.NombreProducto.Contains(nombreBusqueda))
                {
                    resultados.Add(producto);
                }
            }

            return resultados;
        }

        public Producto BuscarProductoPorSku(string sku)
        {
            List<Producto> productos = csvProducto.LeerProductosDesdeCsv(rutaArchivoProdGen);

            foreach (Producto producto in productos)
            {
                if (producto.Sku == sku)
                {
                    return producto;
                }
            }

            return null;
        }

    }
}
