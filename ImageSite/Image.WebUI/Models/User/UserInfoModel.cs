using Image.EF.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Image.WebUI.Models
{
    public class UserInfoModel
    {
        public Users User { get; set; }
        public IQueryable<Favorites> Favorites { get; set; }
    }
}