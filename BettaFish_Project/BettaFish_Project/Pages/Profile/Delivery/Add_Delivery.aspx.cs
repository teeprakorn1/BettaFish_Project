using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Profile_Delivery_Add_Delivery : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Finish_btn_Click(object sender, EventArgs e)
    {
        if (AddressName_TxtBox.Text != "" && AddressDetail_TxtBox.Text != "")
        {
            ConnectionClass.InsertAddress(AddressName_TxtBox.Text, AddressDetail_TxtBox.Text, Convert.ToInt32(Session["UserID"]));
            Response.Redirect("~/Pages/Profile/Profile.aspx");
        }
    }

    protected void AddData_btn_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Pages/Profile/Delivery/Edit_Delivery.aspx");
    }
}