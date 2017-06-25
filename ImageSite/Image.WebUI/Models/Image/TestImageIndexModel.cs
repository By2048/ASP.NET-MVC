using Image.EF.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Image.WebUI.Models.Image
{
    public class TestImageIndexModel
    {
        public PagingHelper<Images> PageImage { get; set; }
    }
}