using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Image.EF.Abstract;
using Image.EF.Concrete;
using Image.WebUI.Models;
using PagedList;

namespace Image.WebUI.Controllers
{
    public class NavController : Controller
    {
        private IFoldersReopository foldersReopository;
        private IFavoritesReopository favoritesReopository;
        public NavController(IFoldersReopository foldersReopository, IFavoritesReopository favoritesReopository)
        {
            this.foldersReopository = foldersReopository;
            this.favoritesReopository = favoritesReopository;
        }

        public int eachPageFolderItem = 18;
        public int totalCount = 5;

        public PartialViewResult Menu(int folderPage = 1, int imagePage = 1, int folderId = 0, string keyWord = "")
        {
            IQueryable<Folders> folders = from folder in foldersReopository.Folders
                                          orderby folder.CreateDate descending
                                          select folder;

            if (keyWord != "")
                folders = folders.Where(tmp => tmp.Name.Contains(keyWord));

            if (folderId == 0)
                folderId = folders.First().Id;

            IPagedList<Folders> pagedListFolder = folders.ToList().ToPagedList(folderPage, eachPageFolderItem);


            NavMenuModel viewModel = new NavMenuModel
            {
                PagedListFolder = pagedListFolder,
                KeyWord = keyWord,
                FolderId = folderId
            };
            
            ViewBag.FolderPage = folderPage;
            ViewBag.FolderId = folderId;
            ViewBag.ImagePage = imagePage;
            ViewBag.KeyWord = keyWord;


            return PartialView(viewModel);
        }



      

    }
}