using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyStore.Domain.Abstract;
using System.Net.Mail;
using System.Net;


namespace MyStore.Domain.Concrete
{
    public class EmailOrderProcessor : IOrderProcessor
    {
        private EmailSettings emailSettings;
        public EmailOrderProcessor(EmailSettings settings)
        {
            emailSettings = settings;
        }
        public void ProcessOrder(Cart cart, ShippingAddress shippingInfo, Customer customer)
        {
            SmtpClient smtp = new SmtpClient();
            using (var smtpClient = new SmtpClient())
            {
                smtpClient.EnableSsl = emailSettings.UseSsl;
                smtpClient.Host = emailSettings.ServerName;
                smtpClient.Port = emailSettings.ServerPort;
                smtpClient.UseDefaultCredentials = true;
                smtpClient.Credentials = new NetworkCredential(
                    emailSettings.Username, emailSettings.Password);
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                StringBuilder body = new StringBuilder();
                foreach (var line in cart.Lines)
                {
                    var subtotal = line.Product.Price * line.Quantity;
                    body.AppendLine(string.Format("{0}*{1}(小计：{2:c})", line.Quantity,
                                    line.Product.Name,
                                    subtotal));
                }
                body.AppendLine(string.Format("订单总金额：{0:c}", cart.ComputeTotalValue()))
                    .AppendLine("---")
                    .AppendLine("发送信息")
                    .AppendLine(string.Format("姓名：{0} 联系电话：{1}", shippingInfo.Name, shippingInfo.Phone))
                    .AppendLine(string.Format("地址：{0}{1}{2}{3}", shippingInfo.Province, shippingInfo.City, shippingInfo.District, shippingInfo.DetailAddress))
                    .AppendLine(string.Format("邮政编码：{0}", shippingInfo.Zip))
                    .AppendFormat("需要礼盒包装：{0}", shippingInfo.GiftWrap ? "是" : "否");
                MailMessage mailMessage = new MailMessage(
                                        emailSettings.MialFromAddress,
                                        emailSettings.MailToAddress,
                                        string.Format("MyStore订单 {0}", System.DateTime.Now.ToString()),
                                        body.ToString());
                mailMessage.BodyEncoding = Encoding.UTF8;
                smtpClient.Send(mailMessage);
            }
        }
    }
}
