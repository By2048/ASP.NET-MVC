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

    }
}