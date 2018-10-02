using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AgenciaMedica.Models
{
    internal class Usuario : Entities
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
            var usuariosListado = from user in usuariosSet.AsEnumerable()
                                  select user;
            return usuariosListado.ToList().ConvertAll(usu => new Usuario()
            {
                IdUsuario = usu.id,
                User = usu.usuario,
                Password = usu.password,
                Email = usu.email                
            });
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