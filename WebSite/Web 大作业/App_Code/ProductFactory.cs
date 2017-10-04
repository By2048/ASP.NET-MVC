using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
///ProductFactory 的摘要说明
/// </summary>
public class ProductFactory
{
    private static List<Product> productsList;
    private static List<Product> productsListNew;


    private static List<Product> productsList1;
    private static List<Product> productsList2;
    private static List<Product> productsList3;

    public static List<Product> GetProductList1()
    {
        productsList1 = new List<Product>();
        GetProductListNew();
        Product p;

        p = productsListNew[0];        
        productsList1.Add(p);

        p = productsListNew[1];
        productsList1.Add(p);

        p = productsListNew[2];
        productsList1.Add(p);

        p = productsListNew[3];
        productsList1.Add(p);


        return productsList1;
    }

    public static List<Product> GetProductList2()
    {
        productsList2 = new List<Product>();
        GetProductListNew();
        Product p;

        p = productsListNew[4];
        productsList2.Add(p);

        p = productsListNew[5];
        productsList2.Add(p);

        p = productsListNew[6];
        productsList2.Add(p);

        p = productsListNew[7];
        productsList2.Add(p);

        return productsList2;
    }

    public static List<Product> GetProductList3()
    {
        productsList3 = new List<Product>();
        GetProductListNew();
        Product p;

        p = productsListNew[8];
        productsList3.Add(p);

        p = productsListNew[9];
        productsList3.Add(p);

        p = productsListNew[10];
        productsList3.Add(p);

        p = productsListNew[11];
        productsList3.Add(p);

        return productsList3;
    }



    public static List<Product> GetProductList()
    {
        productsList = new List<Product>();


        Product p = new Product(1, 10, 1, "Name 1", 100, "***", "images/pic1.jpg");
        productsList.Add(p);
        p = new Product(2, 10, 2, "Name 2", 200, "***", "images/pic2.jpg");
        productsList.Add(p);
        p = new Product(3, 10, 3, "Name 3", 300, "***", "images/pic3.jpg");
        productsList.Add(p);
        p = new Product(4, 10, 4, "Name 4", 400, "***", "images/pic4.jpg");
        productsList.Add(p);


        return productsList;
    }


    public static List<Product> GetProductListNew()
    {
        productsListNew = new List<Product>();

        Product p;

        p = new Product(1, 1, 1, "Name 1", 100, "***", "images/w1.jpg");
        productsListNew.Add(p);
        p = new Product(2, 1, 2, "Name 2", 200, "***", "images/w2.jpg");
        productsListNew.Add(p);
        p = new Product(3, 1, 3, "Name 3", 300, "***", "images/w3.jpg");
        productsListNew.Add(p);
        p = new Product(4, 1, 4, "Name 4", 400, "***", "images/w4.jpg");
        productsListNew.Add(p);

        p = new Product(5, 2, 5, "Name 5", 100, "***", "images/w5.jpg");
        productsListNew.Add(p);
        p = new Product(6, 2, 6, "Name 6", 200, "***", "images/w6.jpg");
        productsListNew.Add(p);
        p = new Product(7, 2, 7, "Name 7", 300, "***", "images/w7.jpg");
        productsListNew.Add(p);
        p = new Product(8, 2, 8, "Name 8", 400, "***", "images/w8.jpg");
        productsListNew.Add(p);


        p = new Product(9, 3, 9, "Name 9", 100, "***", "images/w9.jpg");
        productsListNew.Add(p);
        p = new Product(10, 3, 10, "Name 10", 200, "***", "images/w10.jpg");
        productsListNew.Add(p);
        p = new Product(11, 3, 11, "Name 11", 300, "***", "images/w11.jpg");
        productsListNew.Add(p);
        p = new Product(12, 3, 12, "Name 12", 400, "***", "images/w12.jpg");
        productsListNew.Add(p);


        return productsListNew;
    }


    public static Product GetProductById(int id)
    {
        for (int i = 0; i < productsList.Count; i++)
        {
            if (productsList[i].Id == id)
                return productsList[i];
        }
        return null;
    }

    public static List<Product> GetProductBySCId(int scid)
    {
        List<Product> list = new List<Product>();
        foreach (Product p in productsListNew)
        {
            if (scid == p.SmallTypeId)
                list.Add(p);
        }
        return list;
    }

    public static List<Product> GetProductByCId(int cid)
    {
        List<Product> list = new List<Product>();
        foreach (Product p in productsList)
        {
            if (cid == p.TypeId)
                list.Add(p);
        }
        return list;
    }

}