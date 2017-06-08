using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SSLS.Domain.Abstract;
using SSLS.Domain.Concrete;
using System.IO;
using SSLS.WebUI.Infrastructure;
using SSLS.WebUI.Models;
using SSLS.Domain.Model;


namespace SSLS.WebUI.Controllers
{
    //[Authorize]
    public class AdminController : Controller
    {
        private IAdminRepository adminRepository;
        private IBookRepository bookRepository;
        public int pagesize = 9;
        public AdminController(IBookRepository booktRepository, IAdminRepository adminRepository)
        {
            this.bookRepository = booktRepository;
            this.adminRepository = adminRepository;
        }
        public ActionResult BookIndex(int page = 1)
        {
            IQueryable<Book> bookList = bookRepository.Books;
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
            };
            return View(viewModel);
        }
        public ActionResult DeleteBook(int bookId)
        {
            try
            {
                adminRepository.DeleteBook(bookId);
            }
            catch (Exception)
            {

            }
            return RedirectToAction("BookIndex");
        }
        public ActionResult DeleteCategory(int categoryId)
        {
            try
            {
                adminRepository.DeleteCategory(categoryId);
            }
            catch (Exception)
            {

            }
            return RedirectToAction("CategoryIndex");
        }
        public ActionResult AddBook()
        {
            ViewBag.CategoryList = Utils.GetCategorySelectList(bookRepository);
            return View();
        }
        [HttpPost]
        public ActionResult AddBook(Book book)
        {
            ViewBag.CategoryList = Utils.GetCategorySelectList(bookRepository);
            try
            {
                adminRepository.AddBook(book);
                return RedirectToAction("AddBook");
            }
            catch
            {
                return View(book);
            }
        }
        public ActionResult EditBook(int bookId)
        {
            Book aBook = bookRepository.Books.FirstOrDefault(item => item.Id == bookId);
            ViewBag.CategoryList = Utils.GetCategorySelectList(bookRepository);
            return View(aBook);
        }
        [HttpPost]
        public ActionResult EditBook(Book book)
        {
            try
            {
                adminRepository.EditBook(book);
                return RedirectToAction("BookIndex");
            }
            catch
            {
                ViewBag.CategoryList = Utils.GetCategorySelectList(bookRepository);
                return View(book);
            }
        }
        public ActionResult CategoryIndex()
        {
            return View(bookRepository.Categories.ToList());
        }

        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(Category category)
        {
            try
            {
                adminRepository.AddCategory(category);
                return RedirectToAction("AddCategory");
            }
            catch
            {
                return View(category);
            }
        }

        public ActionResult EditCategory(int categoryId)
        {
            Category aCategory = bookRepository.Categories.FirstOrDefault(item => item.Id == categoryId);
            return View(aCategory);
        }
        [HttpPost]
        public ActionResult EditCategory(Category category)
        {
            try
            {
                adminRepository.EditCategory(category);
                return RedirectToAction("CategoryIndex");
            }
            catch
            {
                return View(category);
            }
        }

        public ActionResult ReaderIndex(int page = 1)
        {
            IQueryable<Reader> readerList = bookRepository.Readers;
            ReaderListViewModel viewModel = new ReaderListViewModel
            {
                Readers = readerList.OrderBy(b => b.Id)
                                .Skip((page - 1) * pagesize)
                                .Take(pagesize),
                pagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemPerPage = pagesize,
                    TotalItems = readerList.Count()
                },
            };
            return View(viewModel);
        }


        public ActionResult GetReaderInfo(int readerId = 0)
        {
            IEnumerable<Borrow> viewModel = bookRepository.Borrows.Where(tmp => tmp.ReaderID == readerId);
            return View(viewModel);
        }



        public ActionResult DeleteReader(int readerId)
        {
            try
            {
                adminRepository.DeleteReader(readerId);
            }
            catch (Exception)
            {

            }
            return RedirectToAction("ReaderIndex");
        }
        public ActionResult EditReader(int readerId)
        {
            Reader aReader = bookRepository.Readers.FirstOrDefault(item => item.Id == readerId);
            return View(aReader);
        }
        [HttpPost]
        public ActionResult EditReader(Reader reader, string id, string name, string money, string _class, string email, string password)
        {
            if (reader.Class == "admin")
            {
                try
                {
                    Reader newReader = new Reader
                    {
                        Id = int.Parse(id),
                        Name = name,
                        Money = decimal.Parse(money),
                        Class = _class,
                        Email = email,
                        Password = password
                    };
                    adminRepository.SaveReader(newReader);
                    return RedirectToAction("ReaderIndex");
                }
                catch
                {
                    return RedirectToAction("ReaderIndex");
                }
            }
            else
            {
                return RedirectToAction("Login", "Reader");
            }

        }
        public ActionResult CategoryStatistics()
        {
            int Num = 5;
            List<CategoryStatistics> listStatistics = new List<CategoryStatistics>();
            listStatistics = adminRepository.GetCategoryStatistics(Num);

            List<CategoryStatisticsModel> viewModel = new List<CategoryStatisticsModel>();
            foreach (var tmp in listStatistics)
            {
                CategoryStatisticsModel cat = new CategoryStatisticsModel();
                cat.BookNum = tmp.BookNum;
                cat.CategoryName = tmp.CategoryName;
                viewModel.Add(cat);
            }
            return View(viewModel);
        }
        [HttpPost]
        public ActionResult CategoryStatistics(string youNum)
        {
            int Num = int.Parse(youNum);
            List<CategoryStatistics> listStatistics = new List<CategoryStatistics>();
            listStatistics = adminRepository.GetCategoryStatistics(Num);

            List<CategoryStatisticsModel> viewModel = new List<CategoryStatisticsModel>();
            foreach (var tmp in listStatistics)
            {
                CategoryStatisticsModel cat = new CategoryStatisticsModel();
                cat.BookNum = tmp.BookNum;
                cat.CategoryName = tmp.CategoryName;
                viewModel.Add(cat);
            }
            return View(viewModel);
        }
        public ActionResult FineStatistics()
        {
            return View();
        }
        public ActionResult BorrowAnalysis()
        {
            return View();
        }



    }
}