﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;


public partial class sql_text_3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
      
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string cnnstr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        SqlConnection connection = new SqlConnection(cnnstr);


        string login = string.Format("select * from users where users_id='{0}' and users_psw='{1}'", TextBox1.Text, TextBox2.Text);
        
        SqlDataAdapter adapter=new SqlDataAdapter(login, connection);

        DataSet ds=new DataSet();
        adapter.Fill(ds);
        GridView1.DataSource = ds.Tables[0];
        GridView1.DataBind();

        //Session["User"]=new User;

        if (ds.Tables[0].Rows.Count > 0)
        {
            int id= int.Parse(ds.Tables[0].Rows[0].ItemArray[2].ToString());
            string name = ds.Tables[0].Rows[0].ItemArray[0].ToString(); 
            string psw = ds.Tables[0].Rows[0].ItemArray[1].ToString(); 
            string type=ds.Tables[0].Rows[0].ItemArray[3].ToString();
            decimal balance=decimal.Parse(ds.Tables[0].Rows[0].ItemArray[4].ToString());
            string realname=ds.Tables[0].Rows[0].ItemArray[5].ToString();
            string sex=ds.Tables[0].Rows[0].ItemArray[6].ToString();
            string phone=ds.Tables[0].Rows[0].ItemArray[7].ToString();
            string address=ds.Tables[0].Rows[0].ItemArray[8].ToString();

            Session["User"]=new User(id,name,psw,sex,type,address,phone,balance,realname);

            ((User)Session["User"]).Id = id;
            ((User)Session["User"]).Name = name;
            ((User)Session["User"]).Type = type;


            //Session["UserName"] = ds.Tables[0].Rows[0].ItemArray[0].ToString();
          
            // userName.InnerHtml = ((Customer)Session["User"]).UserName;
            if (((User)Session["User"]).Type=="admin")
                Response.Redirect("sql_admin_index.aspx");
            else
                Response.Redirect("sql_admin_index.aspx");
            Response.Write(id+name+psw+type+balance+realname+sex+phone+address);
        }
        else
        {
            output1.Text = "error";
        }
        
    }
}

