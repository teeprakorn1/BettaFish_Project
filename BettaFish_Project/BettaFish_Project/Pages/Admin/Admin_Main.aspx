<%@ Page Language="C#" MasterPageFile="~/Master_Navigation.master" AutoEventWireup="true" CodeFile="Admin_Main.aspx.cs" Inherits="Pages_Admin_Admin_Main" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br /><br /><br /><br /><br /><br /><br />



    <link rel="stylesheet" href="../../../styles/style.css" />
    <div>
       <link href="../../../styles/Admin_main.css" rel="stylesheet" />

      <div class="admin-main-master-container">
        <div class="admin-main-master-admin-main-master">
          <img
            src="../../../public/external/bodyview2464-uo74-2000w.png"
            alt="bodyview2464"
            class="admin-main-master-bodyview"
          />
          <div class="admin-main-master-regisitem">
            <div class="admin-main-master-registergroup">
              <span class="admin-main-master-text">
                  <asp:LinkButton ID="Promotion_btn" ForeColor="White" runat="server" PostBackUrl="../../../../Pages/Admin/Admin_Promotion_Edit.aspx">จัดการ โปรโมชั่น</asp:LinkButton>
              </span>
            </div>
            <div class="admin-main-master-registergroup1">
              <span class="admin-main-master-text1">
                  <asp:LinkButton ID="Product_btn" ForeColor="White" runat="server" PostBackUrl="../../../Pages/Admin/Admin_Product_Add.aspx">จัดการ สินค้า</asp:LinkButton>
              </span>
            </div>
            <div class="admin-main-master-registergroup2">
              <span class="admin-main-master-text2">
                <span>
                    <asp:LinkButton ID="Delivery_btn" ForeColor="White" runat="server" PostBackUrl="../../../Pages/Admin/Admin_Delivery.aspx">จัดการ การจัดส่ง</asp:LinkButton>
                </span>
              </span>
            </div>
            <span class="admin-main-master-text4">Hello Admin</span>
          </div>
        </div>
      </div>
    </div>
</asp:Content>
