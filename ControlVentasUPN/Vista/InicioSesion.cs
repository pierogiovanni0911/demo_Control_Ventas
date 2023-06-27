using ControlVentasUPN.Servicios;
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
    public partial class InicioSesion : Form
    {
        private AuthenticationService authenticationService;
        public InicioSesion()
        {
            InitializeComponent();
            authenticationService = new AuthenticationService();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            bool inicioSesionExitoso = authenticationService.IniciarSesion(username, password);

            if (inicioSesionExitoso)
            {
                this.Hide();
                MenuPrincipal principal = new MenuPrincipal();
                principal.ActualizarEstadisticasVendedor();
                principal.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Credenciales inválidas. Por favor, intenta nuevamente.", "Error");
            }


        }
    }
}
