using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;

/// <summary>
/// OrderList 的摘要说明
/// </summary>
public class OrderDetail
{
    public string OrderDetailId { get; set; }
    public string OrderId { get; set; }
    public string Name { get; set; }
    public Decimal Price { get; set; }
    public int Quantity { get; set; }
    public OrderDetail(string orderId, string name, decimal price, int quantity)
    {
        this.OrderId = orderId;
        this.Name = name;
        this.Price = price;
        this.Quantity = quantity;
        
    }
}