<%@ Page Title="" Language="C#" MasterPageFile="~/Master_Navigation.master" AutoEventWireup="true" CodeFile="ShopSearch.aspx.cs" Inherits="Pages_Shop_ShopSearch" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br />
       
    <link rel="stylesheet" href="../../styles/NewStyle.css" />
  <div class="Allfish">
      <div class="BannerFishShop">
        <strong class="bettafish-title">BettaFish Shop<br /></strong>
        <strong class="bettafish01-title">What are you looking for?<br />
          <br /></strong>
            <div class="SBfishShop"><asp:TextBox ID="TextBox1" class="SBfishShop_SeacrhBox" clientidmode="Static" OnTextChanged="TextBox1_TextChanged" PlaceHolder="Search for the product you want to find" Font-Size="26px" runat="server" Width="976px" style="margin-left: 0px"></asp:TextBox>
            </div>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="ค้นหา" Height="36px" Width="239px" OnClick="Button1_Click" /></div>
        </div>
    <br />
    <div class="ItemfishShop" style="text-align: left">
        <p style="margin-left: 40px">
            Search Result.</p>
    </div>
    <br />
    <br />
    <div class="fish-container">
            <asp:Label id="show_lbl" runat="server" Text="show_lbl"></asp:Label>
            <br />
            <br />
            <br />
            <br />
    </div>
    

</asp:Content>

