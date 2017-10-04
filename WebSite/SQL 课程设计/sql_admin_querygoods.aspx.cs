using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Configuration;
using System.Data.SqlClient;
using System.Data;



public partial class sql_admin_index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        rptProducts.DataSource = ProductFactory.GetProductList();
        rptProducts.DataBind();

        string cnnstr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        SqlConnection connection = new SqlConnection(cnnstr);

        string queryString = "exec goods_info";
        string queryString1 = "SELECT * FROM goods";
        SqlDataAdapter adapter = new SqlDataAdapter(queryString, connection);
        SqlDataAdapter adapter1 = new SqlDataAdapter(queryString1, connection);

        DataSet goods = new DataSet();
        adapter.Fill(goods);

        GridView1.DataSource = goods.Tables[0];
        GridView1.DataBind();

        DataSet goods1 = new DataSet();
        adapter1.Fill(goods1);
        GridView3.DataSource = goods1.Tables[0];
        GridView3.DataBind();

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string cnnstr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        SqlConnection connection = new SqlConnection(cnnstr);
        string lookcmd = string.Format("select * from goods where goods_name='{0}'", look_goods_name.Value);
        SqlDataAdapter adapter = new SqlDataAdapter(lookcmd, connection);

        DataSet goods = new DataSet();
        adapter.Fill(goods);

        GridView2.DataSource = goods.Tables[0];
        GridView2.DataBind();




      
    }

}