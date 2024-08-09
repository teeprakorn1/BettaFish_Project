using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Master_Navigation : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserName"] != null)
        {
            if (Session["UserType_Name"].ToString() == "User")
            {
                profile_btn.Text = Session["UserName"].ToString();

                //Visitor Button
                Main_btn.Visible = true;
                ShopMain_btn.Visible = true;
                Shop_DDL.Visible = true;
                ArticleMain_btn.Visible = true;
                Article_DDL.Visible = true;
                Payment_btn.Visible = true;
                Help_btn.Visible = true;
                Logo_btn.Visible = true;

                //User Button
                Login_btn.Visible = false;
                register_btn.Visible = false;
                profile_btn.Visible = true;
                profile_DDL.Visible = true;
                cart_btn.Visible = true;

                //Admin Button
                Product_btn.Visible = false;
                Delivery_btn.Visible = false;
                Promotion_btn.Visible = false;
                Logout_Admin_btn.Visible = false;
                Logo_Admin_btn.Visible = false;
            }
            else if (Session["UserType_Name"].ToString() == "Admin")
            {
                //Visitor Button
                Main_btn.Visible = false;
                ShopMain_btn.Visible = false;
                Shop_DDL.Visible = false;
                ArticleMain_btn.Visible = false;
                Article_DDL.Visible = false;
                Payment_btn.Visible = false;
                Help_btn.Visible = false;
                Logo_btn.Visible = false;

                //User Button
                Login_btn.Visible = false;
                register_btn.Visible = false;
                profile_btn.Visible = false;
                profile_DDL.Visible = false;
                cart_btn.Visible = false;

                //Admin Button
                Product_btn.Visible = true;
                Delivery_btn.Visible = true;
                Promotion_btn.Visible = true;
                Logout_Admin_btn.Visible = true;
                Logo_Admin_btn.Visible = true;
            }
        }
        else
        {
            //Visitor Button
            Main_btn.Visible = true;
            ShopMain_btn.Visible = true;
            Shop_DDL.Visible = true;
            ArticleMain_btn.Visible = true;
            Article_DDL.Visible = true;
            Payment_btn.Visible = true;
            Help_btn.Visible = true;
            Logo_btn.Visible = true;

            //User Button
            Login_btn.Visible = true;
            register_btn.Visible = true;
            profile_btn.Visible = false;
            profile_DDL.Visible = false;
            cart_btn.Visible = false;

            //Admin Button
            Product_btn.Visible = false;
            Delivery_btn.Visible = false;
            Promotion_btn.Visible = false;
            Logout_Admin_btn.Visible = false;
            Logo_Admin_btn.Visible = false;
        }

    }

    protected void Logout_btn_OnClick(object sender, EventArgs e)
    {
        SessionClear("~/main.aspx");
    }

    protected void Logout_Admin_btn_Click(object sender, EventArgs e)
    {
        SessionClear("~/main.aspx");
    }

    private void SessionClear(string i)
    {
        Session.Clear();
        Response.Redirect(i);
    }
}
