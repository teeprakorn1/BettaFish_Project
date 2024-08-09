<%@ Page Title="" Language="C#" MasterPageFile="~/Master_Navigation.master" AutoEventWireup="true" CodeFile="CartFish.aspx.cs" Inherits="Pages_Shop_CartFish" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br />

    <link rel="stylesheet" href="../../styles/NewStyle-1.css" />
    <div class="CartHeader">ตระกร้าสินค้า</div>
    <div class="CartShowP"><asp:Label ID="Showlbl" runat="server" Text=""></asp:Label></div>
           <br />
    <div style="text-align: center">
        <asp:Label ID="Clear_lbl" style="font-size: 30px;" runat="server" Text=""></asp:Label>
    </div>
<div class="PromoAdd">
    <div class="PromoUseBT"></div>
</div>

  <div class="ClearBT">
    <asp:Button ID="Clear_btn" style="font-size: 30px;" runat="server" Text="Clear" Height="57px" Width="167px" OnClick="Clear_btn_Click1" />
    <div class="PayBT">
        <asp:Label ID="Label3" style="font-size: 30px;" runat="server" Text="จำนวนสินค้า:"></asp:Label>
        &nbsp;
        <asp:Label ID="TotalAmount_lbl" style="font-size: 30px;" runat="server" Text="0"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label5" runat="server" style="font-size: 30px;" Text="ยอดรวม:"></asp:Label>
&nbsp;
                <asp:Label ID="TotalPrice_lbl" style="font-size: 30px;" runat="server" Text="0"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="MakeOrder_btn" runat="server" style="font-size: 30px;" Text="ชำระเงิน" Height="58px" Width="247px" OnClick="MakeOrder_btn_Click" />
        <br />
        <br />
    </div>
</div>
    
    
</asp:Content>

