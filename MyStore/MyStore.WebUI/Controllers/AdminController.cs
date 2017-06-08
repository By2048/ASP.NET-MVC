using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyStore.Domain.Abstract;
using MyStore.Domain.Concrete;
using System.IO;
using MyStore.WebUI.Infrastructure;

namespace MyStore.WebUI.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private IProductsReopository repository;
        public AdminController(IProductsReopository productRepository)
        {
            this.repository = productRepository;
        }
        // GET: Admin
        public ActionResult Index()
        {
            return View(repository.Products.ToList());
        }
        public ActionResult Edit(int id)
        {
            Product product = repository.Products.FirstOrDefault(p => p.Id == id);
            ViewBag.CategoryList = Utils.GetCategorySelectList(repository);
            return View(product);
        }
        [HttpPost]
        public ActionResult Edit(Product product, HttpPostedFileBase file)
        {
            string imageFileName = string.Empty;

            if (ModelState.IsValid)
            {
                if (file != null)
                {
                    try
                    {
                        imageFileName = Utils.GetImageSaveNamea(file.FileName);
                        string savePathAndName = string.Format("{0}\\{1}", Server.MapPath("..\\Images"), imageFileName);
                        file.SaveAs(savePathAndName);
                        product.ImageUrl = string.Format("..\\Images\\{0}", imageFileName);
                    }
                    catch
                    {
                        ModelState.AddModelError("", "图片保存失败!");
                    }
                }
                repository.SaveProduct(product);
                TempData["msg"] = string.Format("{0},保存成功", product.Name);
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.CategoryList = Utils.GetCategorySelectList(repository);
                return View(product);
            }
        }
        public ActionResult Create()
        {
            ViewBag.CategoryList = Utils.GetCategorySelectList(repository);
            return View("Edit", new Product());
        }


        [HttpPost]
        public ActionResult Delete(int id)
        {
            Product deleteProduct = repository.DeleteProduct(id);
            if (deleteProduct != null)
            {
                TempData["msg"] = string.Format("“{0}”产品信息删除成功！", deleteProduct.Name);
            }
            return RedirectToAction("Index");
        }
        public ActionResult CategoryManage()
        {
            return View(repository.Categories.ToList());
        }
        public ActionResult CategoryEdit(int id)
        {
            Category category = repository.Categories.FirstOrDefault(c => c.Id == id);
            return View(category);
        }
        [HttpPost]
        public ActionResult CategoryEdit(Category category)
        {
            if (ModelState.IsValid)
            {
                repository.SaveCategory(category);
                TempData["msg"] = string.Format("{0},保存成功", category.Name);
                return RedirectToAction("CategoryManage");
            }
            else
            {
                return View(category);
            }
        }

        public ActionResult CategoryCreate()
        {
            Category c = new Category();
            return View("CategoryEdit", c);
        }
        [HttpPost]
        public ActionResult CategoryDelete(int id)
        {
            Category deleteCategory = repository.DeleteCategory(id);
            if (deleteCategory != null)
            {
                TempData["msg"] = string.Format("“{0}”产品信息删除成功！", deleteCategory.Name);
            }
            return RedirectToAction("CategoryManage");
        }


    }
}