using AgenciaMedica.Models;
using AgenciaMedica.Models.Core;
using System.Web.Mvc;


namespace AgenciaMedica.Controllers
{
    public class ActionController :  Controller
    {
        // GET: Inicio
        public ActionResult Login()
        {
            ViewBag.Tittle = "Inicio de Sesión";
            return View();
        }

        public ActionResult Registro()
        {
            return this.View();
        }

        [HttpPost]
        public ActionResult Ingresar(string user, string password)
        {
            //Crear todo el esquema de ingreso.
            Usuario usuario = CoreUsuario.ValidarYObtenerUsuario(user, password);
            if (object.Equals(usuario, null))
            {
            }
            else
            {
            }
            return View("Error");
        }

        [HttpPost]
        public ActionResult Registrar(string userName, string email, string password)
        {
            Usuario usuario = CoreUsuario.RegistrarNuevoUsuario(userName, email, password);
            return View("Registro");
        }
    }
}