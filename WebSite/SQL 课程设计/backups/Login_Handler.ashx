<%@ WebHandler Language="C#" Class="Login_Handle" %>

using System;
using System.Web;
using System.Web.SessionState;

public class Login_Handle : IHttpHandler,IRequiresSessionState
{

    public void ProcessRequest(HttpContext context)
    {
        string username = context.Request["username"];
        context.Session["UserName"] = username;
        context.Response.Redirect("../session_web1.aspx");
    }

    public bool IsReusable
    {
        get
        {
            return false;
        }
    }

}