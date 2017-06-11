using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Image.EF.Concrete;
using System.Collections;
using PagedList;

namespace Image.WebUI.Models
{
    public class NavMenuModel
    {
        public IPagedList<Folders> PagedListFolder { get; set; }
        public string KeyWord { get; set; }
        public int FolderId { get; set; }
    }
}