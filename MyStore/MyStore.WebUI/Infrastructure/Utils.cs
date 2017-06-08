using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using MyStore.Domain.Abstract;
using System.Web.Mvc;

namespace MyStore.WebUI.Infrastructure
{
    public static class Utils
    {
        public static string GetImageSaveNamea(string rawFileName)
        {
            Random TempInt = new Random();
            byte[] result = System.Text.Encoding.Default.GetBytes(TempInt.Next().ToString());
            System.Security.Cryptography.MD5 md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] output = md5.ComputeHash(result);
            String randomString = BitConverter.ToString(output).Replace("-", "").Substring(0, 4);

            string fileExtName = Path.GetExtension(rawFileName);
            string fileName = DateTime.Now.ToString("yyyyMMddhhmmss") + randomString;
            return fileName + fileExtName;
        }
        public static IEnumerable<SelectListItem> GetCategorySelectList(IProductsReopository repository)
        {
            return repository.Categories.ToList().Select(
                c => new SelectListItem { Value = c.Id.ToString(), Text = c.Name });
        }

    }
}