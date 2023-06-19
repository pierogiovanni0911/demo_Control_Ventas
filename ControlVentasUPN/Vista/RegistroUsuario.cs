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
    public partial class RegistroUsuario : Form
    {
        public RegistroUsuario()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Obtener valores
            string nombre = txtNombreUsuario.Text;
            string apellidos = txtApllUsuario.Text;
            string usuario = txtUsuario.Text;
            string contrasenha = txtContrasenha.Text;
            string privilegios = cboTipoUsuario.SelectedItem.ToString();
            string sede = cboSede.SelectedItem.ToString();

            // Validar Campos
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellidos) ||
                string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contrasenha) ||
                cboTipoUsuario.SelectedItem == null || cboSede.SelectedItem == null) 
            {
                MessageBox.Show("Por favor, complete todos los campos antes de guardar el usuario.");
                return;
            }
        }
    }
}
