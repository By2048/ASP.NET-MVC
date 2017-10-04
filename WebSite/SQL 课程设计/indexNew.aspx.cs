using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class indexNew : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Repeater1.DataSource = ProductFactory.GetProductList1();
        Repeater1.DataBind();


        Repeater2.DataSource = ProductFactory.GetProductList2();
        Repeater2.DataBind();

        Repeater3.DataSource = ProductFactory.GetProductList3();
        Repeater3.DataBind();



        RepeaterItem.DataSource = CategoryFactory.GetCategoryList();
        RepeaterItem.DataBind();

        string scid = Request.QueryString["scid"];
        string cid = Request.QueryString["cid"];

        if (scid == null)
        {
            if (cid == null)
            {
                Repeater1.DataSource = ProductFactory.GetProductList1();
                Repeater1.DataBind();
            }
            else
            {
                Repeater1.DataSource = ProductFactory.GetProductByCId(int.Parse(cid));
                Repeater1.DataBind();
            }
        }
        else
        {
            Repeater1.DataSource = ProductFactory.GetProductBySCId(int.Parse(scid));
            Repeater1.DataBind();

            Repeater2.DataSource = null;
            Repeater2.DataBind();

            Repeater3.DataSource = null;
            Repeater3.DataBind();
        }


    }
}