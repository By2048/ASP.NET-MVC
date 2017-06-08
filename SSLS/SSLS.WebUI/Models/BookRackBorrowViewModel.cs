using SSLS.Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SSLS.WebUI.Models
{
    public class BookRackBorrowViewModel
    {
        public List<Borrow> Borrows { get; set; }
    }
}