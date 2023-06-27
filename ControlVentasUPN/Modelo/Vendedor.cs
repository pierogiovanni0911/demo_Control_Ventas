using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasUPN.Modelo
{
    public class Vendedor
    {
        private int idUsuario;
        private string nombre;
        private string apellido;
        private List<Venta> ventas;
        private double montoVentasTotal;
        private double comision;
        private double sueldoBase;
        private double sueldoTotal;
        private double bono;
        private DateTime fechaContratacion;
        private string sede;

        public Vendedor() { }

        public Vendedor(int idUsuario, string nombre, string apellido, List<Venta> ventas,
                double montoVentasTotal, double comision, double sueldoBase, double sueldoTotal,
                double bono, DateTime fechaContratacion, string sede)
        {
            this.IdUsuario = idUsuario;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Ventas = ventas;
            this.MontoVentasTotal = montoVentasTotal;
            this.Comision = comision;
            this.SueldoBase = sueldoBase;
            this.SueldoTotal = sueldoTotal;
            this.Bono = bono;
            this.FechaContratacion = fechaContratacion;
            this.Sede = sede;
        }

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public List<Venta> Ventas { get => ventas; set => ventas = value; }
        public double MontoVentasTotal { get => montoVentasTotal; set => montoVentasTotal = value; }
        public double Comision { get => comision; set => comision = value; }
        public double SueldoBase { get => sueldoBase; set => sueldoBase = value; }
        public double SueldoTotal { get => sueldoTotal; set => sueldoTotal = value; }
        public double Bono { get => bono; set => bono = value; }
        public DateTime FechaContratacion { get => fechaContratacion; set => fechaContratacion = value; }
        public string Sede { get => sede; set => sede = value; }
        
        public double CalcularMontoVentasTotal(string rutaArchivo)
        {
            CsvVenta csvVenta = new CsvVenta();
            return csvVenta.CalcularMontoVentasTotalPorVendedor(rutaArchivo, idUsuario);
        }

        public int ObtenerCantidadVentas(string rutaArchivo)
        {
            CsvVenta csvVenta = new CsvVenta();
            return csvVenta.ContarVentasPorVendedor(rutaArchivo, IdUsuario);
        }

        public double CalcularComisiones(string rutaArchivo)
        {
            CsvVenta csvVenta = new CsvVenta();
            double sumaPreciosTotales = csvVenta.CalcularMontoVentasTotalPorVendedor(rutaArchivo, idUsuario);
            double comisiones = 0;

            if (sumaPreciosTotales <= 20000)
            {
                comisiones = sumaPreciosTotales * 0.05; // Porcentaje de comisión para el rango de ventas hasta 1000
            }
            else if (sumaPreciosTotales <= 100000)
            {
                comisiones = sumaPreciosTotales * 0.08; // Porcentaje de comisión para el rango de ventas hasta 5000
            }
            else if (sumaPreciosTotales <= 200000)
            {
                comisiones = sumaPreciosTotales * 0.12; // Porcentaje de comisión para el rango de ventas hasta 10000
            }
            else
            {
                comisiones = sumaPreciosTotales * 0.15; // Porcentaje de comisión para el rango de ventas superior a 10000
            }

            return comisiones;
        }
    }
}
