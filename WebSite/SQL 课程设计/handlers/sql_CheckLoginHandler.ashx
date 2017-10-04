<%@ WebHandler Language="C#" Class="CheckLoginHandler" %>

using System;
using System.Web;
using System.Web.SessionState;

using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;


public class CheckLoginHandler : IHttpHandler, IRequiresSessionState
{

    public void ProcessRequest(HttpContext context)
    {

        int id = int.Parse(context.Request["id"]);
        string password = context.Request["password"];
        var msg = "ok";


        string cnnstr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        SqlConnection connection = new SqlConnection(cnnstr);

        
        
        
        
        
        context.Response.Write(msg);

    }



    //protected void Button1_Click(object sender, EventArgs e)
    //{
    //    string cnnstr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
    //    SqlConnection connection = new SqlConnection(cnnstr);

    //    string insertcmd = string.Format("insert into goods (goods_id,goods_name,goods_price,goods_num) values({0},'{1}',{2},{3})",
    //                TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text);

    //    SqlCommand mycmd = new SqlCommand(insertcmd, connection);

    //    //mycmd.Parameters.AddWithValue("@goods_id", int.Parse(TextBox1.Text));
    //    //mycmd.Parameters.AddWithValue("@goods_name", (TextBox2.Text).ToString());
    //    //mycmd.Parameters.AddWithValue("@goods_price", decimal.Parse(TextBox3.Text));
    //    //mycmd.Parameters.AddWithValue("@goods_num", int.Parse(TextBox4.Text));
    //    //mycmd.Parameters.AddWithValue("@goods_img", (TextBox5.Text).ToString());

    //    mycmd.Connection = connection;
    //    mycmd.Connection.Open();
    //    try
    //    {
    //        mycmd.ExecuteNonQuery();
    //    }
    //    catch (Exception ee)
    //    {
    //        Response.Write(ee.Message);
    //        mycmd.Connection.Close();
    //        return;
    //    }
    //    mycmd.Connection.Close();
    //    output.Text = "ok";
    //    Response.AddHeader("Refresh", "0");
    //}

    public bool IsReusable
    {
        get
        {
            return false;
        }
    }

}