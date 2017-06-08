using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SSLS.Domain.Abstract;
using SSLS.Domain.Concrete;
using SSLS.WebUI.Models;

namespace SSLS.WebUI.Controllers
{
    public class BookController : Controller
    {
        private IBookRepository repository;
        public int pagesize = 6;
        public BookController(IBookRepository bookRepository)
        {
            this.repository = bookRepository;
        }
        public ActionResult List(int categoryId = 0, int page = 1, string keyWord = "")
        {
            IQueryable<Book> bookList = repository.Books;
            if (categoryId > 0)
            {
                bookList = repository.Books.Where(b => b.CategoryID == categoryId);
            }
            if (keyWord != "")
            {
                bookList = bookList.Where(b => b.Name.Contains(keyWord));
            }
            BookListViewModel viewModel = new BookListViewModel
            {
                Books = bookList.OrderBy(b => b.Id)
                                .Skip((page - 1) * pagesize)
                                .Take(pagesize),
                pagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemPerPage = pagesize,
                    TotalItems = bookList.Count()
                },
                CurrentCategoryId = categoryId,
                KeyWord = keyWord
            };
            return View(viewModel);
        }
    }
}