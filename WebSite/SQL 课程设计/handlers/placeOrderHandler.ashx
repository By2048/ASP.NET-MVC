<%@ WebHandler Language="C#" Class="placeOrderHandler" %>

using System;
using System.Web;
using System.Web.SessionState;
using System.Collections.Generic;

public class placeOrderHandler : IHttpHandler, IRequiresSessionState
{
    public void ProcessRequest(HttpContext context)
    {
        string address = context.Request["address"];
        string phone = context.Request["phone"];
        string name = context.Request["name"];
        string money = context.Request["money"];
        string msg = "ok";
        if (address == "")
        {
            msg = "addressError";
        }

        else
        {
            ((Customer)context.Session["User"]).Balance -= decimal.Parse(money);
            Customer user = (Customer)context.Session["User"];
            if (context.Session["Cart"] != null)
            {
                ShoppingCart htCart = (ShoppingCart)context.Session["Cart"];
                if (context.Session["Order"] == null)
                {
                    context.Session["Order"] = new OrderHt();
                }
                OrderHt htOrder = (OrderHt)context.Session["Order"];
                if (context.Session["OrderDetail"] == null)
                {
                    context.Session["OrderDetail"] = new OrderDetailHt();
                }
                OrderDetailHt htOrderDetail = (OrderDetailHt)context.Session["OrderDetail"];
                foreach (CartItem item in htCart.CartItems)
                {
                    DateTime time = DateTime.Now;
                    string orderId = string.Format("{0:yyyy-MM-dd}", time) + "-" + string.Format("{0:D3}", item.Id);
                    htOrder.addOrder(orderId, time, user.UserId.ToString(), name, address, phone, money, item.ImgPath);
                    htOrderDetail.addOrderDetail(orderId, item.Name, decimal.Parse(item.Price.ToString()), item.Quantity);
                }
                context.Session["Cart"] = null;
            }
            else
            {
                msg = "error";
            }
        }

        context.Response.Write(msg);
    }

    public bool IsReusable
    {
        get
        {
            return false;
        }
    }

}