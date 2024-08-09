using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Admin_Delivery : System.Web.UI.Page
{
    private int anns;
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            if (Session["UserType_Name"] != null)
            {
                if (Session["UserType_Name"].ToString() != "Admin")
                {
                    Response.Redirect("~/main.aspx");
                }
            }
            else
            {
                Response.Redirect("~/main.aspx");
            }

        }
    }

    protected void SearchData_btn_Click(object sender, EventArgs e)
    {
        Orders orders = ConnectionClass.SelectOrdersByID(Convert.ToInt32(SearchOrderID_TxtBox.Text));
        if (orders != null)
        {
            UserID_TxtBox.Text = orders.Users_ID.ToString();
            OrderID_TxtBox.Text = orders.Orders_ID.ToString();
            AdressID_TxtBox.Text = orders.Address_ID.ToString();
            TotalPrice_TxtBox.Text = orders.Orders_TotalPrice.ToString();

            DeliveryStatus_Check.Checked = false;
            DeliveryStatus_Shipping.Checked = false;
            DeliveryStatus_Finish.Checked = false;
            Session["OrderID"] = orders.Orders_ID;

            if (orders.OrderStatus_Name == "Check")
            {
                DeliveryStatus_Check.Checked = true;
                DeliveryStatus_Shipping.Checked = false;
                DeliveryStatus_Finish.Checked = false;
            }
            else if (orders.OrderStatus_Name == "Shipping")
            {
                DeliveryStatus_Check.Checked = false;
                DeliveryStatus_Shipping.Checked = true;
                DeliveryStatus_Finish.Checked = false;
            }
            else if(orders.OrderStatus_Name == "Finish")
            {
                DeliveryStatus_Check.Checked = false;
                DeliveryStatus_Shipping.Checked = false;
                DeliveryStatus_Finish.Checked = true;
            }
            else {
                DeliveryStatus_Check.Checked = false;
                DeliveryStatus_Shipping.Checked = false;
                DeliveryStatus_Finish.Checked = false;
            }

            string image_show_text = string.Format(@"
                <img class='image' src='../../../public/Payment/{0}'/>
            ", orders.Payment_Image);
            show_img.Text = image_show_text;
        }
    }

    private void ProductStatus_Checkbox()
    {
        if (DeliveryStatus_Check.Checked && DeliveryStatus_Shipping.Checked && DeliveryStatus_Finish.Checked)
        {
            DeliveryStatus_Check.Checked = false;
            DeliveryStatus_Shipping.Checked = false;
            DeliveryStatus_Finish.Checked = false;
        }
    }

    protected void EditData_btn_Click(object sender, EventArgs e)
    {
        if (OrderID_TxtBox.Text != null)
        {
            if (DeliveryStatus_Check.Checked)
            {
                anns = 1;
            }
            if (DeliveryStatus_Shipping.Checked)
            {
                anns = 2;
            }
            if (DeliveryStatus_Finish.Checked)
            {
                anns = 3;
            }

            ConnectionClass.UpdateOrdersById(Convert.ToInt32(Session["OrderID"]),anns);

            Response.Redirect("~/Pages/Admin/Admin_Delivery.aspx");
        }
    }

    protected void DeliveryStatus_Check_CheckedChanged(object sender, EventArgs e)
    {
        ProductStatus_Checkbox();
    }

    protected void DeliveryStatus_Shipping_CheckedChanged(object sender, EventArgs e)
    {
        ProductStatus_Checkbox();
    }

    protected void DeliveryStatus_Finish_CheckedChanged(object sender, EventArgs e)
    {
        ProductStatus_Checkbox();
    }
}