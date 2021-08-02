using SistemaWebEmpleados.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaWebEmpleados.Controllers
{
    public class EmpleadoController : Controller

    {
        EmpleadoDbContext context = new EmpleadoDbContext();


        // GET: Empleado
        public ActionResult Index()
        {
            var empleados = context.Empleados.ToList();
            return View(empleados);
        }

        public ActionResult Detail(int id)
        {
            var empleado = context.Empleados.Find(id);
            if (empleado != null)
            {
                return View("Detail", empleado);
            }
            else
            {
                return HttpNotFound();
            }
        }
    }
}