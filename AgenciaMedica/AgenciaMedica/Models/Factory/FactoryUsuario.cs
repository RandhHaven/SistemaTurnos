using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgenciaMedica.Models.Factory
{
    public class FactoryUsuario : BaseUsuario
    {        
        #region Methods
        public List<Usuario> GetUsuarios()
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
            try
            {
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return new Usuario();
        }

        internal bool GuardarUsuario(Usuario unUsuario)
        {
            bool correctInsert = false;
            try
            {

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return correctInsert;
        }

        public override Usuario Save()
        {
            throw new NotImplementedException();
        }

        public override void Registrar(Usuario unUsuario)
        {
            throw new NotImplementedException();
        }

        private Usuario CreateFactoryUsuario()
        {
            Usuario oUsuario = new Usuario();
            // Aca va a la base de datos y recupera los datos del usuario.
            return oUsuario;
        }

        private Usuario GetUsuario()
        {
            Usuario oUsuario = new Usuario();
            oUsuario = (Usuario)HttpContext.Current.Session["Usuario"];
            if (Object.Equals(oUsuario, null))
            {
                oUsuario = this.CreateFactoryUsuario();
                HttpContext.Current.Session["Usuario"] = oUsuario;
            }
            return oUsuario;
        }

        #endregion
    }
}