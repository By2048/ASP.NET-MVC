using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SSLS.Domain.Concrete;

namespace SSLS.WebUI.Infrastructure.Binders
{
    public class BookRackModelBinder:IModelBinder
    {
        private const string sessionKey = "BookRack";

        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            BookRack book = null;
            if (controllerContext.HttpContext.Session != null)
            {
                book = controllerContext.HttpContext.Session[sessionKey] as BookRack;
            }
            if (book == null)
            {
                book = new BookRack();
                if (controllerContext.HttpContext.Session != null)
                {
                    controllerContext.HttpContext.Session[sessionKey] = book;
                }
            }
            return book;
        }
    }
}