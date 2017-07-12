using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Image.EF.Abstract;
using Image.EF.Concrete;
using Image.WebUI.Models;
using PagedList;
using System.IO;
using Image.WebUI.Models.Home;

namespace Image.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private IImagesReopository imagesReopository;
        private IFoldersReopository foldersReopository;
        private IUsersReopository usersReopository;

        public HomeController(IImagesReopository imagesReopository, IFoldersReopository foldersReopository, IUsersReopository usersReopository)
        {
            this.imagesReopository = imagesReopository;
            this.foldersReopository = foldersReopository;
            this.usersReopository = usersReopository;
        }

        public int eachPageFolderItem = 18;
        public int eachPageImageItem = 1;

        public ActionResult _Index(int folderPage = 1, int imagePage = 1, int folderId = 0, string keyWord = "")
        {
            HttpCookie cookie = HttpContext.Request.Cookies.Get("UserInfo");

            if (cookie != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login", "User");
            }
        }


        public ActionResult Index(int? folderPage = 1, int? imagePage = 1, int? folderId = 0, string keyWord = "")
        {

            return View();
        }


        public ActionResult Upload(/*HttpPostedFileBase files*/)
        {
            var files = Request.Files;
            if (files != null && files.Count > 0)
            {
                #region  执行多个文件上传  
                for (int i = 0; i < files.Count; i++)
                {
                    HttpPostedFileBase fileitem = files[i];
                    //判定文件的大小  
                    string strExtension = Path.GetExtension(fileitem.FileName);
                    double dFileSize = fileitem.ContentLength;
                    if (dFileSize > 5242880)//1024*1024*5)  
                    {
                        return Content("<script>alert('" + fileitem.FileName + "文件大于5MB')</script>");
                    }
                    else
                    {
                        //创建文件  
                        string filePath = "../Upload/";
                        Directory.CreateDirectory(Server.MapPath(filePath));
                        //创建唯一的文件名  
                        string fileName = Guid.NewGuid().ToString();
                        string fFullDir = filePath + fileName + strExtension;
                        fileitem.SaveAs(Server.MapPath(fFullDir));
                    }
                }
                #endregion
            }
            return View();
        }

        public ActionResult Test()
        {
            return View();
        }



        public JsonResult APIGetAllFolders()
        {
            IQueryable<Folders> folders = from folder in foldersReopository.Folders
                                          orderby folder.CreateDate descending
                                          select folder;
            var folderDate = new List<Folders>();
            foreach (Folders folder in folders)
            {
                var date = new Folders
                {
                    Id = folder.Id,
                    Name = folder.Name,
                    Path = folder.Path,
                    CreateDate = folder.CreateDate,
                    ImgNum = folder.ImgNum,
                    TotalSize = folder.TotalSize
                };
                folderDate.Add(date);
            }
            return Json(folderDate, JsonRequestBehavior.AllowGet);
        }

        public JsonResult APIGetImagesByFolderId(int folderId = 0)
        {
            IQueryable<Images> images = from image in imagesReopository.Images
                                        where image.FolderId == folderId
                                        orderby image.Id descending
                                        select image;
            var imageDate = new List<Images>();
            foreach (Images image in images)
            {
                var date = new Images
                {
                    Id = image.Id,
                    FolderName = image.FolderName,
                    Name = image.Name,
                    Path = image.Path,
                    Type = image.Type,
                    Size = image.Size,
                    Width = image.Width,
                    Height = image.Height
                };
                imageDate.Add(date);
            }
            return Json(imageDate, JsonRequestBehavior.AllowGet);
            // Request http://192.168.155.1/Home/APIGetImagesByFolderId/?folderId=2
        }

        public JsonResult APIGetImagesByFolderName(string folderName = "")
        {
            IQueryable<Images> images = from image in imagesReopository.Images
                                        where image.FolderName == folderName
                                        orderby image.Id descending
                                        select image;

            var imageDate = new List<Images>();
            foreach (Images image in images)
            {
                var date = new Images
                {
                    Id = image.Id,
                    FolderName = image.FolderName,
                    Name = image.Name,
                    Path = image.Path,
                    Type = image.Type,
                    Size = image.Size,
                    Width = image.Width,
                    Height = image.Height
                };
                imageDate.Add(date);
            }
            return Json(imageDate, JsonRequestBehavior.AllowGet);
            // Request http://192.168.155.1/Home/APIGetImagesByFolderName/?folderName=洋娃娃般的少女%20清纯美女夏美酱比基尼写真萌萌哒
        }

    }
}