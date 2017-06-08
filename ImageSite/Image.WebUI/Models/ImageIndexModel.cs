using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Image.EF.Concrete;
using System.Collections;
using PagedList;

namespace Image.WebUI.Models
{
    public class ImageIndexModel
    {
        public IPagedList<Images> PagedListImage { get; set; }
        public string KeyWord { get; set; }


    }
}