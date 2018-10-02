using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebGrease;
using EFAgendaMedica;

namespace AgenciaMedica.Models
{
    public class Usuario
    {
        int idUsuario;
        string user;
        string password;
        string email;

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }

        [Required(ErrorMessage = "Please enter student name.")]
        public string User { get => user; set => user = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }

        internal List<Usuario> GetUsuarios()
        {
            /*var usuariosListado = from user in EFAgendaMedica.usuarios.AsEnumerable()
                                  select user;
            return usuariosListado.ToList().ConvertAll(usu => new Usuario()
            {
                IdUsuario = usu.id,
                User = usu.usuario,
                Password = usu.password,
                Email = usu.email
            });*/
            return new List<Usuario>();
        }

        internal Usuario GetUsuario(string user, string password)
        {
            Usuario unUsuario = new Usuario();
            try
            {
            }
            catch(Exception ex)
            {
                throw ex;

            }
            return unUsuario;
        }

        internal bool GuardarUsuario(Usuario unUsuario)
        {
            bool correctInsert = false;
            try
            {

            }
            catch(Exception ex)
            {
                throw ex;
            }
            return correctInsert;
        }
    }
}