using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Image.WebUI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            //routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // routes.MapRoute(
            //     null,
            //     "",
            //     new { Controller = "Image", Action = "Index", folderPage = 1, folderId = 1, imagePage = 1 }
            // );

            // routes.MapRoute(
            //     null,
            //     "imagePage{imagePage}",
            //     new { Controller = "Image", Action = "Index", folderPage = 1, folderId = 1 },
            //     new { imagePage = @"\d+" }
            // );

            // routes.MapRoute(
            //     null,
            //     "folderId{folderId}",
            //     new { Controller = "Image", Action = "Index", folderPage = 1, imagePage = 1 },
            //     new { folderId = @"\d+" }
            // );

            // routes.MapRoute(
            //    null,
            //    "folderPage{folderPage}",
            //    new { Controller = "Image", Action = "Index", fodlerId = 1, imagePage = 1 },
            //    new { folderPage = @"\d+" }
            //);

            // routes.MapRoute(
            //    null,
            //    "folderPage{folderPage}/folderId{folderId}",
            //    new { Controller = "Image", Action = "Index", imagePage = 1 },
            //    new { folderPage = @"\d+", folderId = @"\d+" }
            //);

            //routes.MapRoute(
            //    null,
            //    "folderPage{folderPage}/folderId{folderId}/imagePage{imagePage}",
            //    new { Controller = "Home", Action = "Index" },
            //    new { folderPage = @"\d+", folderId = @"\d+", imagePage = @"\d+" }
            //);
            
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

        }
    }
}
