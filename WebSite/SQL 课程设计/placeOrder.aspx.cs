using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class placeOrder : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {



        userName.InnerHtml = "User";
        if (!(Session["User"] == null))
        {
            userName.InnerHtml = ((Customer)Session["User"]).UserName;
            balance.InnerHtml = ((Customer)Session["User"]).Balance.ToString("0.00");
        }
        else
        {
          Response.Redirect("login.html?returnUrl=placeOrder.aspx");
        }
        ShoppingCart cart = (ShoppingCart)Session["Cart"];
        if (cart != null)
        {
            rptCartItems.DataSource = cart.CartItems;
            rptCartItems.DataBind();
            totalMoney.InnerHtml = cart.Total.ToString();
        }
    }
}