<%@ Page Language="C#" MasterPageFile="~/Master_Navigation.master" AutoEventWireup="true" CodeFile="Edit_Delivery.aspx.cs" Inherits="Pages_Profile_Delivery_Edit_Delivery" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br />
    <br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br />

    <link rel="stylesheet" href="../../../styles/style.css"/>
    <div>
      <link href="../../../styles/Edit_Delivery.css" rel="stylesheet" />

      <div class="address-master-container">
        <div class="address-master-address-master">
          <div class="address-master-low-bar">
            <span class="address-master-text">
              <span>© BETTA THAI All rights reserved.</span>
            </span>
          </div>
          <div class="address-master-group131">
            <span class="address-master-text02">
                <span>
                    <asp:Label ID="Showlbl" runat="server" Text=""></asp:Label>
                </span>
            </span>
            <span class="address-master-text04">
              <span>แก้ไขข้อมูลจัดส่งของคุณ</span>
            </span>
            <div class="address-master-registergroup">
              <span class="address-master-text06">
                  <asp:LinkButton ID="EditData_btn" ForeColor="White" OnClick="EditData_btn_Click1" runat="server">แก้ไขข้อมูล</asp:LinkButton>
              </span>
            </div>
            <div class="address-master-registergroup1">
              <span class="address-master-text08">
                <asp:LinkButton ID="AddData_btn" ForeColor="White" OnClick="AddData_btn_Click" runat="server">เพิ่มที่จัดส่ง</asp:LinkButton>
              </span>
            </div>
            <div class="address-master-registergroup2">
              <span class="address-master-text10">
                  <asp:LinkButton ID="DeleteData_btn" ForeColor="White" OnClick="DeleteData_btn_Click" runat="server">ลบข้อมูล</asp:LinkButton>
              </span>
            </div>
            <div class="address-master-product-category">
                <asp:DropDownList class="address-master-rectangle2" ID="Delivery_DDL" OnTextChanged="Delivery_DDL_TextChanged" Font-Size="42px" AutoPostBack="true" runat="server" AppendDataBoundItems="True">
                    <asp:ListItem>กรุณาเลือกข้อมูลจัดส่ง</asp:ListItem>
                  </asp:DropDownList>

              <span class="address-master-text12">
                <span>เลือกที่จัดส่ง</span>
              </span>
            </div>
            <div class="address-master-frame">
                <asp:TextBox class="address-master-rectangle21" ID="AddressDetail_TxtBox" Font-Size="42px" runat="server" TextMode="MultiLine"></asp:TextBox>
              <span class="address-master-text14">
                <span>ข้อมูลจัดส่ง</span>
              </span>
            </div>
            <div class="address-master-frame1">
                <asp:TextBox class="address-master-rectangle22" ID="AddressName_TxtBox" Font-Size="42px" runat="server"></asp:TextBox>
              <span class="address-master-text16">
                <span>ชื่อที่จัดส่งของเรา</span>
              </span>
            </div>
          </div>
          <div class="address-master-group132">
            <span class="address-master-text18">
              <span>แก้ไขข้อมูลจัดส่ง</span>
            </span>
          </div>
        </div>
      </div>
    </div>
</asp:Content>