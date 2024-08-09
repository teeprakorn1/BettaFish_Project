<%@ Page Language="C#" MasterPageFile="~/Master_Navigation.master" AutoEventWireup="true" CodeFile="Admin_Promotion_Edit.aspx.cs" Inherits="Pages_Admin_Admin_Promotion_Edit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br />


    <link rel="stylesheet" href="../../../styles/style.css" />
    <div>
      <link href="../../../styles/Admin_Promotion_Edit.css" rel="stylesheet" />

      <div class="admin-edit-promotion-master-container">
        <div class="admin-edit-promotion-master-admin-edit-promotion-master">
          <img
            src="../../../public/external/bodyview2809-zlcx-1500h.png"
            alt="bodyview2809"
            class="admin-edit-promotion-master-bodyview"
          />
          <div class="admin-edit-promotion-master-regisitem">
            <span class="admin-edit-promotion-master-text">
              <span>จัดการ “แก้ไข โปรโมชั่น”</span>
            </span>
            <div class="admin-edit-promotion-master-table-of-promotion">
                <asp:TextBox class="admin-product-master-rectangle2" ID="SearchPromotion_TxtBox" Font-Size="42px" runat="server"></asp:TextBox>

             <div class="admin-product-master-registergroup1">
              <span class="admin-product-master-text38">
                  <asp:LinkButton ID="SearchData_btn" ForeColor="White" OnClick="SearchData_btn_Click" runat="server">ค้นหาข้อมูล</asp:LinkButton>
              </span>
            </div>

              <span class="admin-edit-promotion-master-text02">
                <span>SearchPromotionID</span>

              </span>
            </div>
            <div class="admin-edit-promotion-master-promotion-id">
              <asp:TextBox class="admin-edit-promotion-master-rectangle21" ID="PromotionID_TxtBox" BackColor="LightGray" ReadOnly="true" Font-Size="42px" runat="server"></asp:TextBox>
              <span class="admin-edit-promotion-master-text04">
                <span>PromotionID</span>
              </span>
            </div>
            <div class="admin-edit-promotion-master-promotion-code">
              <asp:TextBox class="admin-edit-promotion-master-rectangle22" ID="PromotionCode_TxtBox" Font-Size="42px" runat="server"></asp:TextBox>
              <span class="admin-edit-promotion-master-text06">
                <span>PromotionCode</span>
              </span>
            </div>
            <div class="admin-edit-promotion-master-promotion-percent">
              <asp:TextBox class="admin-edit-promotion-master-rectangle23" ID="PromotionPercent_TxtBox" Font-Size="42px" runat="server"></asp:TextBox>
              <span class="admin-edit-promotion-master-text08">
                <span>PromotionPercent</span>
              </span>
            </div>
            <div class="admin-edit-promotion-master-promotion-edit">
              <span class="admin-edit-promotion-master-text10">
                <span>
                    <asp:LinkButton ID="UpdatePromotion_btn" ForeColor="White" runat="server" OnClick="UpdatePromotion_btn_Click">แก้ไขโปรโมชั่น</asp:LinkButton>
                </span>
              </span>
            </div>
            <div class="admin-edit-promotion-master-promotion-add">
              <span class="admin-edit-promotion-master-text12">
                <span>
                    <asp:LinkButton ID="AddPromotion_btn" ForeColor="White" runat="server" OnClick="AddPromotion_btn_Click">เพิ่มโปรโมชั่น</asp:LinkButton>
                </span>
              </span>
            </div>
            <div class="admin-edit-promotion-master-promotion-status">
              <span class="admin-edit-promotion-master-text14">
                <span>PromotionStatus</span>
              </span>
                <asp:CheckBox class="admin-edit-promotion-master-button" ID="PromotionStatus_False" AutoPostBack="true" runat="server" style="transform: scale(2);" OnCheckedChanged="PromotionStatus_False_CheckedChanged" Text="False" Font-Size="12" />
                <asp:CheckBox class="admin-edit-promotion-master-button1" ID="PromotionStatus_True" AutoPostBack="true" runat="server" style="transform: scale(2);" OnCheckedChanged="PromotionStatus_True_CheckedChanged" Text="True" Font-Size="12" />

            </div>
          </div>
        </div>
      </div>
</asp:Content>
