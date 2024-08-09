using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Orders_Orders_Main : System.Web.UI.Page
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
            if (Delivery_DDL.SelectedIndex != 0)
            {
                ShowData();
            }
        }
    }

    protected void Delivery_DDL_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void SelectOrders_btn_Click(object sender, EventArgs e)
    {

    }

    private void ShowData()
    {

        ArrayList AddressList = ConnectionClass.SelectOrdersID(Convert.ToInt32(Session["UserID"]));
        foreach (Orders orders in AddressList)
        {
            Delivery_DDL.Items.Add(orders.Orders_ID.ToString());

        }
        SelectedDropdownlist(Convert.ToInt32(Delivery_DDL.SelectedValue));
    }
    private void SelectedDropdownlist(int Orders_ID)
    {
        if(Delivery_DDL.SelectedIndex != 0)
        {
            Orders orders = ConnectionClass.SelectOrdersByID(Orders_ID);
            TextBox1.Text = orders.Orders_ID.ToString();
            TextBox2.Text = orders.OrderStatus_Name;
        }
        else
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
        }

    }

    protected void Delivery_DDL_TextChanged(object sender, EventArgs e)
    {
        SelectedDropdownlist(Convert.ToInt32(Delivery_DDL.SelectedValue));
    }
}