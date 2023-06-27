using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasUPN.Modelo
{
    public class Producto
    {
        private int index;
        private string url;
        private string nombreProducto;
        private string sku;
        private double precioVenta;
        private int cantidadVendida;
        private string disponibilidad;
        private string color;
        private string categoria;
        private List<string> imagenes;
        private double calificacionPromedio;
        private int cantidadCalificaciones;

        public Producto(int index, string url, string nombreProducto, string sku, double precioVenta, string disponibilidad,
                string color, string categoria, List<string> imagenes, double calificacionPromedio, int cantidadCalificaciones)
        {
            this.index = index;
            this.url = url;
            this.nombreProducto = nombreProducto;
            this.sku = sku;
            this.precioVenta = precioVenta;
            this.disponibilidad = disponibilidad;
            this.color = color;
            this.categoria = categoria;
            this.imagenes = new List<string>();
            this.calificacionPromedio = calificacionPromedio;
            this.cantidadCalificaciones = cantidadCalificaciones;
        }
        
        public Producto(int index, string url, string nombreProducto, string sku, double precioVenta, int cantidadVendida,
                string disponibilidad, string color, string categoria, List<string> imagenes, double calificacionPromedio,
                int cantidadCalificaciones)
        {
            this.index = index;
            this.url = url;
            this.nombreProducto = nombreProducto;
            this.sku = sku;
            this.precioVenta = precioVenta;
            this.cantidadVendida = cantidadVendida;
            this.disponibilidad = disponibilidad;
            this.color = color;
            this.categoria = categoria;
            this.imagenes = new List<string>();
            this.calificacionPromedio = calificacionPromedio;
            this.cantidadCalificaciones = cantidadCalificaciones;
        }

        public int Index { get => index; set => index = value; }
        public string Url { get => url; set => url = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public string Sku { get => sku; set => sku = value; }
        public double PrecioVenta { get => precioVenta; set => precioVenta = value; }
        public string Disponibilidad { get => disponibilidad; set => disponibilidad = value; }
        public string Color { get => color; set => color = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public List<string> Imagenes { get => imagenes; set => imagenes = value; }
        public double CalificacionPromedio { get => calificacionPromedio; set => calificacionPromedio = value; }
        public int CantidadCalificaciones { get => cantidadCalificaciones; set => cantidadCalificaciones = value; }
        public int CantidadVendida { get => cantidadVendida; set => cantidadVendida = value; }

        public double calcularSubTotalProducto()
        {
            return precioVenta * cantidadVendida;
        }
    }
}
