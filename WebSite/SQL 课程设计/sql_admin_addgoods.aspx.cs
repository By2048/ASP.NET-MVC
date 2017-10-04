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
       
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string cnnstr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        SqlConnection connection = new SqlConnection(cnnstr);

        string insertcmd = string.Format("insert into goods (goods_id,goods_name,goods_price,goods_num) values({0},'{1}',{2},{3})",
            goods_id.Value, goods_name.Value,goods_price.Value, goods_num.Value);
       

        SqlCommand mycmd = new SqlCommand(insertcmd, connection);
        //Response.Write(insertcmd);
       

        mycmd.Connection = connection;
        mycmd.Connection.Open();
        try
        {
            mycmd.ExecuteNonQuery();
        }
        catch (Exception ee)
        {
            Response.Write("<script>alert('添加失败');</script>");
            //Response.Write(ee.Message);
            mycmd.Connection.Close();
            return;
        }
        mycmd.Connection.Close();
        Response.Write("<script>alert('添加成功');</script>");
    } 
}