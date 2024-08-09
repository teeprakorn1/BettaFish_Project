using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class Pages_Admin_Admin_Product_Add : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
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
    private void ProductType_Checkbox()
    {
        if (ProductType_Animal.Checked && ProductType_Item.Checked)
        {
            FemaleAmount_TxtBox.Text = "0";
            FemaleAmount_TxtBox.ReadOnly = true;
            FemaleAmount_TxtBox.BackColor = System.Drawing.Color.LightGray;

            MaleAmount_TxtBox.Text = "0";
            MaleAmount_TxtBox.ReadOnly = true;
            MaleAmount_TxtBox.BackColor = System.Drawing.Color.LightGray;

            ItemAmount_TxtBox.Text = "0";
            ItemAmount_TxtBox.ReadOnly = true;
            ItemAmount_TxtBox.BackColor = System.Drawing.Color.LightGray;

            ProductType_Animal.Checked = false;
            ProductType_Item.Checked = false;
        }
        else
        {

            if (ProductType_Animal.Checked)
            {
                FemaleAmount_TxtBox.Text = "";
                FemaleAmount_TxtBox.ReadOnly = false;
                FemaleAmount_TxtBox.BackColor = System.Drawing.Color.White;

                MaleAmount_TxtBox.Text = "";
                MaleAmount_TxtBox.ReadOnly = false;
                MaleAmount_TxtBox.BackColor = System.Drawing.Color.White;

                ProductType_Item.Checked = false;
            }
            else
            {
                FemaleAmount_TxtBox.Text = "0";
                FemaleAmount_TxtBox.ReadOnly = true;
                FemaleAmount_TxtBox.BackColor = System.Drawing.Color.LightGray;

                MaleAmount_TxtBox.Text = "0";
                MaleAmount_TxtBox.ReadOnly = true;
                MaleAmount_TxtBox.BackColor = System.Drawing.Color.LightGray;
            }

            if (ProductType_Item.Checked)
            {
                ItemAmount_TxtBox.Text = "";
                ItemAmount_TxtBox.ReadOnly = false;
                ItemAmount_TxtBox.BackColor = System.Drawing.Color.White;

                ProductType_Animal.Checked = false;
            }
            else
            {
                ItemAmount_TxtBox.Text = "0";
                ItemAmount_TxtBox.ReadOnly = true;
                ItemAmount_TxtBox.BackColor = System.Drawing.Color.LightGray;
            }
        }
    }
    protected void EditProduct_btn_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Pages/Admin/Admin_Product_Edit.aspx");
    }
    protected void AddProduct_btn_Click(object sender, EventArgs e)
    {
        string Product_Image = Path.GetFileName(FileUpload1.FileName);
        FileUpload1.SaveAs(Server.MapPath("~/public/Images/Product/" + Product_Image));
        ConnectionClass.InsertProduct(ProductName_TxtBox.Text, Convert.ToInt32(ProductPrice_TxtBox.Text),ProductDetail_TxtBox.Text
             , Convert.ToInt32(MaleAmount_TxtBox.Text), Convert.ToInt32(FemaleAmount_TxtBox.Text),
             Convert.ToInt32(ItemAmount_TxtBox.Text), Product_Image, SubCategory_DDL.SelectedValue);
    }
    protected void UplaodImage_btn_Click(object sender, EventArgs e)
    {
        string Product_Image = Path.GetFileName(FileUpload1.FileName);
        FileUpload1.SaveAs(Server.MapPath("~/public/Images/Product/" + Product_Image));
    }

    protected void ProductType_Animal_CheckedChanged(object sender, EventArgs e)
    {
        ProductType_Checkbox();
    }

    protected void ProductType_Item_CheckedChanged(object sender, EventArgs e)
    {
        ProductType_Checkbox();

    }
}
