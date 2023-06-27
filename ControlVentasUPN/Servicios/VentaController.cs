using ControlVentasUPN.Modelo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasUPN.Controlador
{
    public class VentaController
    {
        private List<Producto> carrito;
        private List<Venta> ventas;
        private CsvVenta csvVenta;
        private ProductoController productoController;
        private int ultimaIdVenta;
        static string rutaDirectorioProyecto = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
        static string rutaArchivoVentas = Path.Combine(rutaDirectorioProyecto, "Resources", "ventas.csv");

        

        public VentaController()
        {
            Carrito = new List<Producto>();
            Ventas = new List<Venta>();
            csvVenta = new CsvVenta();
            productoController = new ProductoController();
            ultimaIdVenta = ObtenerUltimaIdVenta();
        }

        public void AgregarProductoAlCarrito(string sku, int cantidadVendida)
        {
            Producto productoEncontrado = productoController.BuscarProductoPorSku(sku);

            if(productoEncontrado != null)
            {
                productoEncontrado.CantidadVendida = cantidadVendida;
                Carrito.Add(productoEncontrado);
            }
        }

        public double CalcularMontoTotalCarrito()
        {
            double montoTotalCarrito = 0;
            foreach (Producto producto in Carrito)
            {
                montoTotalCarrito += producto.PrecioVenta * producto.CantidadVendida;
            }
            return montoTotalCarrito;
        }

        public void GuardarVenta(Venta venta)
        {
            venta.IdVenta = GenerarNuevoIdVenta();
            Ventas.Add(venta);
            csvVenta.GuardarVenta(venta, rutaArchivoVentas);
        }

        private int GenerarNuevoIdVenta()
        {
            ultimaIdVenta++;
            return ultimaIdVenta;
        }

        private int ObtenerUltimaIdVenta()
        {
            // Verificar si hay ventas existentes
            if (ventas.Count > 0)
            {
                int maxIdVenta = ventas[0].IdVenta;

                // Recorriendo ventas para encontrar maxIdVenta
                for (int i = 1; i < ventas.Count; i++)
                {
                    if (ventas[i].IdVenta > maxIdVenta)
                    {
                        maxIdVenta = ventas[i].IdVenta;
                    }
                }

                return maxIdVenta;
            }
            else
            {
                return 1;
            }
        }

        public List<Producto> Carrito { get => carrito; set => carrito = value; }
        public List<Venta> Ventas { get => ventas; set => ventas = value; }
    }
}
