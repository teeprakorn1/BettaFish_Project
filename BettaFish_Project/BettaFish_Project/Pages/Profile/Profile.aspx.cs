using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Profile_Profile : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["UserID"] == null)
            {
                Response.Redirect("~/main.aspx");
            }

             selectdata();
        }
    }

    protected void EditDelivery_btn_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Pages/Profile/Delivery/Edit_Delivery.aspx");
    }

    protected void Finish_btn_Click(object sender, EventArgs e)
    {
        UpdateData();
    }

    protected void AddDelivery_btn_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Pages/Profile/Delivery/Add_Delivery.aspx");
    }

    private void selectdata()
    {
        ShowData();
        User user = ConnectionClass.SelectUserOfUpdateProfile(Convert.ToInt32(Session["UserID"]));
        FName_TxtBox.Text = user.Users_FName;
        LName_TxtBox.Text = user.Users_LName;
        Phone_TxtBox.Text = user.Users_Phone;
    }


    private void UpdateData()
    {
        int value = ConnectionClass.UpdateProfile(Convert.ToInt32(Session["UserID"]), FName_TxtBox.Text, LName_TxtBox.Text, Phone_TxtBox.Text);
        if (value == 1)
        {
            Response.Redirect("~/Pages/Profile/Profile.aspx");
        }
    }

    private void ShowData()
    {
        ArrayList AddressList = ConnectionClass.SelectAddress(Convert.ToInt32(Session["UserID"]));
        foreach (Address address in AddressList)
        {
            Delivery_DDL.Items.Add(address.Address_Name);

        }
    }


    protected void Delivery_DDL_TextChanged(object sender, EventArgs e)
    {

    }
}