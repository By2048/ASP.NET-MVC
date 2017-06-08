using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyStore.Domain.Abstract;
using MyStore.Domain.Concrete;

namespace MyStore.WebUI.Controllers
{
    public class NavController : Controller
    {
        private IProductsReopository repository;

        public NavController(IProductsReopository productRepository)
        {
            this.repository = productRepository;
        }
        public PartialViewResult Menu(int categoryId = 0)
        {
            ViewBag.CurrentCategoryId = categoryId;
            IEnumerable<Category> categories = repository.Categories.ToList();
            return PartialView(categories);
        }

    }
}