using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Shop_ProductDetail : System.Web.UI.Page
{
    private int Item, male, female;


    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["productId"] !=null)
        {
            int proid;
            if (int.TryParse(Request.QueryString["productId"], out proid))
            {
                Session["productId"] = proid;
                SelectProduct(proid);
            }
        }
        else
        {
            Response.Redirect("~/main.aspx");
        }

    }

    private void SelectProduct(int product_id)
    {
        Product Product = ConnectionClass.SelectProduct(Convert.ToInt32(product_id));

        String DataImage = string.Format(@"<link rel='stylesheet' type='text/css' href='../../../styles/ItemProduct.css'/>
                                    <div class ='image-1'> <img class='image-1' src='../../../public/Images/Product/{0}'/>
                                    </div>", Product.Product_Image);
        ImageID_Txtbox.Text = DataImage;
        productID_Txtbox.Text = Product.Product_ID.ToString();
        productName_Txtbox.Text = Product.Product_Name.ToString();
        productDetail_Txtbox.Text = Product.Product_Detail.ToString();
        productPrice_Txtbox.Text = Product.Product_Price.ToString() + " THB.";

        if (Product.MainCategory_Name=="BettaFish")
        {
            Animal_lbl.Visible = true;
            Item_lbl.Visible = false;
        }
        else if (Product.MainCategory_Name == "Tool")
        {
            Animal_lbl.Visible = false;
            Item_lbl.Visible = true;
        }
    }

    protected void AddCart_btn_Click(object sender, EventArgs e)
    {
        if (Session["UserID"] != null)
        {
            if ((MaleQuality_Txtbox.Text != "0" || FemaleQuality_Txtbox.Text != "0") || Item_Quality_Txtbox.Text != "0")
            {
                Product product = ConnectionClass.SelectProduct(Convert.ToInt32(Session["productId"]));

                if (Convert.ToInt32(Item_Quality_Txtbox.Text) <= product.Product_Equipment_Amount)
                {
                    this.Item = Convert.ToInt32(Item_Quality_Txtbox.Text);
                }

                if (Convert.ToInt32(MaleQuality_Txtbox.Text) <= product.Product_Male_Amount)
                {
                    this.male = Convert.ToInt32(MaleQuality_Txtbox.Text);
                }

                if (Convert.ToInt32(FemaleQuality_Txtbox.Text) <= product.Product_Female_Amount)
                {
                    this.female = Convert.ToInt32(FemaleQuality_Txtbox.Text);
                }

                if (this.Item > 0 || this.male > 0 || this.female > 0)
                {
                    int value = ConnectionClass.CartInsert(Convert.ToInt32(Session["UserID"]),
                Convert.ToInt32(Session["productId"]), this.Item, this.female, this.male);
                    if (value == 1)
                    {
                        Error_lbl.Text = "Add to Cart Success!";
                    }
                    else
                    {
                        Error_lbl.Text = "Your Product is Already!";
                    }
                }
                else
                {
                    Error_lbl.Text = "Your Quantity of Products you require is negative or exceeds the available Quantity!";
                }
            }
            else
            {
                Error_lbl.Text = "Enter Your Quality!";
            }
        }
        else
        {
            Error_lbl.Text = "You Not Have Login!";
        }
    }
}