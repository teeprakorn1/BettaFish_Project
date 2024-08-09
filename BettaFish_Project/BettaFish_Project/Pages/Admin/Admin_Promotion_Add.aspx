<%@ Page Language="C#" MasterPageFile="~/Master_Navigation.master" AutoEventWireup="true" CodeFile="Admin_Promotion_Add.aspx.cs" Inherits="Pages_Admin_Admin_Promotion_Add" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br /><br /><br /><br /><br /><br /><br /><br />



    <link rel="stylesheet" href="../../../styles/style.css" />
    <div>
      <link href="../../../styles/Admin_Promotion_Add.css" rel="stylesheet" />

      <div class="admin-add-promotion-master-container">
        <div class="admin-add-promotion-master-admin-add-promotion-master">
          <img
            src="../../../public/external/bodyview2809-enf8-1200h.png"
            alt="bodyview2809"
            class="admin-add-promotion-master-bodyview"
          />
          <div class="admin-add-promotion-master-regisitem">
            <div class="admin-add-promotion-master-product-id">
              <asp:TextBox class="admin-add-promotion-master-rectangle2" ID="PromotionCode_TxtBox" Font-Size="42px" runat="server"></asp:TextBox>
              <span class="admin-add-promotion-master-text">
                <span>PromotionCode</span>
              </span>
            </div>
            <div class="admin-add-promotion-master-product-id1">
              <asp:TextBox class="admin-add-promotion-master-rectangle21" ID="PromotionPercent_TxtBox" Font-Size="42px" runat="server"></asp:TextBox>
              <span class="admin-add-promotion-master-text2">
                <span>PromotionPercent</span>
              </span>
            </div>
            <div class="admin-add-promotion-master-registergroup">
              <span class="admin-add-promotion-master-text4">
                <span>
                    <asp:LinkButton ID="AddPromotion_btn" ForeColor="White" OnClick="AddPromotion_btn_Click" runat="server">เพิ่มโปรโมชั่น</asp:LinkButton>
                </span>
              </span>
            </div>
            <span class="admin-add-promotion-master-text6">
              <span>จัดการ “เพิ่ม โปรโมชั่น”</span>
            </span>
          </div>
        </div>
      </div>
    </div>
</asp:Content>
