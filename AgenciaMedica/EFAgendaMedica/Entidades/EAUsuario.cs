using EFAgendaMedica;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AgenciaMedica.Models
{ 
    public class EAUsuario : Entities
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

        public List<EAUsuario> GetUsuarios()
        {
            /*var usuariosListado = from user in usuarios.ToString()
                                  select user;
            return usuariosListado.ToList().ConvertAll(usu => new Usuario()
            {
                IdUsuario = usu.id,
                User = usu.usuario,
                Password = usu.password,
                Email = usu.email
            });*/
            return new List<EAUsuario>();
        }

        internal EAUsuario GetUsuario(string user, string password)
        {
            EAUsuario unUsuario = new EAUsuario();
            try
            {
            }
            catch(Exception ex)
            {
                throw ex;

            }
            return unUsuario;
        }

        internal bool GuardarUsuario(EAUsuario unUsuario)
        {
            usuarios usuas = new usuarios();
            bool correctInsert = false;
            try
            {
                usuarios.Add(usuas);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return correctInsert;
        }
    }
}