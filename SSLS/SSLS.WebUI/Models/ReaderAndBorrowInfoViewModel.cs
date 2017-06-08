using SSLS.Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SSLS.WebUI.Models
{
    public class ReaderAndBorrowInfoViewModel
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Money { get; set; }
        public string Class { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public IEnumerable<Borrow> Borrows { get; set; }
    }
}