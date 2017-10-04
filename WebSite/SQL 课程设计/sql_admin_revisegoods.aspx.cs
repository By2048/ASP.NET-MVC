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
        if (goods_new_name.Value.Length != 0 && goods_new_price.Value.Length == 0)
        {
            string cnnstr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(cnnstr);
            //update goods set goods_name='4weew45' where goods_name='name5'

            string updatecmd = string.Format("update goods set goods_name='{0}' where goods_name='{1}'",
                 goods_new_name.Value,goods_name.Value);

            SqlCommand mycmd = new SqlCommand(updatecmd, connection);
            mycmd.Connection = connection;
            mycmd.Connection.Open();
            try
            {
                mycmd.ExecuteNonQuery();
            }
            catch (Exception ee)
            {
                //Response.Write(ee.Message);
                Response.Write("<script>alert('修改失败');</script>");
                mycmd.Connection.Close();
                return;
            }
            mycmd.Connection.Close();
            Response.Write("<script>alert('修改成功');</script>");
        }


        if (goods_new_name.Value.Length == 0 && goods_new_price.Value.Length != 0)
        {
            string cnnstr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(cnnstr);

            string updatecmd = string.Format("update goods set goods_price={0} where goods_name='{1}'",
                 goods_new_price.Value, goods_name.Value);

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
                Response.Write("<script>alert('修改失败');</script>");
                mycmd.Connection.Close();
                return;
            }
            mycmd.Connection.Close();
            Response.Write("<script>alert('修改成功');</script>");
        }

        if (goods_new_name.Value.Length != 0 && goods_new_price.Value.Length != 0)
        {
            string cnnstr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(cnnstr);

            string updatecmd = string.Format("update goods set goods_name='{0}', goods_price={1} where goods_name='{2}'",
                 goods_new_name.Value,goods_new_price.Value, goods_name.Value);

            SqlCommand mycmd = new SqlCommand(updatecmd, connection);
            mycmd.Connection = connection;
            mycmd.Connection.Open();
            try
            {
                mycmd.ExecuteNonQuery();
            }
            catch (Exception ee)
            {
                //Response.Write(ee.Message);
                Response.Write("<script>alert('修改失败');</script>");
                mycmd.Connection.Close();
                return;
            }
            mycmd.Connection.Close();
            Response.Write("<script>alert('修改成功');</script>");
        }

    }

}
