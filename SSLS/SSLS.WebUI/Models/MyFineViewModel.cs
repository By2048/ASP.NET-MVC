using SSLS.Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SSLS.WebUI.Models
{
    public class MyFineViewModel
    {
        public IQueryable<Fine> IsFines { get; set; }
        public IQueryable<Fine> NoFines { get; set; }

    }
}