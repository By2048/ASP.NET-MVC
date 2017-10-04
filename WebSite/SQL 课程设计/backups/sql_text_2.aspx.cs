using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;



public partial class sql_text_2 : System.Web.UI.Page
{



    protected void Button1_Click(object sender, EventArgs e)
    {
        string cnnstr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        SqlConnection connection = new SqlConnection(cnnstr);

        string insertcmd = string.Format("insert into goods (goods_id,goods_name,goods_price,goods_num) values({0},'{1}',{2},{3})",
                    TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text);

        SqlCommand mycmd = new SqlCommand(insertcmd, connection);

        //mycmd.Parameters.AddWithValue("@goods_id", int.Parse(TextBox1.Text));
        //mycmd.Parameters.AddWithValue("@goods_name", (TextBox2.Text).ToString());
        //mycmd.Parameters.AddWithValue("@goods_price", decimal.Parse(TextBox3.Text));
        //mycmd.Parameters.AddWithValue("@goods_num", int.Parse(TextBox4.Text));
        //mycmd.Parameters.AddWithValue("@goods_img", (TextBox5.Text).ToString());

        mycmd.Connection = connection;
        mycmd.Connection.Open();
        try
        {
            mycmd.ExecuteNonQuery();
        }
        catch (Exception ee)
        {
            Response.Write(ee.Message);
            mycmd.Connection.Close();
            return;
        }
        mycmd.Connection.Close();
        output.Text = "ok";
        Response.AddHeader("Refresh", "0");
    } 


    protected void Button11_Click(object sender, EventArgs e)
    {
        string cnnstr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        SqlConnection connection = new SqlConnection(cnnstr);


        string deletecmd = string.Format("delete from goods where goods_id='{0}'", TextBox11.Text);

        //int @goods_id = int.Parse(TextBox11.Text);
        //string deletecmd = "delete from goods where goods_id="+ @goods_id.ToString();
        SqlCommand mycmd = new SqlCommand(deletecmd, connection);
      

        mycmd.Connection = connection;
        mycmd.Connection.Open();
        try
        {
            mycmd.ExecuteNonQuery();
        }
        catch (Exception ee)
        {
            Response.Write(ee.Message);
            mycmd.Connection.Close();
            return;
        }
        mycmd.Connection.Close();
        output1.Text = "ok";
        Response.AddHeader("Refresh", "0");
    }


    protected void Button111_Click(object sender, EventArgs e)
    {
        string cnnstr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        SqlConnection connection = new SqlConnection(cnnstr);
        string queryString = "SELECT * FROM goods";
        SqlDataAdapter adapter = new SqlDataAdapter(queryString, connection);

        DataSet books = new DataSet();
        adapter.Fill(books);
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        rptProducts.DataSource = ProductFactory.GetProductList();
        rptProducts.DataBind();

        string cnnstr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        SqlConnection connection = new SqlConnection(cnnstr);
        string queryString = "SELECT * FROM goods";
        SqlDataAdapter adapter = new SqlDataAdapter(queryString, connection);

        DataSet books = new DataSet();
        adapter.Fill(books);
        GridView1.DataSource = books.Tables[0];
        GridView1.DataBind();
    }





    protected void Button1111_Click(object sender, EventArgs e)
    {
        string cnnstr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        SqlConnection connection = new SqlConnection(cnnstr);

        //update goods
        //set goods_name='111'
        //where goods_id=5

        string id = TextBox6.Text;
        string name = TextBox5.Text;

        string updatecmd = string.Format("update goods set goods_name='{0}' where goods_id={1}", name, id);

        //int @goods_id = int.Parse(TextBox11.Text);
        //string deletecmd = "delete from goods where goods_id="+ @goods_id.ToString();
        SqlCommand mycmd = new SqlCommand(updatecmd, connection);


        mycmd.Connection = connection;
        mycmd.Connection.Open();
        try
        {
            mycmd.ExecuteNonQuery();
        }
        catch (Exception ee)
        {
            Response.Write(ee.Message);
            mycmd.Connection.Close();
            return;
        }
        mycmd.Connection.Close();
        output3.Text = "ok";
        Response.AddHeader("Refresh", "0");
    }

}