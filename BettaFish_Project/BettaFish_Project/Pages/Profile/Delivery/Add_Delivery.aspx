<%@ Page Title="" Language="C#" MasterPageFile="~/Master_Navigation.master" AutoEventWireup="true" CodeFile="Add_Delivery.aspx.cs" Inherits="Pages_Profile_Delivery_Add_Delivery" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br />
    <br /><br /><br /><br /><br /><br /><br /><br /><br />

    <link rel="stylesheet" href="../../../styles/style.css"/>
    <div>
      <link href="../../../styles/Add_Delivery.css" rel="stylesheet" />

      <div class="address-master-container">
        <div class="address-master-address-master">
          <div class="address-master-low-bar">
            <span class="address-master-text">
              <span>© BETTA THAI All rights reserved.</span>
            </span>
          </div>
          <div class="address-master-group131">
            <span class="address-master-text02">
                <asp:Label ID="Label1" runat="server" Text=""></asp:Label></span>
            <span class="address-master-text04">
              <span>เพื่มข้อมูลจัดส่งของคุณ</span>
            </span>
            <div class="address-master-registergroup">
              <span class="address-master-text06">
                  <asp:LinkButton ID="Finish_btn" ForeColor="White" OnClick="Finish_btn_Click" runat="server">เพิ่มข้อมูล</asp:LinkButton>
              </span>
            </div>
            <div class="address-master-registergroup1">
              <span class="address-master-text08">
                  <asp:LinkButton ID="AddData_btn" ForeColor="White" OnClick="AddData_btn_Click" runat="server">แก้ไขข้อมูล</asp:LinkButton>
              </span>
            </div>
            <div class="address-master-frame">
                <asp:TextBox class="address-master-rectangle2" ID="AddressDetail_TxtBox" Font-Size="42px" runat="server" TextMode="MultiLine"></asp:TextBox>
              <span class="address-master-text10">
                <span>ข้อมูลจัดส่ง</span>
              </span>
            </div>
            <div class="address-master-frame1">
                <asp:TextBox class="address-master-rectangle21" ID="AddressName_TxtBox" Font-Size="42px" runat="server"></asp:TextBox>
              <span class="address-master-text12">
                <span>ชื่อของที่จัดส่ง</span>
              </span>
            </div>
          </div>
          <div class="address-master-group132">
            <span class="address-master-text14">
              <span>เพื่มข้อมูลจัดส่ง</span>
            </span>
          </div>
        </div>
      </div>
    </div>
</asp:Content>

