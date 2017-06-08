using SSLS.Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SSLS.WebUI.Models
{
    public class BrrowIndexViewModel
    {
        public BookRack BookRack { get; set; }

        public string ReturnUrl { get; set; }
    }
}