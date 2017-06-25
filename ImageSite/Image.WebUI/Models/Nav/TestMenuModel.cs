using Image.EF.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Image.WebUI.Models.Nav
{
    public class TestMenuModel
    {
        public PagingHelper<Folders> PageFolder { get; set; }
    }
}