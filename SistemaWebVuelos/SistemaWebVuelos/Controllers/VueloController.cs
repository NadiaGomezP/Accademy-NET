using SistemaWebVuelos.Data;
using SistemaWebVuelos.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaWebVuelos.Controllers
{
    public class VueloController : Controller
    {
        VueloDbContext context = new VueloDbContext();

        public ActionResult Index()
        {
            var vuelos = context.Vuelos.ToList();
            return View(vuelos);
        }

   
        public ActionResult Detail(string Matricula)
        {
            Vuelo vuelo = (from v in context.Vuelos.ToList() where v.Matricula == Matricula select v).FirstOrDefault();

            if (vuelo != null)
            {
                return View("Detail", vuelo);
            }
            else
            {
                return HttpNotFound();
            }
        }

  
        public ActionResult Create()
        {
            Vuelo vuelo = new Vuelo();

            return View("Create", vuelo);
        }

        //POST  
        [HttpPost]
        public ActionResult Create(Vuelo vuelo)
        {
            if (ModelState.IsValid)
            {
                context.Vuelos.Add(vuelo);
                context.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                return View("Create", vuelo);
            }

        }

      
        public ActionResult Delete(int Id)
        {
            Vuelo vuelo= context.Vuelos.Find(Id);
            if (vuelo != null)
            {
                return View("Delete", vuelo);
            }
            return HttpNotFound();
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int Id)
        {

            Vuelo vuelo = context.Vuelos.Find(Id);

            context.Vuelos.Remove(vuelo);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var vuelo = context.Vuelos.Find(id);
            if (vuelo != null)
            {
                return View("Edit", vuelo);

            }
            else
            {
                return View(vuelo);
            }
        }
        [HttpPost]
        public ActionResult Edit(Vuelo vuelo)
        {
            if (vuelo != null)
            {
                context.Entry(vuelo).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");

            }
            else
            {
                return View(vuelo);
            }

        }

        public ActionResult TraerPorDestino(string destino)
        {
            var traerDestino = (from a in context.Vuelos
                                where a.Destino == destino
                                select a).ToList();
            return View("Index", traerDestino);
        }

    }
}