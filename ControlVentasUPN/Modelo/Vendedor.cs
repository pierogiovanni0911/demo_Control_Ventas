using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasUPN.Modelo
{
    class Vendedor
    {
        private int idVendedor;
        private string nombre;
        private string apellido;
        private List<Venta> ventas;
        private double comision;
        private double sueldoBase;
        private double sueldoTotal;
        private double bono;
        private DateTime fechaContratacion;
        private string sede;

        public Vendedor() { }

        public Vendedor(int idVendedor, string nombre, string apellido, List<Venta> ventas, double comision, double sueldoBase, 
            double sueldoTotal, double bono, DateTime fechaContratacion, string sede)
        {
            this.IdVendedor = idVendedor;
            this.Nombre = nombre;
            this.Apellido= apellido;
            this.Ventas = new List<Venta>();
            this.Comision = comision;
            this.SueldoBase = sueldoBase;
            this.SueldoTotal = sueldoTotal;
            this.Bono = bono;
            this.FechaContratacion = fechaContratacion;
            this.Sede = sede;
        }

        public int IdVendedor { get => idVendedor; set => idVendedor = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public double Comision { get => comision; set => comision = value; }
        public double SueldoTotal { get => sueldoTotal; set => sueldoTotal = value; }
        public double Bono { get => bono; set => bono = value; }
        public DateTime FechaContratacion { get => fechaContratacion; set => fechaContratacion = value; }
        public string Sede { get => sede; set => sede = value; }
        public double SueldoBase { get => sueldoBase; set => sueldoBase = value; }
        internal List<Venta> Ventas { get => ventas; set => ventas = value; }
    }
}
