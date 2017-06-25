using Image.EF.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Image.WebUI.Models.Home
{
    static public class HomeIndexModel
    {

        static public PagingHelper<Folders> PageFolder { get; set; }
        static public PagingHelper<Images> PageImage { get; set; }

        static public string KeyWord { get; set; }

        static public int FolderId { get; set; }


        //private GetFolderId()

        //public HomeIndexModel(PagingHelper<Folders> pageFolder, PagingHelper<Images> pageImage)
        //{
        //    PageFolder = pageFolder;
        //    PageImage = pageImage;
        //}

        //public HomeIndexModel(PagingHelper<Folders> pageFolder)
        //{
        //    PageFolder = pageFolder;
        //}

        //public HomeIndexModel(PagingHelper<Images> pageImage)
        //{
        //    PageImage = pageImage;
        //}
    }
}