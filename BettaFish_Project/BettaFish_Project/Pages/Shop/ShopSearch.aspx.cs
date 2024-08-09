using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Shop_ShopSearch : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            String value;
            if (Request.QueryString["Search"] != null)
            {
                value = Request.QueryString["Search"];
                FillPage(value);
                TextBox1.Text = value;
            }
        }
    }

    private void FillPage(string Search_value)
    {
        ArrayList productList = ConnectionClass.SelectProductLikeName(Search_value, 1);
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

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        FillPage(TextBox1.Text);
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        FillPage(TextBox1.Text);
    }
}