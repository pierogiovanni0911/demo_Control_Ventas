using ControlVentasUPN.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlVentasUPN.Vista
{
    public partial class RegistroVenta : Form
    {
        private List<Producto> carrito;
        public RegistroVenta()
        {
            InitializeComponent();
            carrito = new List<Producto>();
        }

        private void btnBuscarProdGen_Click(object sender, EventArgs e)
        {
            string nombreBusqueda = txtNombreProdGeneral.Text;
            List<Producto> resultados = BuscarProductos(nombreBusqueda);
            ActualizarDataGridView(resultados);
        }

        private List<Producto> BuscarProductos(string nombreBusqueda)
        {
            CsvProducto lectorCsv = new CsvProducto();
            string rutaArchivo = "C:\\Users\\piero\\source\\repos\\ControlVentasUPN\\ControlVentasUPN\\Resources\\adidas_usa.csv";
            List<Producto> productos = lectorCsv.LeerProductosDesdeCsv(rutaArchivo);

            List<Producto> resultados = new List<Producto>();

            foreach (Producto producto in productos)
            {
                if (producto.NombreProducto.Contains(nombreBusqueda))
                {
                    resultados.Add(producto);
                }
            }

            return resultados;
        }

        private void ActualizarDataGridView(List<Producto> resultados)
        {
            dgvProductosGeneral.Rows.Clear();

            foreach (Producto producto in resultados)
            {
                dgvProductosGeneral.Rows.Add(
                    producto.Index,
                    producto.NombreProducto,
                    producto.Url,
                    producto.Sku,
                    producto.PrecioVenta,
                    producto.Moneda,
                    producto.Disponibilidad,
                    producto.Color,
                    producto.Categoria,
                    producto.Imagenes,
                    producto.CalificacionPromedio,
                    producto.CantidadCalificaciones
                    );
            }
        }

        private void btnBuscarProdCarrito_Click(object sender, EventArgs e)
        {
            string sku = txtSkuProd.Text;
            Producto productoEncontrado = BuscarProductoPorSku(sku);

            if (productoEncontrado != null)
            {
                txtNombreProd.Text = productoEncontrado.NombreProducto;
                txtPrecioProd.Text = productoEncontrado.PrecioVenta.ToString();
            }
            else
            {
                MessageBox.Show("Producto no encontrado");
            }
        }

        private Producto BuscarProductoPorSku(string sku)
        {
            CsvProducto lectorCsv = new CsvProducto();
            string rutaArchivo = "C:\\Users\\piero\\source\\repos\\ControlVentasUPN\\ControlVentasUPN\\Resources\\adidas_usa.csv";
            List<Producto> productos = lectorCsv.LeerProductosDesdeCsv(rutaArchivo);

            foreach (Producto producto in productos)
            {
                if (producto.Sku == sku)
                {
                    return producto;
                }
            }

            return null;
        }

        private void btnAgregarProd_Click(object sender, EventArgs e)
        {
            string sku = txtSkuProd.Text;
            int cantidadVendida = int.Parse(txtCantidadProd.Text);

            Producto productoEncontrado = BuscarProductoPorSku(sku);

            if(productoEncontrado != null)
            {
                double montoTotal = productoEncontrado.PrecioVenta * cantidadVendida;

                // Agregando producto a carrito
                Producto productoCarrito = new Producto(productoEncontrado.Index, productoEncontrado.Url,
                    productoEncontrado.NombreProducto, productoEncontrado.Sku, productoEncontrado.PrecioVenta,
                    productoEncontrado.Moneda, productoEncontrado.Disponibilidad, productoEncontrado.Color,
                    productoEncontrado.Categoria, productoEncontrado.Imagenes, productoEncontrado.CalificacionPromedio,
                    productoEncontrado.CantidadCalificaciones);
                carrito.Add(productoCarrito);

                // Actualizar monto total
                double montoTotalCarrito = 0;
                foreach(Producto producto in carrito)
                {
                    montoTotalCarrito += producto.PrecioVenta * cantidadVendida;
                }
                txtMontoTotal.Text = montoTotalCarrito.ToString();

                // Mostrar productos en dgv
                dgvCarritoProd.Rows.Add(
                    productoCarrito.NombreProducto,
                    productoCarrito.Disponibilidad,
                    cantidadVendida,
                    productoCarrito.PrecioVenta
                    );
            }
            else
            {
                MessageBox.Show("Producto no encontrado");
            }
        }
    }
}
