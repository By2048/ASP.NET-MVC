using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;

/// <summary>
/// OrderDetailHt 的摘要说明
/// </summary>
public class OrderDetailHt
{
    public Hashtable htOrderDetail = new Hashtable();
    public void addOrderDetail(string orderId, string name, decimal price, int quantity)
    {
        htOrderDetail.Add(orderId, new OrderDetail(orderId, name, price, quantity));
    }
    public ICollection OrderDetailItems
    {
        get { return htOrderDetail.Values; }
    }
    public OrderDetailHt()
    {
        //
        // TODO: 在此处添加构造函数逻辑
        //
    }
}