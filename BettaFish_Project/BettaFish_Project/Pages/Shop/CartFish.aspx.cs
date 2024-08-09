using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Shop_CartFish : System.Web.UI.Page
{
    public int PromotionPercent;
    private int PriceUnit;
    private int AllPrice;
    private int AllAmount;
    public string Code_text;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserType_Name"] != null)
        {
            if (Session["UserType_Name"].ToString() != "User")
            {
                Response.Redirect("~/main.aspx");
            }
        }
        else
        {
            Response.Redirect("~/main.aspx");
        }



        CartLoad(Convert.ToInt32(Session["UserID"]));
    }

    private void CartLoad(int Users_UserID)
    {
        ArrayList cartlist = ConnectionClass.SelectCart(Users_UserID);
        StringBuilder sb = new StringBuilder();
        sb.Append("<link rel='stylesheet' type='text/css' href='../../../styles/ItemProduct.css'/>");
        foreach (Cart cart in cartlist)
        {
            Product product = ConnectionClass.SelectProduct(cart.Product_ID);
            if (product.MainCategory_Name == "BettaFish")
            {
                this.Code_text = string.Format(@"<p><a>จำนวนเพศเมีย:&nbsp;</a><a>{0}</a></p>
                                    <p><a>จำนวนเพศผู้:&nbsp;</a><a>{1}</a></p>",
                                    cart.Cart_Female_Quality, cart.Cart_Male_Quality);

                PriceUnit = (cart.Cart_Female_Quality + cart.Cart_Male_Quality) * product.Product_Price;


            }
            else if (product.MainCategory_Name == "Tool")
            {
                this.Code_text = string.Format(@"<p><a>จำนวนสินค้า:&nbsp;</a><a>{0}</a></p>",
                                    cart.Cart_Equipment_Quality);

                PriceUnit = cart.Cart_Equipment_Quality * product.Product_Price;
            }
            sb.Append(string.Format(@"
                <div class='child-1'>
                    <div class ='image'>
                        <img class='image' src='../../../public/Images/Product/{0}'/>
                    </div>
                    <div class='text'>
                        <p><a>ชื่อ:&nbsp;</a><a>{1}</a></p>
                    </div>
                    <div class='text'>
                        <p><a>ราคา:&nbsp;</a><a>{2}</a></p>
                    </div>
                    <div class='text'>
                        <p><a>ประเภท:&nbsp;</a><a>{3}</a></p>
                    </div>
                    <div class='text'>
                        {4}
                    </div>
                </div>
            ", product.Product_Image, product.Product_Name, product.Product_Price, product.MainCategory_Name, this.Code_text));
            AllPrice += PriceUnit;
            PriceUnit = 0;
            AllAmount += cart.Cart_Female_Quality + cart.Cart_Male_Quality + cart.Cart_Equipment_Quality;
        }
        Showlbl.Text = sb.ToString();
        TotalPrice_lbl.Text = Convert.ToString(AllPrice);
        TotalAmount_lbl.Text = Convert.ToString(AllAmount);
    }

    protected void MakeOrder_btn_Click(object sender, EventArgs e)
    {
        if (TotalAmount_lbl.Text == "0")
        {
            Clear_lbl.Text = "คุณไม่สินค้าในตระกร้า!!!!";
        }
        else
        {
            Response.Redirect("~/Pages/Orders/Orders.aspx");
        }

    }

    protected void Clear_btn_Click1(object sender, EventArgs e)
    {
        int DorpCart = ConnectionClass.DropCart(Convert.ToInt32(Session["UserID"]));
        if (DorpCart == 1)
        {
            Response.Redirect("~/Pages/Shop/CartFish.aspx");
        }
        else
        {
            Clear_lbl.Text = "Clear Error!!";
        }
    }
}