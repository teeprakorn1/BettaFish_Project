using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Profile_Delivery_Edit_Delivery : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["UserID"] == null)
            {
                Response.Redirect("~/main.aspx");
            }
            ShowData();
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

    private void SelectedDropdownlist(string Address_Name, int UserID)
    {
        if (Delivery_DDL.SelectedIndex != 0)
        {
            Address address = ConnectionClass.SelectAddressByAddress_NameAndUsers_ID(Address_Name, UserID);
            Session["Address_ID"] = address.Address_ID;
            AddressName_TxtBox.Text = address.Address_Name;
            AddressDetail_TxtBox.Text = address.Address_Detail;
        }
        else
        {
            AddressName_TxtBox.Text = "";
            AddressDetail_TxtBox.Text = "";
        }
    }



    protected void DeleteData_btn_Click(object sender, EventArgs e)
    {
        int value = ConnectionClass.DropAddress(Convert.ToInt32(Session["Address_ID"]));
        if(value == 1)
        {
            Response.Redirect("~/Pages/Profile/Delivery/Edit_Delivery.aspx");
        }
    }

    protected void EditData_btn_Click(object sender, EventArgs e)
    {
        ConnectionClass.UpdateAddress(Convert.ToInt32(Session["Address_ID"]), Convert.ToInt32(Session["UserID"])
            , AddressName_TxtBox.Text, AddressDetail_TxtBox.Text);

    }

    protected void Delivery_DDL_TextChanged(object sender, EventArgs e)
    {
        SelectedDropdownlist(Delivery_DDL.SelectedValue, Convert.ToInt32(Session["UserID"]));
    }

    protected void AddData_btn_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Pages/Profile/Delivery/Add_Delivery.aspx");
    }

    protected void EditData_btn_Click1(object sender, EventArgs e)
    {
        if (Delivery_DDL.SelectedIndex != 0)
        {
            ConnectionClass.UpdateAddress(Convert.ToInt32(Session["Address_ID"]), Convert.ToInt32(Session["UserID"])
            , AddressName_TxtBox.Text, AddressDetail_TxtBox.Text);
            Response.Redirect("~/Pages/Profile/Delivery/Edit_Delivery.aspx");
        }
    }
}