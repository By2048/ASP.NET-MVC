using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SSLS.Domain.Concrete;

namespace SSLS.WebUI.Models
{
    public class ChangePasswordModel
    {
        public int readerId { get; set; }
        public string oldPassword { get; set; }
        public string newPassword { get; set; }
    }
}