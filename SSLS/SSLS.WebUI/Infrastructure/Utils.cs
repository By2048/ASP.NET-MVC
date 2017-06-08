using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using SSLS.Domain.Abstract;
using System.Web.Mvc;

namespace SSLS.WebUI.Infrastructure
{
    public static class Utils
    {
        public static IEnumerable<SelectListItem> GetCategorySelectList(IBookRepository repository)
        {
            return repository.Categories.ToList()
                .Select(item => new SelectListItem { Value = item.Id.ToString(), Text = item.Name });
        }

    }
}