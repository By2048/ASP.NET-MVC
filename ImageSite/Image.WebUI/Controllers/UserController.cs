using Image.EF.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Image.WebUI.Models;
using System.Web.Security;
using Image.EF.Concrete;

namespace Image.WebUI.Controllers
{
    public class UserController : Controller
    {
        private IUsersReopository usersReopository;
        private IFavoritesReopository favoritesReopository;
        public UserController(IUsersReopository usersReopository, IFavoritesReopository favoritesReopository)
        {
            this.usersReopository = usersReopository;
            this.favoritesReopository = favoritesReopository;
        }

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(UserLoginModel model)
        {
            if (ModelState.IsValid)
            {
                Users user = usersReopository.Login(model.UserName, model.PassWord);
                if (user != null)
                {
                    HttpCookie cookie = new HttpCookie("UserInfo");
                    cookie["Id"] = user.Id.ToString();
                    cookie["UserName"] = user.UserName;
                    cookie["PassWord"] = user.PassWord;
                    cookie["Email"] = user.Email;
                    cookie["UserType"] = user.UserType;
                    cookie["Balance"] = user.Balance.ToString();
                    cookie["BrowseNum"] = user.BrowseNum.ToString();
                    cookie["CreateDate"] = user.CreateDate.ToString();
                    cookie["Information"] = user.Information;
                    Response.Cookies.Add(cookie);

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", " 用户名或密码不正确 ！");
                    return View();
                }
            }
            else
            {
                return View();
            }
        }

        public PartialViewResult Summary()
        {
            HttpCookie cookie = HttpContext.Request.Cookies.Get("UserInfo");
            Users user = new Users();
            if (cookie != null)
            {
                user.Id = int.Parse(cookie.Values["Id"]);
                user.UserName = cookie.Values["UserName"];
                user.PassWord = cookie.Values["PassWord"];
                user.Email = cookie.Values["Email"];
                user.UserType = cookie.Values["UserType"];
                user.Balance = decimal.Parse(cookie.Values["Balance"]);
                user.BrowseNum = int.Parse(cookie.Values["BrowseNum"]);
                string date = cookie.Values["CreateDate"];
                //user.CreateDate = Convert.ToDateTime(date.Substring(0, 10) + date.Substring(14));
                user.CreateDate = Convert.ToDateTime(date.Substring(0, 10));
                user.Information = cookie.Values["Information"];
            }
            else
            {
                cookie = HttpContext.Request.Cookies["UserInfo"];
            }
            return PartialView(user);

        }

        public ActionResult UserInfo()
        {
            HttpCookie cookie = HttpContext.Request.Cookies.Get("UserInfo");
            int userId = int.Parse(cookie.Values["Id"]);

            Users user = usersReopository.Users.FirstOrDefault(tmp => tmp.Id == userId);
            IQueryable<Favorites> favorites = favoritesReopository.Favorites.Where(tmp => tmp.UserId == user.Id);

            
            UserInfoModel viewModel = new UserInfoModel
            {
                User = user,
                Favorites = favorites
            };
            return View(viewModel);
        }
                

    }
}
