using ControlVentasUPN.Modelo;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlVentasUPN.Vista
{
    public partial class ConsultarVenta : Form
    {
        static string rutaDirectorioProyecto = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
        static string rutaArchivoVentas = Path.Combine(rutaDirectorioProyecto, "Resources", "ventas.csv");

        public ConsultarVenta()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = dtpInicio.Value.Date;
            DateTime fechaFin = dtpFin.Value.Date;

            CsvVenta csvVenta = new CsvVenta();
            List<Venta> ventasFiltradas = csvVenta.FiltrarVentasPorFecha(rutaArchivoVentas, fechaInicio, fechaFin);
            ActualizarDataGridVentas(ventasFiltradas);
        }

        private void ActualizarDataGridVentas(List<Venta> resultados)
        {
            dgvVentasFiltradas.Rows.Clear();

            foreach (Venta venta in resultados)
            {
                dgvVentasFiltradas.Rows.Add(
                    venta.IdVenta,
                    venta.DocumentoCliente,
                    venta.NombreCl,
                    venta.ApellidoPaternoCl,
                    venta.ApellidoMaternoCl,
                    venta.FechaVenta,
                    venta.PrecioTotal
                    );
            }
        }
    }
}
