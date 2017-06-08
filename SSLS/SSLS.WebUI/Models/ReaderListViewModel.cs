using SSLS.Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace SSLS.WebUI.Models
{
    public class ReaderListViewModel
    {
        public IEnumerable<Reader> Readers { get; set; }
        public PagingInfo pagingInfo { get; set; }      
    }
}