using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyStore.Domain.Concrete;
using MyStore.Domain.Abstract;

namespace MyStore.WebUI.Models
{
    public class CartIndexViewModel
    {
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }
    }
}