using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;


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



    //public static List<Product> GetProductList()
    //{
    //    productsList = new List<Product>();


    //    Product p = new Product(1, 10, 1, "Name 1", 100, "***", "images/pic1.jpg");
    //    productsList.Add(p);
    //    p = new Product(2, 10, 2, "Name 2", 200, "***", "images/pic2.jpg");
    //    productsList.Add(p);
    //    p = new Product(3, 10, 3, "Name 3", 300, "***", "images/pic3.jpg");
    //    productsList.Add(p);
    //    p = new Product(4, 10, 4, "Name 4", 400, "***", "images/pic4.jpg");
    //    productsList.Add(p);

    //    return productsList;
    //}

    public static List<Product> GetProductList()
    {
        productsList = new List<Product>();
        Product p;

        string cnnstr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        SqlConnection connection = new SqlConnection(cnnstr);
        string queryString = "select top 4 * from goods";
        SqlDataAdapter adapter = new SqlDataAdapter(queryString, connection);
        DataSet goods = new DataSet();
        adapter.Fill(goods);

        foreach (DataRow dr in goods.Tables[0].Rows)
        {
            p = new Product();
            p.Id = int.Parse(dr["goods_id"].ToString());
            p.Name = dr["goods_name"].ToString();
            p.Price = double.Parse(dr["goods_price"].ToString());
            p.ImgPath = dr["goods_img"].ToString();
            productsList.Add(p);
        }

        return productsList;
    }



    /*
     * 
 public static List<Product> GetProductsList()
    {
        productsList = new List<Product>();
        Product p;

        string cnnstr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        SqlConnection connection = new SqlConnection(cnnstr);
        string queryString = "SELECT * FROM products";
        SqlDataAdapter adapter = new SqlDataAdapter(queryString, connection);        
        DataSet books = new DataSet();
        adapter.Fill(books);
        foreach (DataRow dr in books.Tables[0].Rows)
        {
            p = new Product();
            p.Id = int.Parse(dr["id"].ToString());
            p.Name = dr["name"].ToString();
            p.Price = double.Parse(dr["price"].ToString());
            p.Type = dr["type"].ToString();
            p.ImgPath = dr["imgpath"].ToString();
            p.ImgPathLarge = dr["imgpathlarge"].ToString();
            p.Desc = dr["desc"].ToString();
            productsList.Add(p);
        }
        //Product p = new Product(1, "Samsung", "三星 NP905S3G", 3330, "正品Samsung/三星 NP905S3G-K07四核超薄粉色笔记本电脑 ", "ProductImage/home/1.jpg", "");
        //productsList.Add(p);
        //p = new Product(2, "Acer", "Acer宏碁 S7", 5388, "Acer宏碁 S7-391-53314G25a 超薄触屏S7-191四代I7超极本R7-572", "ProductImage/home/2.jpg", "");
        //productsList.Add(p);
        //p = new Product(3, "Apple", "Apple苹果 MacBook", 3799, "Apple苹果 MacBook Air 11寸 13寸超薄苹果笔记本电脑", "ProductImage/home/3.jpg", "");
        //productsList.Add(p);
        //p = new Product(4, "Dell", "Dell戴尔 XPS13", 5880, "Dell戴尔 XPS13系列 XPS13-9350-1808XPS15-9550M5510美行代购", "ProductImage/home/4.jpg", "");
        //productsList.Add(p);
        //p = new Product(5, "HP", "HP惠普 Envy", 4799, "HP惠普 Envy 13 d023TU I5 6200U 128G固态硬盘超薄游戏本", "ProductImage/home/5.jpg", "");
        //productsList.Add(p);
        //p = new Product(6, "Lenovo", "Lenovo联想 300", 4999, "Lenovo/联想 300S-14 I5超薄办公学生笔记本电脑独显超极本S41-70 ", "ProductImage/home/6.jpg", "");
        //productsList.Add(p);
        //p = new Product(7, "Samsung", "三星 NP110S1K", 5470, "Samsung/三星 NP110S1K-K01CN NP110S1K-K02CN超薄笔记本 ", "ProductImage/home/7.jpg", "");
        //productsList.Add(p);
        //p = new Product(8, "Lenovo", "联想U31-70", 2199, "联想U31-70 13.3英寸超薄本i3-5010U 4G 128G 2G独显 象牙白", "ProductImage/home/8.png", "");
        //productsList.Add(p);
        //p = new Product(9, "Dell", "戴尔 灵越15", 4500, "游戏本 Dell/戴尔 灵越15(7559) Ins15P-2548 15PR-2548游匣 ", "ProductImage/home/9.jpg", "");
        //productsList.Add(p);
        //p = new Product(10, "Lenovo", "联想 Yoga3", 4400, "Lenovo/联想 Yoga3 Pro Yoga3 Pro-I5Y70(L)超薄笔记本yoga2pro", "ProductImage/home/10.jpg", "");
        //productsList.Add(p);
        //p = new Product(11, "Apple", "Apple11寸", 7300, "Apple/苹果 11 英寸: MacBook Air 128GB及13英寸128/256G", "ProductImage/home/11.jpg", "");
        //productsList.Add(p);
        //p = new Product(12, "Samsung", "三星 270E5K", 2350, "15.6寸笔记本电脑Samsung/三星 270E5K 270E5K-K03 全新手提 ", "ProductImage/home/12.jpg", "");
        //productsList.Add(p);
        return productsList;
    }
     * */



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