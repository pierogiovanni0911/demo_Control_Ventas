using ControlVentasUPN.Modelo;
using ControlVentasUPN.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ControlVentasUPN.Vista
{
    public partial class MenuPrincipal : Form
    {
        AuthenticationService service;
        static string rutaDirectorioProyecto = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
        static string rutaArchivoVentas = Path.Combine(rutaDirectorioProyecto, "Resources", "ventas.csv");

        public MenuPrincipal()
        {
            InitializeComponent();
            service = new AuthenticationService();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registrarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroVenta formRegistroVenta = new RegistroVenta();
            formRegistroVenta.ShowDialog();
        }

        private void gestionarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroUsuario formRegistroUsuario = new RegistroUsuario();
            formRegistroUsuario.ShowDialog();
        }

        private void consultarVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarVenta formConsultarVentas = new ConsultarVenta();
            formConsultarVentas.ShowDialog();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            InicioSesion formInicioSesion = new InicioSesion();
            formInicioSesion.Show();
            
        }

        public void ActualizarEstadisticasVendedor()
        {
            txtIdVendedor.Text = SessionManager.VendedorActivo.IdUsuario.ToString();
            txtNombreVendedor.Text = SessionManager.VendedorActivo.Nombre;
            txtApellidoVendedor.Text = SessionManager.VendedorActivo.Apellido;
            txtTotalCantidadVentas.Text = SessionManager.VendedorActivo.ObtenerCantidadVentas(rutaArchivoVentas).ToString();
            txtMontoVentas.Text = SessionManager.VendedorActivo.CalcularMontoVentasTotal(rutaArchivoVentas).ToString("C2");
            txtSueldoBase.Text = SessionManager.VendedorActivo.SueldoBase.ToString("C2");
            txtComisiones.Text = SessionManager.VendedorActivo.CalcularComisiones(rutaArchivoVentas).ToString("C2");
            double sueldoTotal = SessionManager.VendedorActivo.SueldoBase + SessionManager.VendedorActivo.CalcularComisiones(rutaArchivoVentas);
            txtSueldoTotal.Text = sueldoTotal.ToString("C2");
            txtFechaContrato.Text = SessionManager.VendedorActivo.FechaContratacion.ToString();

            CsvVenta csvVenta = new CsvVenta();
            Dictionary<int, double> montosVendedores = csvVenta.ObtenerMontosTotalesVendedores(rutaArchivoVentas);

            //Chart
            // Limpiar grafico
            chart1.Series.Clear();

            // Crear una nueva serie de datos para el gráfico
            Series serieMontos = new Series("Total Monto Vendido");
            serieMontos.ChartType = SeriesChartType.Column;

            // Agregar los montos de cada vendedor a la serie
            foreach (var vendedor in montosVendedores)
            {
                string nombreVendedor = service.ObtenerNombreVendedor(vendedor.Key);

                // Agregar el punto de datos con el nombre y el monto
                serieMontos.Points.AddXY(nombreVendedor, vendedor.Value);
            }

            // Agregar la serie al gráfico
            chart1.Series.Add(serieMontos);
        }
    }
}
