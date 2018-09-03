using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgenciaMedica.Models
{
    public class Usuario
    {
        int idUsuario;
        string user;
        string password;
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string User { get => user; set => user = value; }
        public string Password { get => password; set => password = value; }
    }
}