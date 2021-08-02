using SistemaWebAlumnos.Data;
using SistemaWebAlumnos.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaWebAlumnos.Controllers
{
    public class AlumnoController : Controller
    {
        AlumnoDbContext context = new AlumnoDbContext();

        // GET: Alumno
        // /Alumno/Index
        public ActionResult Index()
        {
            //List<Alumno> Alumnos = context.Alumnos.ToList(); lo mismo
            var alumnos = context.Alumnos.ToList();
            return View(alumnos);
        }

        //GET: /Alumno/Detail/id
        //[HttpGet] implicito no es necesario
        public ActionResult Detail(int id)
        {
            Alumno alumno = context.Alumnos.Find(id);

            if (alumno != null)
            {
                return View("Detail", alumno);
            }
            else
            {
                return HttpNotFound();
            }
        }

        //envio formulario de creacion
        //GET: /Alumno/Create
        public ActionResult Create()
        {
            Alumno alumno = new Alumno();

            return View("Create", alumno);
        }

        //POST: en la etiqueta form html 
        [HttpPost]
        public ActionResult Create(Alumno alumno)
        {
            if (ModelState.IsValid)
            {
                context.Alumnos.Add(alumno);
                context.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                //devuelve con Alumno para que lo edite 
                return View("Create", alumno);
            }

        }

        // /Empleadp/Delete/4
        public ActionResult Delete(int id)
        {
            Alumno alumno = context.Alumnos.Find(id);
            if (alumno != null)
            {
                return View("Delete", alumno);
            }
            else
            {
                return HttpNotFound();
            }

        }


        [HttpPost]
        public ActionResult Delete(Alumno alumno)
        {
            context.Entry(alumno).State = EntityState.Modified;
            context.Alumnos.Remove(alumno);
            context.SaveChanges();

            return View("Index");
        }


    }
}