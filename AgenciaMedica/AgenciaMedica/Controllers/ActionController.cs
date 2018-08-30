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
            ViewBag.Tittle = "LOGIN";
            return View();
        }

        public ActionResult Registro()
        {
            return this.View();
        }
    }
}