using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Login : System.Web.UI.Page
{
    private void MsgBox(String ex, Page pg, Object obj)
    {
        string s = "<SCRIPT language='javascript'>alert('" + ex.Replace("\r\n", "\\n").Replace("'", "") + "'); </SCRIPT>";
        Type cstype = obj.GetType();
        ClientScriptManager cs = pg.ClientScript;
        cs.RegisterClientScriptBlock(cstype, s, s.ToString());
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserID"] != null)
        {
            Response.Redirect("~/main.aspx");
        }
    }

    protected void Login_btn_Click(object sender, EventArgs e)
    {
        User user = ConnectionClass.UserLogin(Username_TxtBox.Text, Password_TxtBox.Text);
        if (user != null)
        {
            Session["UserID"] = user.Users_ID;
            Session["UserName"] = user.Users_Username;
            Session["UserType_Name"] = user.UserType_Name;
            Session["UserEmail"] = user.Users_Email;
            Session["UsersActiveStatus"] = user.Users_ActiveStatus;
            String Script = "Login Success!!";
            MsgBox(Script, this.Page, this);
            if (user.UserType_Name == "User")
            {
                Response.Redirect("~/main.aspx");
            }
            else if(user.UserType_Name == "Admin")
            {
                Response.Redirect("~/Pages/Admin/Admin_Main.aspx");
            }
        }
        else
        {
            String Script = "Username OR Password is incorrect.!!";
            MsgBox(Script, this.Page, this);
        }
    }
}