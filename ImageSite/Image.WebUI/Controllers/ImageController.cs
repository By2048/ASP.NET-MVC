using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Image.EF.Abstract;
using Image.EF.Concrete;
using Image.WebUI.Models;
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

      

        public PartialViewResult Index(int imagePage = 1)
        {           
            HomeIndexModel.PageImage.PageIndex = imagePage;
            return PartialView();
        }
        

        public PartialViewResult ShowImage(int folderId=0)
        {

            IQueryable<Images> images = from image in imagesReopository.Images
                                        where image.FolderId == folderId
                                        orderby image.Id descending
                                        select image;
            return PartialView(images);
        }


    }
}