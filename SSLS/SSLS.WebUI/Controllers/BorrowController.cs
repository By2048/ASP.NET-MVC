using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SSLS.Domain.Abstract;
using SSLS.Domain.Concrete;
using SSLS.WebUI.Models;
using System.Text.RegularExpressions;

namespace SSLS.WebUI.Controllers
{
    public class BorrowController : Controller
    {
        private IBookRepository repository;
        public BorrowController(IBookRepository booktRepository)
        {
            this.repository = booktRepository;
        }
        public BookRack GetBookRack()
        {
            BookRack bookRack = (BookRack)Session["BookRack"];
            if (bookRack == null)
            {
                bookRack = new BookRack();
                Session["BookRack"] = bookRack;
            }
            return bookRack;
        }
        public RedirectToRouteResult AddToBookRack(BookRack bookrack, int id, string returnUrl)
        {
            Book book = repository.Books.FirstOrDefault(p => p.Id == id && p.Status == "在库");
            if (book != null)
            {
                bookrack.AddItem(book);
            }
            return RedirectToAction("Index", new { returnUrl });
        }
        public RedirectToRouteResult RemoveFromBookRack(BookRack bookrack, int id, string returnUrl)
        {
            Book book = repository.Books.FirstOrDefault(p => p.Id == id);
            if (book != null)
            {
                bookrack.RemoveLine(id);
            }
            return RedirectToAction("Index", new { returnUrl });
        }
        public ViewResult Index(BookRack bookrack, string returnUrl)
        {
            return View(new BookRackViewModel
            {
                BookRack = bookrack,
                ReturnUrl = returnUrl
            });
        }
        public PartialViewResult Summary(Reader reader ,BookRack bookRack, Borrow borrow)
        {

            int count = repository.Borrows.Where(tmp => tmp.ReaderID == reader.Id && tmp.ReaderReturnDate==null).Count();

            BorrowSummaryViewModel model = new BorrowSummaryViewModel
            {
                Reader=reader,
                BookRack = bookRack,
                Borrow = borrow,
                Count = count
            };
            return PartialView(model);
        }

        public ActionResult ReturnBook(int readerId, int bookId)
        {
            Reader reader = (Reader)Session["Reader"];
            repository.ReturnBook(readerId, bookId);
            return Redirect(Url.Action("Borrow", "Borrow"));
        }

        public ActionResult Borrow(Reader reader, BookRack bookRack)
        {
            bookRack = (BookRack)Session["BookRack"];
            IQueryable<Reader> readers = repository.Readers;
            if (reader.Id == 0)
            {
                return Redirect(Url.Action("Login", "Reader"));
            }
            else
            {
                repository.SaveRack(bookRack, reader);
                IQueryable<Borrow> borrowList = repository.Borrows.Where(tmp => tmp.ReaderID == reader.Id);
                BorrowListViewModel model = new BorrowListViewModel
                {
                    Borrow = borrowList
                };
                return View(model);
            }
        }

        public ActionResult Checkout(BookRack bockRack, string ids)
        {
            //ids = ids.Substring(0, ids.Length - 1);
            string[] allId = Regex.Split(ids, "b", RegexOptions.IgnoreCase);
            int[] bids = new int[100];
            for (int i = 1; i < allId.Length - 1; i++)
            {
                bids[i - 1] = int.Parse(allId[i]);
            }
            BrrowIndexViewModel biv = new BrrowIndexViewModel();
            BookRack bookRack = new BookRack();
            for (int i = 0; i < 100; i++)
            {
                if (bids[i] != 0)
                {
                    int id = bids[i];
                    Book book = repository.Books.FirstOrDefault(p => p.Id == id);
                    bookRack.AddItem(book);
                }
            }
            Session["BookRack"] = bookRack;
            return View(new BrrowIndexViewModel
            {
                BookRack = bookRack
            });

        }
        public ActionResult BookRackBorrow(BookRack bookRack, Reader reader)
        {
            bookRack = (BookRack)Session["BookRack"];
            if (reader.Id == 0)
            {
                return Redirect(Url.Action("Login", "Reader"));
            }
            else
            {
                repository.SaveRack(bookRack, reader);
                //List<Borrow> borrowlist = repository.BorrowsList;
                List<Borrow> borrowlist = repository.Borrows.Where(e => e.ReaderID == reader.Id).ToList();
                BookRackBorrowViewModel viewModel = new BookRackBorrowViewModel
                {
                    Borrows = borrowlist
                };
                bookRack.Clear();
                Session["BookRack"] = null;
                return View(viewModel);
            }


        }

        public ActionResult RenewBook(int readerId, int bookId)
        {
            Reader reader = (Reader)Session["Reader"];
            repository.RenewBook(readerId, bookId);
            return Redirect(Url.Action("Borrow", "Borrow"));
        }
        

    }
}