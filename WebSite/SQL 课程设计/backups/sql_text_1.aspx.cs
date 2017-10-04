using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

public partial class sql_text_1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string cnnstr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        SqlConnection connection = new SqlConnection(cnnstr);
        string queryString = "SELECT * FROM goods";
        SqlDataAdapter adapter = new SqlDataAdapter(queryString, connection);

        DataSet books = new DataSet();
        adapter.Fill(books);
        //GridView1.DataSource = books.Tables[0];
        //GridView1.DataBind();
    }
}