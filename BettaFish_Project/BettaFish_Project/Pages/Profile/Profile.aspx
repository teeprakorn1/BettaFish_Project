<%@ Page Language="C#" MasterPageFile="~/Master_Navigation.master" AutoEventWireup="true" CodeFile="Profile.aspx.cs" Inherits="Pages_Profile_Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br />
    <br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br />


    <link rel="stylesheet" href="../../../styles/style.css"/>
    <div>
      <link href="../../../styles/Profile.css" rel="stylesheet" />

      <div class="address-master-container">
        <div class="address-master-address-master">
          <div class="address-master-low-bar">
            <span class="address-master-text">
              © BETTA THAI All rights reserved.
            </span>
          </div>
          <div class="address-master-group131">
            <span class="address-master-text01">
              <span>แก้ไขโปรไฟล์ของคุณ</span>
            </span>
            <img
              src="../../../public/external/image15197-j0m-300h.png"
              alt="image15197"
              class="address-master-image1"
            />
            <div class="address-master-frame">
                <asp:TextBox class="address-master-rectangle2" ID="FName_TxtBox" Font-Size="42px" runat="server"></asp:TextBox>
              <span class="address-master-text03"><span>ชื่อจริง</span></span>
            </div>
            <div class="address-master-frame1">
              <asp:TextBox class="address-master-rectangle21" ID="LName_TxtBox" Font-Size="42px" runat="server"></asp:TextBox>
              <span class="address-master-text05"><span>นามสกุล</span></span>
            </div>
            <div class="address-master-frame2">
              <asp:TextBox class="address-master-rectangle22" ID="Phone_TxtBox" Font-Size="42px" TextMode="Phone" runat="server"></asp:TextBox>
              <span class="address-master-text07"><span>เบอร์โทร</span></span>
            </div>
            <div class="address-master-registergroup">
              <span class="address-master-text09">
                  <asp:LinkButton ID="Finish_btn" ForeColor="White" OnClick="Finish_btn_Click" runat="server">เสร็จสิ้น</asp:LinkButton>
              </span>
            </div>
            <div class="address-master-registergroup1">
              <span class="address-master-text11">
                  <asp:LinkButton ID="EditDelivery_btn" ForeColor="White" OnClick="EditDelivery_btn_Click" runat="server">แก้ไขที่จัดส่ง</asp:LinkButton>
              </span>
            </div>
            <div class="address-master-registergroup2">
              <span class="address-master-text12">
                <asp:LinkButton ID="AddDelivery_btn" ForeColor="White" OnClick="AddDelivery_btn_Click"  runat="server">เพิ่มที่จัดส่ง</asp:LinkButton>
                </span>
            </div>
            <div class="address-master-product-category">
                <asp:DropDownList class="address-master-rectangle23" ID="Delivery_DDL" Font-Size="42px" runat="server" OnTextChanged="Delivery_DDL_TextChanged" AppendDataBoundItems="True" AutoPostBack="True">
                  </asp:DropDownList>
              <span class="address-master-text13">
                <span>เลือกที่จัดส่ง</span>
              </span>
            </div>
          </div>
          <div class="address-master-group132">
            <span class="address-master-text15">
              <span>แก้ไขข้อมูลโปรไฟล์</span>
            </span>
          </div>
        </div>
      </div>
    </div>
</asp:Content>