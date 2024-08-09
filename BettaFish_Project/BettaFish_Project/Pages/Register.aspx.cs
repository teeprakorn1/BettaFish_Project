using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Register : System.Web.UI.Page
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

    }

    protected void Register_btn_Click(object sender, EventArgs e)
    {
        int RegisterResult;
        String Password_Result = null;
        String Script = null;
        ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", Script, true);

        if (Username_TxtBox.Text != "" && Email_TxtBox.Text !="" && Password_TxtBox.Text != "" && ConfirmPassword_TxtBox.Text != "") 
        { 
            if (Password_TxtBox.Text == ConfirmPassword_TxtBox.Text)
            {
                Password_Result = Password_TxtBox.Text;
                RegisterResult = ConnectionClass.RegisterUser(Username_TxtBox.Text, Password_Result, Email_TxtBox.Text);
                if (RegisterResult == 1)
                {
                    Script = "Register Success!!";
                    MsgBox(Script, this.Page, this);
                    Response.Redirect("~/Pages/Login.aspx");
                }
                else
                {
                    Username_TxtBox.Text = "";
                    Email_TxtBox.Text = "";
                    Password_TxtBox.Text = "";
                    ConfirmPassword_TxtBox.Text = "";
                    Script = "This username already exists!!";
                    MsgBox(Script, this.Page, this);
                }
            }
            else
            {
                Password_Result = null;
                Password_TxtBox.Text = "";
                ConfirmPassword_TxtBox.Text = "";
                Script = "Password doesn't match!!";
                MsgBox(Script, this.Page, this);
            }
        }
        else
        {
            Script = "Enter Your User OR Password OR Email !!";
            MsgBox(Script, this.Page, this);
        }
    }
}