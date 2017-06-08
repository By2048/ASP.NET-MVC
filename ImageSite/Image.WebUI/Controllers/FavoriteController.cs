using Image.EF.Abstract;
using Image.EF.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Image.WebUI.Controllers
{
    public class FavoriteController : Controller
    {

        private IFoldersReopository foldersReopository;
        private IFavoritesReopository favoritesReopository;
        public FavoriteController(IFoldersReopository foldersReopository, IFavoritesReopository favoritesReopository)
        {
            this.foldersReopository = foldersReopository;
            this.favoritesReopository = favoritesReopository;
        }      



        [HttpPost]
        public JsonResult AddFavorites(int folderId)
        {
            HttpCookie cookie = HttpContext.Request.Cookies.Get("UserInfo");
            int userId = int.Parse(cookie.Values["Id"]);
            bool status = favoritesReopository.AddFavorites(folderId, userId);
            if (status == true)
                return Json(new { status = true });
            else
                return Json(new { status = false });
        }

        [HttpPost]
        public JsonResult IsAddFavorites(int folderId)
        {
            HttpCookie cookie = HttpContext.Request.Cookies.Get("UserInfo");
            int userId = int.Parse(cookie.Values["Id"]);
            bool isAdd = favoritesReopository.IsAddFavorites(folderId, userId);
            if (isAdd == true)
                return Json(new { status = true });
            else
                return Json(new { status = false });
        }

        [HttpPost]
        public JsonResult DelFavorites(int folderId)
        {
            HttpCookie cookie = HttpContext.Request.Cookies.Get("UserInfo");
            int userId = int.Parse(cookie.Values["Id"]);
            bool isDel = favoritesReopository.DelFavorites(folderId, userId);
            if (isDel == true)
                return Json(new { status = true });
            else
                return Json(new { status = false });
        }

        [HttpPost]
        public RedirectToRouteResult DeleteFavorites(int folderId)
        {
            HttpCookie cookie = HttpContext.Request.Cookies.Get("UserInfo");
            int userId = int.Parse(cookie.Values["Id"]);
            bool isDel = favoritesReopository.DelFavorites(folderId, userId);
            return RedirectToAction("UserInfo", "User");
        }

    }
}