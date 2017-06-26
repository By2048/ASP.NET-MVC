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
    public class ImageController : Controller
    {
        private IImagesReopository imagesReopository;
        private IFoldersReopository foldersReopository;
        public ImageController(IImagesReopository imagesReopository, IFoldersReopository foldersReopository)
        {
            this.imagesReopository = imagesReopository;
            this.foldersReopository = foldersReopository;
        }

        public int eachPageImageItem = 1;

        public PartialViewResult Index(int folderPage = 1, int imagePage = 1, int folderId = 0, string keyWord = "")
        {
            IQueryable<Folders> folders = from folder in foldersReopository.Folders
                                          orderby folder.CreateDate descending
                                          select folder;
            if (keyWord != "")
                folders = folders.Where(tmp => tmp.Name.Contains(keyWord));

            if (folderId == 0)
                folderId = folders.First().Id;

            IQueryable<Images> images = from image in imagesReopository.Images
                                        where image.FolderId == folderId
                                        orderby image.Id descending
                                        select image;
            IPagedList<Images> pagedListImage = images.ToList().ToPagedList(imagePage, eachPageImageItem);

            ImageIndexModel viewModel = new ImageIndexModel
            {
                PagedListImage = pagedListImage,
                KeyWord= keyWord
            };

            ViewBag.FolderPage = folderPage;
            ViewBag.FolderId = folderId;
            ViewBag.ImagePage = imagePage;
            ViewBag.KeyWord = keyWord;

            return PartialView(viewModel);
        }

        public PartialViewResult TestIndex(int folderPage = 1, int imagePage = 1, int folderId = 0,string keyWord="")
        {
            IQueryable<Folders> folders = from folder in foldersReopository.Folders
                                          orderby folder.CreateDate descending
                                          select folder;

            if (keyWord != "")
                folders = folders.Where(tmp => tmp.Name.Contains(keyWord));

            if (folderId == 0)
                folderId = folders.First().Id;

            IQueryable<Images> images = from image in imagesReopository.Images
                                        where image.FolderId == folderId
                                        orderby image.Id descending
                                        select image;            

            PagingHelper<Images> pageImage= new PagingHelper<Images>(10, images);
            pageImage.PageIndex = imagePage;

            HomeIndexModel.PageImage = pageImage;
            HomeIndexModel.KeyWord = keyWord;

            return PartialView();
        }



        public PartialViewResult ShowImage(int folderId, int imagePage=1)
        {
            int eachPageImageItem = 1;

            IQueryable<Images> images = from image in imagesReopository.Images
                                        where image.FolderId == folderId
                                        orderby image.Id descending
                                        select image;
            IPagedList<Images> pagedListImage = images.ToList().ToPagedList(imagePage, eachPageImageItem);
            ShowImageModel viewModel = new ShowImageModel
            {
                PagedListImage = pagedListImage,
            };
            ViewBag.FolderId = folderId;
            ViewBag.ImagePage = imagePage;
            return PartialView(viewModel);
        }


    }
}