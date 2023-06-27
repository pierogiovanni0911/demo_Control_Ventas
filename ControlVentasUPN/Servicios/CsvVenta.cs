using ControlVentasUPN.Servicios;
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
    public class CsvVenta
    {
        public void GuardarVenta(Venta venta, string rutaArchivo)
        {
            bool existeArchivo = File.Exists(rutaArchivo);
            
            using (var writer = new StreamWriter(rutaArchivo, true))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                // Configura escritura de encabezado en caso este vacío
                if(!existeArchivo || new FileInfo(rutaArchivo).Length == 0)
                {
                    csv.WriteHeader<Venta>();
                    csv.NextRecord();
                }

                venta.IdVendedor = SessionManager.VendedorActivo.IdUsuario;
                
                // Escribe la venta en el archivo CSV
                csv.WriteRecord(venta);
                csv.NextRecord();
            } 
        }

        public List<Venta> CargarVentas(string rutaArchivo)
        {
            using (var reader = new StreamReader(rutaArchivo))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                return csv.GetRecords<Venta>().ToList();
            }
        }

        public List<Venta> FiltrarVentasPorFecha(string rutaArchivo, DateTime fechaInicio, DateTime fechaFin)
        {
            List<Venta> ventasFiltradas = new List<Venta>();

            int idVendedorActivo = SessionManager.VendedorActivo.IdUsuario;

            using (var reader = new StreamReader(rutaArchivo))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var ventas = csv.GetRecords<Venta>();

                foreach (var venta in ventas)
                {
                    if (venta.FechaVenta >= fechaInicio && venta.FechaVenta <= fechaFin && venta.IdVendedor == idVendedorActivo)
                    {
                        ventasFiltradas.Add(venta);
                    }
                }
            }

            return ventasFiltradas;
        }

        public double CalcularMontoVentasTotalPorVendedor(string rutaArchivo, int idUsuario)
        {
            double montoTotal = 0;
            List<Venta> ventas = CargarVentas(rutaArchivo);

            foreach (Venta venta in ventas)
            {
                if (venta.IdVendedor == idUsuario)
                {
                    montoTotal += venta.PrecioTotal;
                }
            }
            return montoTotal;
        }

        public int ContarVentasPorVendedor(string rutaArchivo, int idUsuario)
        {
            int cantidadVentas = 0;
            List<Venta> ventas = CargarVentas(rutaArchivo);

            foreach (Venta venta in ventas)
            {
                if (venta.IdVendedor == idUsuario)
                {
                    cantidadVentas++;
                }
            }
            return cantidadVentas;
        }

        public Dictionary<int, double> ObtenerMontosTotalesVendedores(string rutaArchivo)
        {
            Dictionary<int, double> montosVendedores = new Dictionary<int, double>();

            List<Venta> ventas = CargarVentas(rutaArchivo);

            // Calcular los montos totales por vendedor
            foreach (Venta venta in ventas)
            {
                int idVendedor = venta.IdVendedor;
                double montoVenta = venta.PrecioTotal;

                if (montosVendedores.ContainsKey(idVendedor))
                {
                    montosVendedores[idVendedor] += montoVenta;
                }
                else
                {
                    montosVendedores[idVendedor] = montoVenta;
                }
            }

            return montosVendedores;
        }

    }
}
