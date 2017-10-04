<%@ WebHandler Language="C#" Class="LogOutHandler" %>

using System;
using System.Web;
using System.Web.SessionState;

public class LogOutHandler : IHttpHandler ,IRequiresSessionState{
    
    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        context.Session["User"] = null;
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}