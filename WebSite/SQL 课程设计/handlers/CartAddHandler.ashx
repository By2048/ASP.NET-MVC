<%@ WebHandler Language="C#" Class="CartHandler" %>

using System;
using System.Web;
using System.Web.SessionState;

public class CartHandler : IHttpHandler,IRequiresSessionState
{

    //public void ProcessRequest(HttpContext context)
    //{
    //    string id = context.Request["id"];
    //    string name = context.Request["name"];
    //    string price = context.Request["price"];
    //   // string quantity = context.Request["quantity"];

    //    ShoppingCart cart = (ShoppingCart)context.Session["ShoppingCart"];

    //    if (cart == null)
    //        cart = new ShoppingCart();
    //    cart.AddItem(int.Parse(id), name, decimal.Parse(price),1);

    //    context.Session["Cart"] = cart;
    //    context.Response.Write("OK");
    //    context.Response.Write(cart.GethtQuantity().ToString());
    //}


    public void ProcessRequest (HttpContext context) {
        int id = int.Parse(context.Request["id"]);
        if (context.Session["Cart"] == null)
        {
            context.Session["Cart"] = new ShoppingCart();
        };
        Product p = ProductFactory.GetProductById(id);
        ShoppingCart c2 = (ShoppingCart)context.Session["Cart"];
        c2.AddItem(id, p.Name, decimal.Parse(p.Price.ToString()), 1,p.ImgPath);
        context.Session["Cart"] = c2;
        context.Response.Write(c2.GethtQuantity().ToString());
    }

    //读取用户信息
    // 从session取出购物车
    // 判断购物车是否存在
    // 否-新建购物车-购物项放入购物车
    // 是-购物项放入购物车
    //购物车放回session
    //正确 return true
    //错误 return error



    public bool IsReusable
    {
        get
        {
            return false;
        }
    }

}