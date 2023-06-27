using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasUPN.Modelo
{
    public class Usuario
    {
        private int idUsuario;
        private string username;
        private string password;

        public Usuario() { }

        public Usuario(int idUsuario, string username, string password)
        {
            this.IdUsuario = idUsuario;
            this.Username = username;
            this.Password = password;
        }

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

    }
}
