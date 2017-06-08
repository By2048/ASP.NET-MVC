using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace MyStore.Domain.Concrete
{
    public class EmailSettings
    {
        public string MailToAddress = ConfigurationManager.AppSettings["MailToAddress"];
        public string MialFromAddress = ConfigurationManager.AppSettings["MailFromAddress"];
        public bool UseSsl = bool.Parse(ConfigurationManager.AppSettings["UseSsl"] ?? "true");
        public string Username = ConfigurationManager.AppSettings["Username"];
        public string Password = ConfigurationManager.AppSettings["Password"];
        public string ServerName = ConfigurationManager.AppSettings["ServerName"];
        public int ServerPort = int.Parse(ConfigurationManager.AppSettings["ServerPort"] ?? "587");
    }
}
