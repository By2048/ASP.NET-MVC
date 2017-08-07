using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Image.EF.Abstract;
using Image.EF.Concrete;
using Image.WebUI.Models;
using PagedList;
using Image.WebUI.Models.Home;
using Image.EF;

namespace Image.WebUI.Controllers
{
    public class NavController : Controller
    {
        private IFoldersReopository foldersReopository;
        private IImagesReopository imagesReopository;
        private IFavoritesReopository favoritesReopository;
        public NavController(IFoldersReopository foldersReopository, IImagesReopository imagesReopository, IFavoritesReopository favoritesReopository)
        {
            this.foldersReopository = foldersReopository;
            this.imagesReopository = imagesReopository;
            this.favoritesReopository = favoritesReopository;
        }

        public PartialViewResult Menu(int folderPage = 1, int? folderId = 0, string keyWord = "")
        {
            IQueryable<Folders> folders = from folder in foldersReopository.Folders
                                          orderby folder.CreateDate descending
                                          select folder;

            if (keyWord != "")
                folders = folders.Where(tmp => tmp.Name.Contains(keyWord));
            HomeIndexModel.KeyWord = keyWord;


            PagingHelper<Folders> pageFolder = new PagingHelper<Folders>(18, folders);
            pageFolder.PageIndex = folderPage;
            HomeIndexModel.PageFolder = pageFolder;


            if (folderId == 0)
                folderId = folders.First().Id;   
            HomeIndexModel.FolderId = (int)folderId;
            
            IQueryable<Images> images = from image in imagesReopository.Images
                                        where image.FolderId == folderId
                                        orderby image.Id descending
                                        select image;
            PagingHelper<Images> pageImage = new PagingHelper<Images>(1, images);
            HomeIndexModel.PageImage = pageImage;
            

            return PartialView();
        }



    }
}