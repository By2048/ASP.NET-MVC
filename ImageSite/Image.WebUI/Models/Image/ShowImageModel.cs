using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Image.EF.Concrete;
using PagedList;

namespace Image.WebUI.Models
{
    public class ShowImageModel
    {
        public IPagedList<Images> PagedListImage { get; set; }


    }
}