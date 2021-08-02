using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OperasWebSite.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        //Get
        //Admin/Loigin/gaby/admin
        public ActionResult Login(string user, string role)
        {
            ViewBag.User = user;
            ViewBag.Role = role;

            return View();
        }


        //get
        //Admin/SearchByTitle/Profesor
        public ActionResult SearchByTitle(string title)
        {
            ViewBag.Title = title;
            return View();
        }
    }
}