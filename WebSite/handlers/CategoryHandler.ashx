<%@ WebHandler Language="C#" Class="CategoryHandler" %>

using System;
using System.Web;
using System.Collections.Generic;
using System.Text;

public class CategoryHandler : IHttpHandler {

    public void ProcessRequest (HttpContext context) {
        
        string cId = context.Request["cid"].ToString();
        List<SmallCategory> list = CategoryFactory.GetSmallCaregorylistByCId(int.Parse(cId));
        context.Response.Write(JsonTools.ObjectListToJson(list));
       
    }

    public bool IsReusable {
        get {
            return false;
        }
    }

}