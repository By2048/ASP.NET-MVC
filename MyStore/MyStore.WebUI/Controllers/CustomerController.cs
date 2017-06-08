using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyStore.Domain.Concrete;
using MyStore.WebUI.Models;
using MyStore.Domain.Abstract;

namespace MyStore.WebUI.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        private IProductsReopository repository;
        public CustomerController(IProductsReopository productRepository)
        {
            this.repository = productRepository;
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
                Customer customerEntry = repository.Customers.FirstOrDefault(c =>
                                                  c.UserName == model.UserName &&
                                                  c.Password == model.Password);
                if (customerEntry != null)
                {
                    HttpContext.Session["Customer"] = customerEntry;
                    return Redirect(returnUrl ?? Url.Action("List", "Product"));
                }
                else
                {
                    ModelState.AddModelError("", "用户名密码不正确！");
                    return View();
                }
            }
            else
            {
                return View();
            }

        }
        public ActionResult Logout()
        {
            HttpContext.Session["Customer"] = null;
            return Redirect(Url.Action("List", "Product"));

        }
        public PartialViewResult Summary(Customer customer)
        {
            return PartialView(customer);
        }
    }
}