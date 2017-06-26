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


        public PartialViewResult TestMenu(int folderPage = 1,int imagePage=1,int folderId=0, string keyWord = "")
        {
            //keyWord = "ROSI写真情趣系列 蜜桃臀配丁字裤这个角度简直不敢直视";
            IQueryable<Folders> folders = from folder in foldersReopository.Folders
                                          orderby folder.CreateDate descending
                                          select folder;
            if (keyWord != "")
                folders = folders.Where(tmp => tmp.Name.Contains(keyWord));

            if (folderId == 0)
                HomeIndexModel.FolderId= folders.First().Id;

            PagingHelper<Folders> pageFolder = new PagingHelper<Folders>(10, folders);
            pageFolder.PageIndex = folderPage;

            HomeIndexModel.PageFolder = pageFolder;
            HomeIndexModel.KeyWord = keyWord;


            return PartialView();
        }



    }
}