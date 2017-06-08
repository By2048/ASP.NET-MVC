using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SSLS.Domain.Concrete;
using SSLS.WebUI.Models;
using SSLS.Domain.Abstract;
using System.Web.UI.WebControls;
using SSLS.WebUI.Infrastructure;
using System.Web.Security;


namespace SSLS.WebUI.Controllers
{
    public class AccountController : Controller
    {
        private IAdminRepository adminRepository;
        private IBookRepository bookRepository;

        public AccountController(IBookRepository booktRepository, IAdminRepository adminRepository)
        {
            this.bookRepository = booktRepository;
            this.adminRepository = adminRepository;
        }

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
               

                if (adminRepository.AdminLogin(model.Name, model.Password))
                {
                    FormsAuthentication.SetAuthCookie(model.Name, false);
                    return Redirect(returnUrl ?? Url.Action("Index", "Admin"));
                }
                else
                {
                    ModelState.AddModelError("", "用户名密码不正确!");
                    return View();
                }
            }
            else
            {
                return View();
            }

        }
    }
}