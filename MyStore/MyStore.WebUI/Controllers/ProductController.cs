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
    public class ProductController : Controller
    {
        // GET: Product
        private IProductsReopository repository;
        public int PageSize = 2;

        public ProductController(IProductsReopository productRepository)
        {
            this.repository = productRepository;
        }
        public ActionResult List(int categoryId = 0, int page = 1)
        {
            IQueryable<Product> productslist = repository.Products;
            if (categoryId > 0)
            {
                productslist = repository.Products.Where(p => p.CategoryId == categoryId);
            }

            ProductsListViewModel viewModel = new ProductsListViewModel
            {
                Products = productslist.OrderBy(p => p.Id)
                     .Skip((page - 1) * PageSize)
                     .Take(PageSize),
                pagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = productslist.Count()
                },
                CurrentCategoryid = categoryId
            };
            return View(viewModel);
        }
    }
}