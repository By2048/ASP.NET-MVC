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



        if (((User)Session["User"])==null)
        {
            Response.Redirect("sql_login.aspx");
        }

       
        else if (((User)Session["User"]) != null && ((User)Session["User"]).Type != "admin")
        {
            Response.Redirect("sql_index.aspx");
        }

    }
   
}