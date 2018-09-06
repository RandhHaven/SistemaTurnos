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
        string email;
        
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string User { get => user; set => user = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
    }
}