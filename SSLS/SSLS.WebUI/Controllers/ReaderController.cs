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
    public class ReaderController : Controller
    {
        private IBookRepository repository;
        public ReaderController(IBookRepository bookRepository )
        {
            this.repository = bookRepository;
        }

        public ActionResult Login(int? userName)
        {
            //Request.Url.Query;
            ViewBag.userName = Request.QueryString["userName"];
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                Reader reader = repository.Readers.FirstOrDefault(
                    c =>c.Name == model.Name && c.Password == model.Password);

                if (reader == null)
                {
                    ModelState.AddModelError("", "用户名|密码不正确！");
                    //return View();
                    return Redirect(returnUrl ?? Url.Action("List", "Book"));
                }
                else
                {                  
                    HttpContext.Session["Reader"] = reader;
                    return Redirect(returnUrl ?? Url.Action("List", "Book"));                                    
                }                           
            }
            else
            {
                ModelState.AddModelError("", "用户名|密码不正确！");
                return View();
            }

        }
        public ActionResult Logout()
        {
            HttpContext.Session["Reader"] = null;
            return Redirect(Url.Action("List", "Book"));
        }
        public PartialViewResult Summary(Reader reader)
        {
            return PartialView(reader);
        }


        public ViewResult MyFine()
        {
            Reader reader = (Reader)Session["Reader"];
            repository.GetFine();
            IQueryable<Fine> isFineList, noFineList;
            isFineList = repository.Fines.Where(tmp => tmp.ReaderID == reader.Id && tmp.IsPay=="1");
            noFineList=repository.Fines.Where(tmp => tmp.ReaderID == reader.Id && tmp.IsPay == "0");
            decimal sum = 0;
            foreach (var fine in noFineList)
            {
               sum += fine.FineMoney;        
            }
            ViewBag.sum = sum;
            MyFineViewModel viewModel = new MyFineViewModel
            {
                IsFines=isFineList,
                NoFines=noFineList
            };
            return View(viewModel);
        }

        public ActionResult PayFine(int Id)
        {
            Reader reader = (Reader)Session["Reader"];
            Fine fine = repository.Fines.FirstOrDefault(tmp => tmp.Id == Id);
            int readerId = reader.Id;
            repository.PayFine(Id,readerId);            
            return Redirect(Url.Action("MyFine", "Reader"));
        }
        public ActionResult ReaderInfo()
        {
            Reader reader = (Reader)Session["Reader"];
            return View(reader);
        }
        public ActionResult ChangePassword()
        {
            Reader reader = (Reader)Session["Reader"];
            ChangePasswordModel viewModel = new ChangePasswordModel
            {
                readerId=reader.Id,
                oldPassword = null,
                newPassword = null
            };
            return View(viewModel);
        }
        [HttpPost]
        public ActionResult ChangePassword(ChangePasswordModel change)
        {           
            repository.ChangePassword(change.readerId, change.oldPassword, change.newPassword);
            Session["Reader"] = null;
            return Redirect(Url.Action("List", "Book"));            
        }


        public ActionResult Recharge()
        {
            Reader reader = (Reader)Session["Reader"];
            return View(reader);
        }
        [HttpPost]
        public ActionResult Recharge(int readerId, string rechargeMoney)
        {
            if (rechargeMoney == "" || decimal.Parse(rechargeMoney) <=0)
            {
                return RedirectToAction("Recharge");
            }
            else
            {
                decimal _money = decimal.Parse(rechargeMoney);
                repository.Recharge(readerId, _money);
                Reader reader = repository.Readers.FirstOrDefault(tmp => tmp.Id == readerId);
                Session["Reader"] = reader;
                return RedirectToAction("Recharge");
            }

        }

        public ActionResult BorrowHistory()
        {
            Reader reader = (Reader)Session["Reader"];
            IQueryable<Borrow> borrowList = repository.Borrows.Where(tmp => tmp.ReaderID == reader.Id);
            return View(borrowList);
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(string name, string password, string email)
        {
            Reader reader = repository.Readers.FirstOrDefault(tmp => tmp.Name == name);
            if (reader != null)
            {
                ViewBag.msg = "此用户名已被使用";
                return View();
            }
            else
            {
                repository.Register(name, password, email);
                return RedirectToAction("Login", "Reader",new { userName=name});
            }

        }
        
    }
}