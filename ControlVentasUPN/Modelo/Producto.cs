using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasUPN.Modelo
{
    class Producto
    {
        private int index;
        private string url;
        private string nombreProducto;
        private string sku;
        private double precioVenta;
        private string moneda;
        private string disponibilidad;
        private string color;
        private string categoria;
        private List<string> imagenes;
        private double calificacionPromedio;
        private int cantidadCalificaciones;

        public Producto(int index, string url, string nombreProducto, string sku, double precioVenta, string moneda, string disponibilidad, string color, string categoria, List<string> imagenes, double calificacionPromedio, int cantidadCalificaciones)
        {
            this.Index = index;
            this.Url = url;
            this.NombreProducto = nombreProducto;
            this.Sku = sku;
            this.PrecioVenta = precioVenta;
            this.Moneda = moneda;
            this.Disponibilidad = disponibilidad;
            this.Color = color;
            this.Categoria = categoria;
            this.Imagenes = new List<string>();
            this.CalificacionPromedio = calificacionPromedio;
            this.CantidadCalificaciones = cantidadCalificaciones;
        }

        public int Index { get => index; set => index = value; }
        public string Url { get => url; set => url = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public string Sku { get => sku; set => sku = value; }
        public double PrecioVenta { get => precioVenta; set => precioVenta = value; }
        public string Moneda { get => moneda; set => moneda = value; }
        public string Disponibilidad { get => disponibilidad; set => disponibilidad = value; }
        public string Color { get => color; set => color = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public List<string> Imagenes { get => imagenes; set => imagenes = value; }
        public double CalificacionPromedio { get => calificacionPromedio; set => calificacionPromedio = value; }
        public int CantidadCalificaciones { get => cantidadCalificaciones; set => cantidadCalificaciones = value; }
    }
}
