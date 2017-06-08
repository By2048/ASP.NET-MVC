using SSLS.Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SSLS.WebUI.Models
{
    public class BorrowSummaryViewModel
    {
        public Reader Reader { get; set; }
        public BookRack BookRack { get; set; }
        public Borrow Borrow { get; set; }
        public int Count { get; set; }
    }
}