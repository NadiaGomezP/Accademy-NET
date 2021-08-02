using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace OperasWebSite
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    name: "AdminLogin",
            //    url: "{controller}/{action}/{user}/{role}",
            //    defaults: new { controller = "Admin", action = "Login" });

            //routes.MapRoute(
            //    name: "SearchByTitle",
            //    url: "{controller}/{title}",
            //    defaults: new { controller = "Admin", action = "SearchByTitle" });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
