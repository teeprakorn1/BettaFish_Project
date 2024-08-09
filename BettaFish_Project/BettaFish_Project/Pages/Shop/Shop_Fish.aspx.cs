using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Shop_Shop_Fish : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        FillPage(betta_dropdownlist.SelectedValue);
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        FillPage(betta_dropdownlist.SelectedValue);
        show_lbl_text.Text = betta_dropdownlist.SelectedValue;
    }

    protected void ProductName_TxtBox_TextChanged(object sender, EventArgs e)
    {
        string value = string.Format(@"~/Pages/Shop/ShopSearch.aspx?Search={0}", TextBox1.Text);
        Response.Redirect(value);
    }

    private void FillPage(string SubName)
    {
        ArrayList productList = ConnectionClass.SelectProductTopSubName(SubName, 1);
        StringBuilder sb = new StringBuilder();

        sb.Append("<section class='sec'>");
        foreach (Product product in productList)
        {
            sb.Append(string.Format(@"
                <div class='product'>
                <div class='card'>
                    <a href = '../../../Pages/Shop/ProductDetail.aspx?productId={0}'>
                        <div class='img'><img src='../../../public/Images/Product/{1}'/>
                            <div class='Intxt' style='text-align: center; font-size: 16px;'>{2}</div>
                            <div class='Intxt-1' style='text-align: center; font-size: 16px;'>$ {3}</div>
                        </div>
                    </a>
                </div>
            </div>
            ", product.Product_ID, product.Product_Image,
            product.Product_Name, product.Product_Price));


        }
        sb.Append("</section>");
        show_lbl.Text = sb.ToString();

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string value = string.Format(@"~/Pages/Shop/ShopSearch.aspx?Search={0}", TextBox1.Text);
        Response.Redirect(value);
    }
}