using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasUPN.Modelo
{
    class CsvProducto
    {
        public List<Producto> LeerProductosDesdeCsv(string ruta)
        {
            List<Producto> productos = new List<Producto>();

            using (StreamReader reader = new StreamReader(ruta))
            using (CsvReader csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Read();
                csv.ReadHeader();

                while (csv.Read())
                {

                    int index = csv.GetField<int>(0);
                    string url = csv.GetField<string>(1);
                    string nombreProducto = csv.GetField<string>(2);
                    string sku = csv.GetField<string>(3);
                    double precioVenta = csv.GetField<double>(4);
                    string moneda = csv.GetField<string>(6);
                    string disponibilidad = csv.GetField<string>(7);
                    string color = csv.GetField<string>(8);
                    string categoria = csv.GetField<string>(9);
                    string[] imagenes = csv.GetField<string>(15).Split(';');
                    List<string> listaImagenes = new List<string>(imagenes);
                    double calificacionPromedio = csv.GetField<double>(18);
                    int cantidadCalificaciones = csv.GetField<int>(19);

                    Producto producto = new Producto(index, url, nombreProducto, sku, precioVenta, moneda, 
                        disponibilidad, color, categoria, listaImagenes, calificacionPromedio, cantidadCalificaciones);
                    productos.Add(producto);
                }
            }

            return productos;
        }
    }
}
