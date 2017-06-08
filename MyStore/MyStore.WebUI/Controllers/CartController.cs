using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyStore.Domain.Abstract;
using MyStore.Domain.Concrete;
using MyStore.WebUI.Models;

namespace MyStore.WebUI.Controllers
{
    public class CartController : Controller
    {
        private IProductsReopository repository;
        private IOrderProcessor orderProcessor;
        public CartController(IProductsReopository productRepository, IOrderProcessor proc)
        {
            this.repository = productRepository;
            this.orderProcessor = proc;
        }
        private Cart GetCart()
        {
            Cart cart = (Cart)Session["Cart"];
            if (cart == null)
            {
                cart = new Cart();
                Session["Cart"] = cart;
            }
            return cart;
        }
        public RedirectToRouteResult AddToCart(Cart cart,int id, string returnUrl)
        {
            Product product = repository.Products.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                cart.AddItem(product, 1);
            }
            return RedirectToAction("Index", new { returnUrl });
        }
        public RedirectToRouteResult RemoveFromCart(Cart cart, int id, string returnUrl)
        {
            Product product = repository.Products.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                GetCart().RemoveLine(product);
            }
            return RedirectToAction("Index", new { returnUrl });
        }
        public ViewResult Index(Cart cart, string returnUrl)
        {
            return View(new CartIndexViewModel
            {
                Cart = GetCart(),
                ReturnUrl = returnUrl
            });
        }
        public PartialViewResult Summary(Cart cart)
        {
            return PartialView(cart);
        }
        public ActionResult Checkout()
        {
            return View(new ShippingAddress());
        }
        [HttpPost]
        public ActionResult Checkout(Cart cart, ShippingAddress shippingAddress, Customer customer)
        {
            if (cart.Lines.Count() == 0)
            {
                ModelState.AddModelError("", "抱歉，购物车是空的，无法结算!");
            }
            if (ModelState.IsValid)
            {
                if (customer.Id == 0)
                {
                    ModelState.AddModelError("", "抱歉，请先登录！");
                }
                orderProcessor.ProcessOrder(cart, shippingAddress, customer);
                cart.Clear();
                return View("Completed");
            }
            else
            {
                return View(new ShippingAddress());
            }
        }
    }
}