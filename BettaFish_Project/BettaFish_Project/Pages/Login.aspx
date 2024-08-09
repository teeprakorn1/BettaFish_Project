<%@ Page Language="C#" MasterPageFile="~/Master_Navigation.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Pages_Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br />


    <link rel="stylesheet" href="../styles/style.css"/>
    <div>
      <link href="../styles/login.css" rel="stylesheet" />

      <div class="login-master-container">
        <div class="login-master-login-master">
          <img
            src="../public/external/bodyview6237-kesu-2000w.png"
            alt="bodyview6237"
            class="login-master-bodyview"
          />
          <div class="login-master-loginitem">
            <div class="login-master-registext">
              <span class="login-master-text">
                  <span>
                      <asp:LinkButton ID="LinkButton1" ForeColor="60,150,150" runat="server" PostBackUrl="../../Pages/Register.aspx">Register</asp:LinkButton>
                  </span>
              </span>
              <span class="login-master-text02">
                <span>Don’t have account?</span>
              </span>
            </div>
            <img
              src="../public/external/rectangle856238-z7tq-200h.png"
              alt="Rectangle856238"
              class="login-master-rectangle85"
            />
            <div class="login-master-logingroup">
              <span class="login-master-text04">
                  <asp:LinkButton ID="Login_btn" ForeColor="White" runat="server" OnClick="Login_btn_Click">เข้าสู่ระบบ</asp:LinkButton>
              </span>
            </div>
            <div class="login-master-password-box-group">
                <asp:TextBox class="login-master-rectangle2" ID="Password_TxtBox" Font-Size="42px" TextMode="Password" runat="server"></asp:TextBox>
              <span class="login-master-text05"><span>PASSWORD</span></span>
            </div>
            <div class="login-master-username-box-group">
              <asp:TextBox class="login-master-rectangle21" ID="Username_TxtBox" Font-Size="42px" runat="server"></asp:TextBox>
              <span class="login-master-text07">USERNAME</span>
            </div>
            <div class="login-master-welcome-text-group">
              <span class="login-master-text08"><span>Login</span></span>
            </div>
          </div>
        </div>
      </div>
    </div>
</asp:Content>
 
