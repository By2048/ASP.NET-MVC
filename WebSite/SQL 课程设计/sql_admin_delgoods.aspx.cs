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

        if (goods_id.Value.Length != 0 && goods_name.Value.Length==0)
        {
            string cnnstr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(cnnstr);

            string deletecmd = string.Format("delete from goods where goods_id='{0}'", goods_id.Value);
            SqlCommand mycmd = new SqlCommand(deletecmd, connection);
            mycmd.Connection = connection;
            mycmd.Connection.Open();
            try
            {
                mycmd.ExecuteNonQuery();
            }
            catch (Exception ee)
            {
                //Response.Write(ee.Message);
                Response.Write("<script>alert ('删除失败');</script>");
                mycmd.Connection.Close();
                return;
            }
            mycmd.Connection.Close();
            Response.Write("<script>alert('删除成功');</script>");
        }
        if (goods_id.Value.Length == 0 && goods_name.Value.Length != 0)
        {
            string cnnstr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(cnnstr);

            string deletecmd = string.Format("delete from goods where goods_name='{0}'", goods_name.Value);
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
                Response.Write("<script>alert ('删除失败');</script>");
                mycmd.Connection.Close();
                return;
            }
            mycmd.Connection.Close();
            Response.Write("<script>alert('删除成功');</script>");
        }
        if (goods_id.Value.Length != 0 && goods_name.Value.Length != 0)
        {
            string cnnstr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(cnnstr);

            string deletecmd = string.Format("delete from goods where goods_id='{0}' and goods_name='{1}'",goods_id.Value,goods_name.Value);
            SqlCommand mycmd = new SqlCommand(deletecmd, connection);
            mycmd.Connection = connection;
            mycmd.Connection.Open();
            try
            {
                mycmd.ExecuteNonQuery();
            }
            catch (Exception ee)
            {
                Response.Write("<script>alert ('删除失败');</script>");
                mycmd.Connection.Close();
                return;
            }
            mycmd.Connection.Close();
            Response.Write("<script>alert('删除成功');</script>");
        }       
    } 
}