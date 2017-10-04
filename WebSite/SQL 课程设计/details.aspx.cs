using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class details : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string id = Request.QueryString["id"];
        if (id == null)
        {
            Response.Redirect("index.aspx");
        }
        Product p = ProductFactory.GetProductById(int.Parse(id));
        productName.InnerHtml = p.Name;
        productPrice.InnerHtml =p.Price.ToString();
        bigImg.Src = p.ImgPath.ToString();
        ShoppingCart cart = (ShoppingCart)Session["Cart"];
        if (cart != null)
        {
            cartNum.InnerHtml = cart.GethtQuantity().ToString();
        }

        userName.InnerHtml = "用户";
        if (!(Session["User"] == null))
        {
            userName.InnerHtml = ((Customer)Session["User"]).UserName;
        }
    }
}