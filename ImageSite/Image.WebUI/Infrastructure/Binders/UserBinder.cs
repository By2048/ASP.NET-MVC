using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Image.EF.Concrete;
using Image.EF;

namespace Image.WebUI.Infrastructure.Binders
{
    public class UserBinder : IModelBinder
    {
        private const string cookieKey = "UserInfo";

        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            Users user = new Users();
            HttpCookie cookie = controllerContext.HttpContext.Request.Cookies.Get("UserInfo");

            if (cookie != null)
            {
                user.Id = int.Parse(cookie.Values["Id"]);
                user.UserName = cookie.Values["UserName"];
                user.PassWord = cookie.Values["PassWord"];
                user.Email = cookie.Values["Email"];
                user.UserType = cookie.Values["UserType"];
                user.Balance = decimal.Parse(cookie.Values["Balance"]);
                user.BrowseNum = int.Parse(cookie.Values["BrowseNum"]);
                user.CreateDate = DateTime.Parse(cookie.Values["CreateDate"]);
                user.Information = cookie.Values["Information"];
            }
            else
            {
                cookie.Name = "UserInfo";
            }
            
            return user;
        }
    }
}