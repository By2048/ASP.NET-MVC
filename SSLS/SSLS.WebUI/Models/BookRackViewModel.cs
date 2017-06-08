using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SSLS.Domain.Concrete;
using SSLS.Domain.Abstract;

namespace SSLS.WebUI.Models
{
    public class BookRackViewModel
    {
        public BookRack BookRack { get; set; }
        public string ReturnUrl { get; set; }
    }
}