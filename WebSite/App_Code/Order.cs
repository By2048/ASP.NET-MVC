using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Order 的摘要说明
/// </summary>
public class Order
{

    public string OrderId { get; set; }
    public DateTime OrderDate { get; set; }
    public string UserId { get; set; }
    public string Recipient { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    public string State { get; set; }
    public string Total { get; set; }
    public string ImgPath { get; set; }

    public Order(string orderId, DateTime time, string userid, string recipient, string address, string phone, string total, string imgpath)
    {
        this.OrderId = orderId;
        this.OrderDate = time;
        this.UserId = userid;
        this.Recipient = recipient;
        this.Address = address;
        this.Phone = phone;
        this.Total = total;
        this.ImgPath = imgpath;
    }
    //public Order(string orderId, DateTime time, string userid, string recipient, string address, string phone, string total)
    //{
    //    this.OrderId = orderId;
    //    this.OrderDate = time;
    //    this.UserId = userid;
    //    this.Recipient = recipient;
    //    this.Address = address;
    //    this.Phone = phone;
    //    this.Total = total;
    //}


}