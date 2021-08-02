using OperasWebSite.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OperasWebSite.Controllers
{
    [MyActionFilter]
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.FechaHora = DateTime.Now.ToLongDateString();
            ViewData["msj"] = "Hola Bienvenido";
           
            return View("Index");
        }

        public ActionResult Privacy()
        {
            return View();
        }
    }
}