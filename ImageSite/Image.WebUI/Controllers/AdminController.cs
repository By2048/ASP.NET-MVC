using Image.EF.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Image.WebUI.Models;
using System.Web.Security;
using Image.EF.Concrete;
using Image.EF;

namespace Image.WebUI.Controllers
{
    public class AdminController : Controller
    {
        private IUsersReopository usersReopository;
        private IFoldersReopository foldersReopository;
        private IImagesReopository imagesReopository;


        public AdminController(IUsersReopository usersReopository,
            IFoldersReopository foldersReopository,
            IImagesReopository imagesReopository)
        {
            this.usersReopository = usersReopository;
            this.foldersReopository = foldersReopository;
            this.imagesReopository = imagesReopository;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Folders()
        {
            IEnumerable<Folders> folders = foldersReopository.Folders;
            return View(folders);
        }


    }
}