using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OLZ_beta.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "OLZ Una manera segura y rápida de comprar por internet.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "OLZ es una aplicación para venta de cualquier tipo de artículos.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contáctanos.";

            return View();
        }
    }
}
