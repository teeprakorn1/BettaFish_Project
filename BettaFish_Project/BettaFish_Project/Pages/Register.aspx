<%@ Page Language="C#" MasterPageFile="~/Master_Navigation.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Pages_Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br />


    <link rel="stylesheet" href="../styles/style.css" />
    <div>
      <link href="../styles/register.css" rel="stylesheet" />

      <div class="register-master-container">
        <div class="register-master-register-master">
          <img
            src="../public/external/bodyview6263-toak-1500h.png"
            alt="bodyview6263"
            class="register-master-bodyview"
          />
          <div class="register-master-regisitem">
            <div class="register-master-registergroup">
              <span class="register-master-text">
                  <asp:LinkButton ID="Register_btn" ForeColor="White" runat="server" OnClick="Register_btn_Click">สมัครสมาชิก</asp:LinkButton>
              </span>
            </div>
            <div class="register-master-confirm-password">
              <asp:TextBox class="register-master-rectangle2" ID="ConfirmPassword_TxtBox" Font-Size="42px" TextMode="Password" runat="server"></asp:TextBox>
              <span class="register-master-text02">
                <span>Confirm Password</span>
              </span>
            </div>
            <div class="register-master-password">
                <asp:TextBox class="register-master-rectangle21" ID="Password_TxtBox" Font-Size="42px" TextMode="Password" runat="server"></asp:TextBox>
              <span class="register-master-text04"><span>Password</span></span>
            </div>
            <div class="register-master-email">
                <asp:TextBox class="register-master-rectangle22" ID="Email_TxtBox" Font-Size="42px" TextMode="Email" runat="server"></asp:TextBox>
              <span class="register-master-text06"><span>E-mail</span></span>
            </div>
            <div class="register-master-user-name">
                <asp:TextBox class="register-master-rectangle23" ID="Username_TxtBox" Font-Size="42px" runat="server"></asp:TextBox>
              <span class="register-master-text08">UesrName</span>
            </div>
            <div class="register-master-create-text">
              <span class="register-master-text09">
                <span>Create Your account</span>
              </span>
            </div>
          </div>
        </div>
      </div>
    </div>
</asp:Content>