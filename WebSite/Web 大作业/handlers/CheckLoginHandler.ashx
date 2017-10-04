<%@ WebHandler Language="C#" Class="CheckLoginHandler" %>

using System;
using System.Web;
using System.Web.SessionState;

public class CheckLoginHandler : IHttpHandler ,IRequiresSessionState{

    public void ProcessRequest (HttpContext context) {
        int id = int.Parse(context.Request["id"]);
        string password = context.Request["password"];
        var msg = "ok";
        Customer customer= CustomerFactory.GetCustomerByUserId(id);
        if (customer == null)
        {
            msg = "UserIdError";
        }
        else
        {
            if (customer.UserPwd!=password)
            {
                msg = "UserPwdError";
            }
        }
        if (msg=="ok")
        {
            context.Session["User"] = customer;
        }
        context.Response.Write(msg);

    }

    public bool IsReusable {
        get {
            return false;
        }
    }

}