using AgenciaMedica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AgenciaMedica.Controllers
{
    public class ActionController : Controller
    {
        // GET: Inicio
        public ActionResult Login()
        {
            ViewBag.Tittle = "Inicio de Sesion";
            return View();
        }

        public ActionResult Registro()
        {
            return this.View();
        }

        [HttpPost]
        public ActionResult Ingresar(string user, string password)
        {
            Usuario unUsuario = new Usuario
            {
                User = user,
                Password = password
            };
            //Crear todo el esquema de ingreso.
            
            user = null;
            password = null;
            return View("Login");
        }

        [HttpPost]
        public ActionResult Registrar(string userName, string email, string password)
        {
            return View("Registro");
        }
    }
}