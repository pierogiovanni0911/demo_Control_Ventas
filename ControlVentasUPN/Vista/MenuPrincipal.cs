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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
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
    }
}
