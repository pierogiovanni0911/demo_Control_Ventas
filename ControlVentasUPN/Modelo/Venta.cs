using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasUPN.Modelo
{
    internal class Venta
    {
        private int idVenta;
        private string documentoCliente;
        private string nombreCl;
        private string apellidoPaternoCl;
        private string apellidoMaternoCl;
        private DateTime fechaVenta;
        private List<Producto> productos;
        private double precioTotal;

        public Venta(int idVenta, string documentoCliente, string nombreCl, string apellidoPaternoCl, string apellidoMaternoCl, DateTime fechaVenta, List<Producto> productos, double precioTotal)
        {
            this.IdVenta = idVenta;
            this.DocumentoCliente = documentoCliente;
            this.NombreCl = nombreCl;
            this.ApellidoPaternoCl = apellidoPaternoCl;
            this.ApellidoMaternoCl = apellidoMaternoCl;
            this.FechaVenta = fechaVenta;
            this.Productos = new List<Producto>();
            this.PrecioTotal = precioTotal;
        }

        public int IdVenta { get => idVenta; set => idVenta = value; }
        public string DocumentoCliente { get => documentoCliente; set => documentoCliente = value; }
        public string NombreCl { get => nombreCl; set => nombreCl = value; }
        public string ApellidoPaternoCl { get => apellidoPaternoCl; set => apellidoPaternoCl = value; }
        public string ApellidoMaternoCl { get => apellidoMaternoCl; set => apellidoMaternoCl = value; }
        public DateTime FechaVenta { get => fechaVenta; set => fechaVenta = value; }
        public double PrecioTotal { get => precioTotal; set => precioTotal = value; }
        internal List<Producto> Productos { get => productos; set => productos = value; }

        private double calcularPrecioTotal()
        {
            double total = 0;
            foreach (var producto in Productos)
            {
                total += producto.PrecioVenta * Productos.Count;
            }
            return total;
        }
    }
}
