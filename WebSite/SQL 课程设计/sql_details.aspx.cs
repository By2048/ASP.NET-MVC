using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

public partial class details : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string id = Request.QueryString["id"];
        if (id == null)
        {
            Response.Redirect("sql_index.aspx");
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

        if (((User)Session["User"]) != null)
            userName.InnerHtml = ((User)Session["User"]).Name.ToString();
        else
            userName.InnerHtml = "Please Login";
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Write("<script>alert('tetetete');</script>");

        //string cnnstr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        //SqlConnection connection = new SqlConnection(cnnstr);

        //string maxIdcmd = string.Format("select top 1 cart_id from cart order by cart_id desc");
        //SqlDataAdapter adapter = new SqlDataAdapter(maxIdcmd, connection);
        //DataSet ds = new DataSet();
        //adapter.Fill(ds);

        //int theId = int.Parse(ds.Tables[0].Rows[0].ItemArray[0].ToString());
        //Response.Write(theId);

        //string insertcmd = string.Format("insert into goods (goods_id,goods_name,goods_price,goods_num) values({0},'{1}',{2},{3})",
        //    goods_id.Value, goods_name.Value, goods_price.Value, goods_num.Value);


        //SqlCommand mycmd = new SqlCommand(insertcmd, connection);
        //Response.Write(insertcmd);


    }
}