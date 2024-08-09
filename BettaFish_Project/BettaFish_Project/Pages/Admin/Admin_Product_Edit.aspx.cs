using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Admin_Admin_Product_Edit : System.Web.UI.Page
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
            FemaleAmount_Txtbox.Text = "0";
            FemaleAmount_Txtbox.ReadOnly = true;
            FemaleAmount_Txtbox.BackColor = System.Drawing.Color.LightGray;

            MaleAmount_Txtbox.Text = "0";
            MaleAmount_Txtbox.ReadOnly = true;
            MaleAmount_Txtbox.BackColor = System.Drawing.Color.LightGray;

            ItemAmount_Txtbox.Text = "0";
            ItemAmount_Txtbox.ReadOnly = true;
            ItemAmount_Txtbox.BackColor = System.Drawing.Color.LightGray;

            ProductType_Animal.Checked = false;
            ProductType_Item.Checked = false;
        }
        else
        {

            if (ProductType_Animal.Checked)
            {
                FemaleAmount_Txtbox.Text = "";
                FemaleAmount_Txtbox.ReadOnly = false;
                FemaleAmount_Txtbox.BackColor = System.Drawing.Color.White;

                MaleAmount_Txtbox.Text = "";
                MaleAmount_Txtbox.ReadOnly = false;
                MaleAmount_Txtbox.BackColor = System.Drawing.Color.White;

                ProductType_Item.Checked = false;
            }
            else
            {
                FemaleAmount_Txtbox.Text = "0";
                FemaleAmount_Txtbox.ReadOnly = true;
                FemaleAmount_Txtbox.BackColor = System.Drawing.Color.LightGray;

                MaleAmount_Txtbox.Text = "0";
                MaleAmount_Txtbox.ReadOnly = true;
                MaleAmount_Txtbox.BackColor = System.Drawing.Color.LightGray;
            }

            if (ProductType_Item.Checked)
            {
                ItemAmount_Txtbox.Text = "";
                ItemAmount_Txtbox.ReadOnly = false;
                ItemAmount_Txtbox.BackColor = System.Drawing.Color.White;

                ProductType_Animal.Checked = false;
            }
            else
            {
                ItemAmount_Txtbox.Text = "0";
                ItemAmount_Txtbox.ReadOnly = true;
                ItemAmount_Txtbox.BackColor = System.Drawing.Color.LightGray;
            }
        }
    }
    private void ProductStatus_Checkbox()
    {
        if (ProductStatus_True.Checked && ProductStatus_False.Checked)
        {
            ProductStatus_True.Checked = false;
            ProductStatus_False.Checked = false;
        }
    }
    private void LoadImage(string i)
    {
        Panel PanelImage = new Panel();
        Image ProductImage = new Image
        {
            ImageUrl = "~/public/Images/Product/"
            + i,
            CssClass = "ProductImage"
        };
        PanelImage.Controls.Add(ProductImage);
        Panel1.Controls.Add(PanelImage);
    }

    protected void SearchData_btn_Click(object sender, EventArgs e)
    {
        Product Product = ConnectionClass.SelectProduct(Convert.ToInt32(SearchProduct_TxtBox.Text));
        if (Product != null)
        {
            ProductID_Txtbox.Text = Product.Product_ID.ToString();
            ProductName_Txtbox.Text = Product.Product_Name.ToString();
            ProductPrice_Txtbox.Text = Product.Product_Price.ToString();
            ProductDetail_Txtbox.Text = Product.Product_Detail.ToString();
            ProductStatus_True.Checked = false;
            ProductStatus_False.Checked = false;

            if (Product.Product_Male_Amount > 0 || Product.Product_Female_Amount > 0)//Check ProductType
            {
                ProductType_Animal.Checked = true;
                ProductType_Item.Checked = false;
            }
            else if (Product.Product_Equipment_Amount > 0)
            {
                ProductType_Animal.Checked = false;
                ProductType_Item.Checked = true;
            }
            else
            {
                ProductType_Animal.Checked = false;
                ProductType_Item.Checked = false;
            }

            if (Product.Product_ActiveStatus == 1)//Check ProductStatus
            {
                ProductStatus_True.Checked = true;
                ProductStatus_False.Checked = false;
            }
            else if (Product.Product_ActiveStatus == 0)
            {
                ProductStatus_True.Checked = false;
                ProductStatus_False.Checked = true;
            }
            else
            {
                ProductStatus_True.Checked = false;
                ProductStatus_False.Checked = false;
            }

            ProductType_Checkbox();
            ItemAmount_Txtbox.Text = Product.Product_Equipment_Amount.ToString();
            FemaleAmount_Txtbox.Text = Product.Product_Female_Amount.ToString();
            MaleAmount_Txtbox.Text = Product.Product_Male_Amount.ToString();

            if (Product.MainCategory_Name == "BettaFish")
            {
                Category_DDL.SelectedValue = Product.MainCategory_Name;
            }
            else if(Product.MainCategory_Name == "Tool")
            {
                Category_DDL.SelectedValue = Product.MainCategory_Name;
            }
            else if (Product.MainCategory_Name == "Other")
            {
                Category_DDL.SelectedValue = "Tool";
            }

            SubCategory_DDL.SelectedValue = Product.SubCategory_Name;
            Session["Image_Path"] = Product.Product_Image.ToString();

            Panel PanelImage = new Panel();
            Image ProductImage = new Image { ImageUrl = "~/public/Images/Product/"
                + Product.Product_Image, CssClass = "ProductImage" };
            PanelImage.Controls.Clear();
            PanelImage.Controls.Add(ProductImage);
            Panel1.Controls.Add(PanelImage);
        }
    }

    protected void EditProduct_btn_Click(object sender, EventArgs e)
    {
        if (ProductID_Txtbox.Text != null)
        {
            ConnectionClass.UpdateProduct(Convert.ToInt32(ProductID_Txtbox.Text), ProductName_Txtbox.Text,
            Convert.ToInt32(ProductPrice_Txtbox.Text), ProductDetail_Txtbox.Text, Convert.ToInt32(ItemAmount_Txtbox.Text),
            Convert.ToInt32(FemaleAmount_Txtbox.Text), Convert.ToInt32(MaleAmount_Txtbox.Text),
            Session["Image_Path"].ToString(), Convert.ToInt32(ProductStatus_True.Checked), SubCategory_DDL.SelectedValue);

            Page_Load(sender, e);
        }
    }

    protected void ProductType_Animal_CheckedChanged(object sender, EventArgs e)
    {
        ProductType_Checkbox();
    }

    protected void ProductType_Item_CheckedChanged(object sender, EventArgs e)
    {
        ProductType_Checkbox();
    }

    protected void ProductStatus_True_CheckedChanged(object sender, EventArgs e)
    {
        ProductStatus_Checkbox();
    }

    protected void ProductStatus_False_CheckedChanged(object sender, EventArgs e)
    {
        ProductStatus_Checkbox();
    }

    protected void FileUpload1_DataBinding(object sender, EventArgs e)
    {
        string Product_Image = Path.GetFileName(FileUpload1.FileName);
        FileUpload1.SaveAs(Server.MapPath("~/public/Images/Product/" + Product_Image));
        Session["Image_Path"] = Product_Image;
    }

    protected void UploadData_btn_Click(object sender, EventArgs e)
    {
        string Product_Image = Path.GetFileName(FileUpload1.FileName);
        FileUpload1.SaveAs(Server.MapPath("~/public/Images/Product/" + Product_Image));
        Session["Image_Path"] = Product_Image;


       Panel PanelImage = new Panel();
       Image ProductImage = new Image { ImageUrl = "~/public/Images/Product/"
             + Product_Image, CssClass = "ProductImage"};
        PanelImage.Controls.Clear();
        PanelImage.Controls.Add(ProductImage);
        Panel1.Controls.Add(PanelImage);
    }
}