using Image.EF.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Image.WebUI.Models.Home
{
    public class TestHomeIndexModel
    {
        public PagingHelper<Folders> PageFolder { get; set; }
        public PagingHelper<Images> PageImage{ get; set; }

    }
}


