using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SSLS.WebUI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            //1
            routes.MapRoute(
                null,
                "",
                new { Controller = "Book", Action = "List", categoryId = 0, page = 1, key = "" }
                );
            //2
            routes.MapRoute(
               null,
               "page{page}",
               new { Controller = "Book", Action = "List", categoryId = 0, key = "" },
               new { page = @"\d+" }
               );
            //3
            routes.MapRoute(
               null,
               "cid{categoryId}",
               new { Controller = "Book", Action = "List", page = 1, key = "" },
               new { categoryId = @"\d+" }
               );
            //4
            routes.MapRoute(
               null,
               "key{key}",
               new { Controller = "Book", Action = "List", categoryId = 0, page = 1 }
               );
            //5
            routes.MapRoute(
                null,
                "cid{categoryId}/page{page}",
                new { Controller = "Book", Action = "List", key = "" },
                new { categoryId = @"\d+", page = @"\d+" }
                );
            //6
            routes.MapRoute(
               null,
               "cid{categoryId}/key{key}",
               new { Controller = "Book", Action = "List", page = 1 },
               new { categoryId = @"\d+" }
               );
            //7
            routes.MapRoute(
               null,
               "page{page}/key{key}",
               new { Controller = "Book", Action = "List", categoryId = 0 },
               new { page = @"\d+" }
               );
            //8
            routes.MapRoute(
               null,
               "cid{categoryId}/page{page}/key{key}",
               new { Controller = "Book", Action = "List" },
               new { categoryId = @"\d+", page = @"\d+" }
               );

            routes.MapRoute(
                null,
                "page{page}",
                new { Controller = "Book", Action = "List" }
                );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Book", action = "List", id = UrlParameter.Optional }
            );
        }
    }
}
