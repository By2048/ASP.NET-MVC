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
        string name = user_name.Value;
        string new_name = user_new_name.Value;
        string new_psw = user_new_psw.Value;
        string new_type = Request["user_new_type"];

        if (name.Length!=0  && new_name.Length==0 && new_psw.Length==0 && new_type.Length!=0)
        {
            string cnnstr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(cnnstr);
            string updatecmd = string.Format("update users set users_type='{0}' where users_name='{1}'",
                     new_type, name);
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
            //Response.Write(updatecmd);
            Response.Write("<script>alert('修改成功');</script>");


        }
        else
        {
            string cnnstr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(cnnstr);
            string updatecmd = string.Format("update users set users_name='{0}',users_psw='{1}',users_type='{2}' where users_name='{3}'",
                     new_name, new_psw, new_type, name);
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
            //Response.Write(updatecmd);
            Response.Write("<script>alert('修改成功');</script>");
        } 

    }

}
