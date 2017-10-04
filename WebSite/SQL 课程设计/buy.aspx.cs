using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class buy : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ShoppingCart cart = (ShoppingCart)Session["Cart"];
        if (cart != null)
        {
            rptCartItem.DataSource = cart.CartItems;
            rptCartItem.DataBind();
            totalMoney.InnerHtml = cart.TotalMoney.ToString();
        }

        if (!(Session["User"] == null))
        {
            userName.InnerHtml = ((Customer)Session["User"]).UserName;
        }
    }
}