using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
///Product 的摘要说明
/// </summary>
public class Product
{

    public int Id { get; set; }
    public int TypeId { get; set; }
    public int SmallTypeId { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public string Desc { get; set; }
    public string ImgPath { get; set; }

   

    //public string ImgPathLarge { get; set; }
    //public DateTime InDate { get; set; }

    public Product()
    {
    }

    public Product(int id, int typeId, int smallTypeId, string name, double price, string desc, string imgPath)
    {
        this.Id = id;
        this.TypeId = typeId;
        this.SmallTypeId = smallTypeId;
        this.Name = name;
        this.Price = price;
        this.Desc = desc;
        this.ImgPath = imgPath;
      
    }

    public Product(int id, string name, double price,  string imgPath)
    {
        this.Id = id;
        this.Name = name;
        this.Price = price;
        this.ImgPath = imgPath;
    }


}