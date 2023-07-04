using ControlVentasUPN.Controlador;
using ControlVentasUPN.Modelo;
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

namespace ControlVentasUPN.Vista
{
    public partial class RegistroVenta : Form
    {
        ProductoController productoController;
        VentaController ventaController;
        Venta ventaActual;
        private MenuPrincipal menuPrincipal;

        public RegistroVenta(MenuPrincipal menuPrincipal)
        {
            InitializeComponent();
            productoController = new ProductoController();
            ventaController = new VentaController();
            ventaActual = new Venta();
            this.menuPrincipal = menuPrincipal;
            this.FormClosing += RegistroVenta_FormClosing;
        }

        private void btnRealizarVenta_Click(object sender, EventArgs e)
        {
            
            // Obtener datos de venta
            ventaActual.DocumentoCliente = txtDocumento.Text;
            ventaActual.NombreCl = txtNombreCl.Text;
            ventaActual.ApellidoPaternoCl = txtApellidoPaCl.Text;
            ventaActual.ApellidoMaternoCl = txtApellidoMaCl.Text;
            ventaActual.FechaVenta = DateTime.Now;
            ventaActual.PrecioTotal = ventaController.CalcularMontoTotalCarrito();

            if(ventaController.Carrito.Count == 0)
            {
                MessageBox.Show("Carrito de ventas vacío. Agregue productos.", "Error");
                return;
            }

            // Guardar venta en archivo CSV
            ventaController.GuardarVenta(ventaActual);

            // Limpiar carrito y reinicar venta actual
            ventaController.Carrito.Clear();
            dgvCarritoProd.Rows.Clear();
            txtMontoTotal.Text = "0.00";
            limpiarCamposCliente();
            limpiarCamposProducto();

            MessageBox.Show("Venta guardada con éxito");
        }

        private void btnAgregarProd_Click(object sender, EventArgs e)
        {
            string sku = txtSkuProd.Text;
            string cantidadText = txtCantidadProd.Text;
            int cantidadVendida;

            if(string.IsNullOrEmpty(sku) || string.IsNullOrEmpty(cantidadText))
            {
                MessageBox.Show("Ingrese Sku y cantidad del producto", "Error");
                return;
            }

            if(!int.TryParse(cantidadText, out cantidadVendida))
            {
                MessageBox.Show("La cantidad ingresada no es válida", "Error");
                return;
            }

            ventaController.AgregarProductoAlCarrito(sku, cantidadVendida);
            txtMontoTotal.Text = ventaController.CalcularMontoTotalCarrito().ToString();
            ActualizarDataGridViewCarrito();
            
        }

        private void btnBuscarProdGen_Click(object sender, EventArgs e)
        {
            string nombreBusqueda = txtNombreProdGeneral.Text;
            List<Producto> resultados = productoController.BuscarProductoGenPorNombre(nombreBusqueda);
            ActualizarDataGridView(resultados);
        }

        private void btnBuscarProdCarrito_Click(object sender, EventArgs e)
        {
            string sku = txtSkuProd.Text;
            Producto productoEncontrado = productoController.BuscarProductoPorSku(sku);

            if (productoEncontrado != null)
            {
                txtNombreProd.Text = productoEncontrado.NombreProducto;
                txtPrecioProd.Text = productoEncontrado.PrecioVenta.ToString();
            }
            else
            {
                MessageBox.Show("Producto no encontrado", "Error");
            }
        }

        private void ActualizarDataGridView(List<Producto> resultados)
        {
            dgvProductosGeneral.Rows.Clear();

            foreach (Producto producto in resultados)
            {
                dgvProductosGeneral.Rows.Add(
                    producto.Index,
                    producto.NombreProducto,
                    producto.Sku,
                    producto.PrecioVenta,
                    producto.Disponibilidad,
                    producto.Color,
                    producto.Categoria,
                    producto.Url,
                    producto.Imagenes,
                    producto.CalificacionPromedio,
                    producto.CantidadCalificaciones
                    );
            }
        }
        private void ActualizarDataGridViewCarrito()
        {
            dgvCarritoProd.Rows.Clear();

            foreach(Producto producto in ventaController.Carrito)
            {
                dgvCarritoProd.Rows.Add(
                    producto.NombreProducto,
                    producto.Disponibilidad,
                    producto.CantidadVendida,
                    producto.PrecioVenta,
                    producto.calcularSubTotalProducto()
                    );
            }
        }

        private void btnLimpiarCarrito_Click(object sender, EventArgs e)
        {
            limpiarCamposProducto();
        }

        private void btnLimpiarDatosCl_Click(object sender, EventArgs e)
        {
            limpiarCamposCliente();
        }

        private void limpiarCamposCliente()
        {
            txtDocumento.Text = "";
            txtNombreCl.Text = "";
            txtApellidoPaCl.Text = "";
            txtApellidoMaCl.Text = "";
        }

        private void limpiarCamposProducto()
        {
            txtSkuProd.Text = "";
            txtNombreProd.Text = "";
            txtCantidadProd.Text = "";
            txtPrecioProd.Text = "";
            dgvCarritoProd.Rows.Clear();
            ventaActual.Productos.Clear();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            this.Close();
            menuPrincipal.ActualizarEstadisticasVendedor();
        }

        private void RegistroVenta_FormClosing(object sender, FormClosingEventArgs e)
        {
            menuPrincipal.ActualizarEstadisticasVendedor();
        }
    }
}
