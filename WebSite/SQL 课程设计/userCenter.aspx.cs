using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class userCenter : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        userName.InnerHtml = "Login";
        if (!(Session["User"] == null))
        {
            userName.InnerHtml = ((Customer)Session["User"]).UserName;
            Id.InnerHtml = ((Customer)Session["User"]).UserId.ToString();
            Name.InnerHtml = ((Customer)Session["User"]).UserName;
            Balance.InnerHtml = ((Customer)Session["User"]).Balance.ToString("0.00");
            Sex.InnerHtml = ((Customer)Session["User"]).Sex;
            Phonenum.InnerHtml = ((Customer)Session["User"]).TelNo;
            Birthday.InnerHtml = ((Customer)Session["User"]).Birthday.ToString("yyyy-MM-dd");
        }
        else
        {
            Response.Redirect("login.html?returnUrl=userCenter.aspx");
        }

        //ShoppingCart cart = (ShoppingCart)Session["Cart"];
        //if (cart != null)
        //{
        //    rptCartItem.DataSource = cart.CartItems;
        //    rptCartItem.DataBind();
        //}

        if (Session["Order"] != null)
        {
            OrderHt htOrder = (OrderHt)Session["Order"];
            rptOrder.DataSource = htOrder.OrderItems;
            rptOrder.DataBind();

            OrderDetailHt htOrderDetail = (OrderDetailHt)Session["OrderDetail"];
            rptOrderDetail.DataSource = htOrderDetail.OrderDetailItems;
            rptOrderDetail.DataBind();
        }
    }
}