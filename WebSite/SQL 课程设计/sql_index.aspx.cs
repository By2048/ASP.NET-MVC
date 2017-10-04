using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        rptProducts.DataSource = ProductFactory.GetProductList();
        rptProducts.DataBind();

        ShoppingCart cart = (ShoppingCart)Session["Cart"];
        if (cart != null)
        {
            cartNum.InnerHtml = cart.GethtQuantity().ToString();
        }


       
        if(((User)Session["User"])!=null)
            userName.InnerHtml = ((User)Session["User"]).Name.ToString();
        else
            userName.InnerHtml = "Please Login";
        

    }
}