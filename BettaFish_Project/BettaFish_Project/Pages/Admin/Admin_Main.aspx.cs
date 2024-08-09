using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Admin_Admin_Main : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserType_Name"] != null)
        {
            if (Session["UserType_Name"].ToString() != "Admin")
            {
                Response.Redirect("~/main.aspx");
            }
        }else{
            Response.Redirect("~/main.aspx");
        }
    }
}