using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Orders : System.Web.UI.Page
{
    public int PromotionPercent = 0;
    private int PriceUnit;
    private int AllPrice;
    private int AllAmount;
    public string Code_text;
    private double ass;
    private int item;
    private int female;
    private int male;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) {

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

            ShowData();
            CartLoad(Convert.ToInt32(Session["UserID"]));
        }
    }

    protected void Address_btn_Click(object sender, EventArgs e)
    {

    }
    private void ShowData()
    {
        ArrayList AddressList = ConnectionClass.SelectAddress(Convert.ToInt32(Session["UserID"]));
        foreach (Address address in AddressList)
        {
            Address_ddl.Items.Add(address.Address_Name);
        }
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
        show_lbl.Text = sb.ToString();
        TotalPrice_lbl.Text = Convert.ToString(AllPrice);
        TotalAmount_lbl.Text = Convert.ToString(AllAmount);
        this.ass = ((100 - this.PromotionPercent) * Convert.ToInt32(TotalPrice_lbl.Text) /100);
        TotalAll_lbl.Text = this.ass.ToString();
    }

    protected void Address_ddl_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void MakeOrder_btn_Click(object sender, EventArgs e)
    {
        if (Session["Payment_Path"] != null)
        {
            int Address_ID = ConnectionClass.InsertDelivery(Address_ddl.SelectedValue,
            Convert.ToInt32(DeliveryType_ddl.SelectedValue), 1);
            int Payment_ID = ConnectionClass.InsertPayment(Session["Payment_Path"].ToString(), 1);

            ConnectionClass.InsertOrders(Convert.ToInt32(Session["UserID"]), 1, Payment_ID, Address_ID);
            int Orders_ID = ConnectionClass.SelectOrdersByUsers(Convert.ToInt32(Session["UserID"]), Payment_ID);
            ArrayList cartlist = ConnectionClass.SelectCart(Convert.ToInt32(Session["UserID"]));
            foreach (Cart cart in cartlist)
            {
                Product product = ConnectionClass.SelectProduct(cart.Product_ID);
                ConnectionClass.OrderDetailInsert(product.Product_Price, cart.Cart_Equipment_Quality,
                    cart.Cart_Male_Quality, cart.Cart_Female_Quality, Orders_ID, product.Product_ID);

                if (product.Product_Equipment_Amount!=0)
                {
                    item = product.Product_Equipment_Amount - cart.Cart_Equipment_Quality;
                }
                else
                {
                    item = 0;
                }

                if (product.Product_Male_Amount != 0)
                {
                    male = product.Product_Male_Amount - cart.Cart_Male_Quality;
                }
                else
                {
                    male = 0;
                }

                if (product.Product_Female_Amount != 0)
                {
                    female = product.Product_Female_Amount - cart.Cart_Female_Quality;
                }
                else
                {
                    female = 0;
                }

                ConnectionClass.UpdateProductAmount(product.Product_ID, this.item, this.male, this.female);
            }

            ConnectionClass.UpdateOrders(Convert.ToDouble(TotalAll_lbl.Text), Orders_ID);
            int DorpCart = ConnectionClass.DropCart(Convert.ToInt32(Session["UserID"]));
            if (DorpCart == 1)
            {
                Response.Redirect("~/Pages/Orders/Orders_Main.aspx");
                Session["Payment_Path"] = null;
            }
        }
        else
        {
            Error_lbl.Text = "กรุณาอัปโหลดสลิปจ่ายเงิน หรือ เพิ่มที่จัดส่ง!!";
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string Payment_Image = Path.GetFileName(FileUpload1.FileName);
        if (FileUpload1.FileName != null)
        {
            FileUpload1.SaveAs(Server.MapPath("~/public/Payment/" + Payment_Image));
            Session["Payment_Path"] = Payment_Image;
        }
        else
        {
            Error_lbl.Text = "กรุณาอัปโหลดสลิปก่อนจึงอับโหลด!!";
        }
    }

    protected void Promotion_Txtbox_TextChanged(object sender, EventArgs e)
    {

    }

    protected void PromotionUse_btn_Click(object sender, EventArgs e)
    {
        this.PromotionPercent = ConnectionClass.SelectPromotionByCodeName(Promotion_Txtbox.Text, 1);
        if (this.PromotionPercent != 1)
        {
            CartLoad(Convert.ToInt32(Session["UserID"]));
            Error_lbl.Text = "Promotion Used!!";
        }
    }

}