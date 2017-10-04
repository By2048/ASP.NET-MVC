using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
///CartItem 的摘要说明
/// </summary>
/// 
[Serializable]
public class CartItem
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public string ImgPath { get; set; }
    //public CartItem(int id, string name, decimal price, int quantity)
    //{
    //    this.Id = id;
    //    this.Name = name;
    //    this.Price = price;
    //    this.Quantity = quantity;
    //}
    public CartItem(int id, string name, decimal price, int quantity,string imgPath)
    {
        this.Id = id;
        this.Name = name;
        this.Price = price;
        this.Quantity = quantity;
        this.ImgPath = imgPath;
    }
}