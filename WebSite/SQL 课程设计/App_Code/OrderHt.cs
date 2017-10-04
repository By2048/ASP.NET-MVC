using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;

/// <summary>
/// OrderHt 的摘要说明
/// </summary>
public class OrderHt
{
    public Hashtable htOrder = new Hashtable();
    //public void addOrder(string orderId, DateTime time, string userid, string recipient, string address, string phone, string total)
    //{
    //    htOrder.Add(orderId, new Order(orderId, time, userid, recipient, address, phone, total));
    //}
    public void addOrder(string orderId, DateTime time, string userid, string recipient, string address, string phone, string total,string imgpath)
    {
        htOrder.Add(orderId, new Order(orderId, time, userid, recipient, address, phone, total,imgpath));
    }
    public ICollection OrderItems
    {
        get { return htOrder.Values; }
    }
    public OrderHt()
    {
        //
        // TODO: 在此处添加构造函数逻辑
        //
    }
}