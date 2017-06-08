using Image.EF.Concrete;
using Image.WebUI.Infrastructure.Binders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Image.WebUI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            //设置Users类，使用UserBinder进行绑定
            ModelBinders.Binders.Add(typeof(Users), new UserBinder());

        }
    }
}
