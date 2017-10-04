using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;


public partial class userCenter : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (((User)Session["User"]) != null)
        {
            userName.InnerHtml = ((User)Session["User"]).Name.ToString();
            Id.InnerHtml = ((User)Session["User"]).Id.ToString();
            Name.InnerHtml = ((User)Session["User"]).RealName.ToString();
            Balance.InnerHtml = ((User)Session["User"]).Balance.ToString("0.00");
            Sex.InnerHtml = ((User)Session["User"]).Sex;
            Phonenum.InnerHtml = ((User)Session["User"]).Phone.ToString();
            Birthday.InnerHtml = ((User)Session["User"]).Sex.ToString();
            Address.InnerHtml=((User)Session["User"]).Address.ToString();
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

            OrderDetailHt htOrderDetail = (OrderDetailHt)Session["OrderDetail"];
            
        }

        if (((User)Session["User"]) != null)
            userName.InnerHtml = ((User)Session["User"]).Name.ToString();
        else
            userName.InnerHtml = "Please Login";


        string userId = ((User)Session["User"]).Id.ToString();
        string cnnstr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        SqlConnection connection = new SqlConnection(cnnstr);

        string queryString = string.Format("SELECT * FROM cart where users_id='{0}'",userId);
        SqlDataAdapter adapter = new SqlDataAdapter(queryString, connection);

        DataSet goods = new DataSet();
        adapter.Fill(goods);

        GridView1.DataSource = goods.Tables[0];
        GridView1.DataBind();

    }
}