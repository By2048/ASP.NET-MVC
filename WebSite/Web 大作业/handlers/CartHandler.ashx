<%@ WebHandler Language="C#" Class="CartHandler" %>

using System;
using System.Web;
using System.Web.SessionState;

public class CartHandler : IHttpHandler,IRequiresSessionState {

    public void ProcessRequest (HttpContext context)
    {
        context.Response.ContentType = "text/plain";
        string type = context.Request["type"];

        string id = string.Empty;
        string name = string.Empty;
        string price = string.Empty;
        string quantity = string.Empty;

        if (type.Equals("add"))
        {
            id = context.Request["id"];
            name = context.Request["name"];
            price = context.Request["price"];
            quantity = context.Request["quantity"];
            ShoppingCart cart = (ShoppingCart)context.Session["Cart"];
            if (cart== null)
            {
                cart = new ShoppingCart();
            }

            Product p = ProductFactory.GetProductById(int.Parse(id));

           // cart.AddItem(int.Parse(id),name,decimal.Parse(price),int.Parse(quantity));
            cart.AddItem(int.Parse(id),name,decimal.Parse(price),int.Parse(quantity),p.ImgPath);
            context.Session["Cart"] = cart;
            context.Response.Write(cart.GethtQuantity().ToString());
        }
        else if (type.Equals("update"))
        {
            id = context.Request["id"];
            quantity=context.Request["quantity"];
            ShoppingCart cart = (ShoppingCart)context.Session["Cart"];
            if (cart != null)
            {
                cart.UpdateItem(int.Parse(id), int.Parse(quantity));
                context.Session["Cart"] = cart;
                context.Response.Write(cart.Total.ToString());
            }
            else
            {
                context.Response.Write("error");
            }
        }
        else if (type.Equals("delate"))
        {
            id = context.Request["id"];
            ShoppingCart cart = (ShoppingCart)context.Session["Cart"];
            if (cart != null)
            {
                cart.RemoveItem(int.Parse(id));
            }
            context.Response.Write(cart.Total.ToString());
        }
        else
        {
            context.Response.Write("error");
        }

    }

    public bool IsReusable {
        get {
            return false;
        }
    }

}