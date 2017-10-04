<%@ WebHandler Language="C#" Class="getDiscount" %>

using System;
using System.Web;
using System.Collections;

public class getDiscount : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {

        Hashtable htDiscount = new Hashtable();    
        Random r = new Random();
        for (int i = 1; i <= 8; i++)
        {
            for (int j = 1; j <= 8; j++)
            {
                htDiscount.Add(i.ToString() + j.ToString(), "9." + r.Next(10).ToString());
            }
        }
        context.Response.ContentType = "text/plain";
        string id = context.Request.QueryString["id"];
        if (!String.IsNullOrEmpty(id) && htDiscount[id] != null)
        {
            context.Response.Write(htDiscount[id].ToString());
        }
        else
        {
            context.Response.Write("error");
        }
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}