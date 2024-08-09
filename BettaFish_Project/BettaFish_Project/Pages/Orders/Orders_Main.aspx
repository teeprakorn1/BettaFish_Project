<%@ Page Title="" Language="C#" MasterPageFile="~/Master_Navigation.master" AutoEventWireup="true" CodeFile="Orders_Main.aspx.cs" Inherits="Pages_Orders_Orders_Main" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br />
     <br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br />

    <link rel="stylesheet" href="../../../styles/style.css"/>
    <div>
      <link href="../../../styles/Orders_Main.css" rel="stylesheet" />

      <div class="address-master-container">
        <div class="address-master-address-master">
          <div class="address-master-low-bar">
            <span class="address-master-text">
              <span>© BETTA THAI All rights reserved.</span>
            </span>
          </div>
          <div class="address-master-group131">
            &nbsp;<span class="address-master-text04"><span>ออเดอร์ของฉัน</span>
            </span>
            <div class="address-master-product-category">
                <asp:DropDownList class="address-master-rectangle2" ID="Delivery_DDL" OnTextChanged="Delivery_DDL_TextChanged" Font-Size="42px" runat="server" AppendDataBoundItems="True" AutoPostBack="True" style="left: 0px; right: 0px; top: 51px" OnSelectedIndexChanged="Delivery_DDL_SelectedIndexChanged">
                    <asp:ListItem Value="0">เลือกออเดอร์ของคุณ</asp:ListItem>
                  </asp:DropDownList>
              <span class="address-master-text08">
                <span>เลือกออเดอร์</span>
              </span>
              <img
                src="../../../public/external/vector5387-gow.svg"
                alt="Vector5387"
                class="address-master-vector"
              />
            </div>
            <div class="address-master-frame">
                <asp:TextBox class="address-master-rectangle21" ID="TextBox1" Font-Size="42px" runat="server" BackColor="LightGray" ReadOnly="true" ></asp:TextBox>
              <span class="address-master-text10"><span>OrdersID</span></span>
            </div>
            <div class="address-master-frame1">
                <asp:TextBox class="address-master-rectangle3" ID="TextBox2" Font-Size="42px" runat="server" BackColor="LightGray" ReadOnly="true"></asp:TextBox>
              <span class="address-master-text12">
                <span>สถานะจัดส่ง</span>
              </span>
            </div>
          </div>
          <div class="address-master-group132">
            <span class="address-master-text14">
              <span>ออเดอร์ของฉัน</span>
            </span>
          </div>
        </div>
      </div>
    </div>
</asp:Content>

