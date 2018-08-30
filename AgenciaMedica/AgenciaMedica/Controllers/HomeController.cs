using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AgenciaMedica.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Informacion de la Empresa Medica.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contacto de la Pagina.";

            return View();
        }
    }
}