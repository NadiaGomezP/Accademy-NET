using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OperasWebSite.Data;
using OperasWebSite.Models;
using OperasWebSite.Filters;


namespace OperasWebSite.Controllers
{
    [MyActionFilter]
    [Authorize]

    public class OperaController : Controller
    {

        //declarar y crear una instancia de EF
        OperaDbContext context = new OperaDbContext();

        // GET: Opera
        //GET /Opera/Index
        public ActionResult Index()
        {
            var operas = context.Operas.ToList();

            return View(operas);
        }

        //GET: /Opera/Detail/id
        //[HttpGet]
        public ActionResult Detail(int id)
        {
            var opera = context.Operas.Find(id);
            if (opera != null) 
            {
                return View("Detail", opera);
            }
            else
            {
                return HttpNotFound();
            }
        }

        //GET /Opera/Create
        public ActionResult Create()
        {
            Opera opera = new Opera();
            return View("Create", opera);
        }

        //POST en la etiqueta form html --> /opera/create por Post
        [HttpPost]
        public ActionResult Create(Opera opera)
        {
            if (ModelState.IsValid)
            {
            context.Operas.Add(opera);
            context.SaveChanges();
            return RedirectToAction("Index");
            }
            else
            {
                return View("Create", opera);
            }
        }

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var controller = filterContext.RouteData.Values["controller"];
            var action = filterContext.RouteData.Values["action"];

            string mensaje = string.Format("OnActionExecuting - El nombre del controlador es {0}, el nombre de la accion es {1}", controller, action);

            Debug.WriteLine(mensaje, "Action filters values");
        }

        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            var controller = filterContext.RouteData.Values["controller"];
            var action = filterContext.RouteData.Values["action"];

            string mensaje = string.Format("OnActionExecuted - El nombre del controlador es {0}, el nombre de la accion es {1}", controller, action);

            Debug.WriteLine(mensaje, "Action filters values");
        }
    }
}