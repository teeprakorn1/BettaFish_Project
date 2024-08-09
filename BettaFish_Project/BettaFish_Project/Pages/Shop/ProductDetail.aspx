<%@ Page Language="C#" MasterPageFile="~/Master_Navigation.master" AutoEventWireup="true" CodeFile="ProductDetail.aspx.cs" Inherits="Pages_Shop_ProductDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br /><br /><br />

    <link rel="stylesheet" href="../../../styles/style.css" />
    <div>
      <link href="../../../styles/ProductDetail.css" rel="stylesheet" />
        <asp:Label ID="ImageID_Txtbox"  runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="ProductID:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="productID_Txtbox" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="ชื่อสินค้า:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="productName_Txtbox" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="รายระเอียด:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="productDetail_Txtbox" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="ราคาสินค้า:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="productPrice_Txtbox" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Label ID="Animal_lbl" Visible="true"  runat="server">
        จำนวนของตัวผู้&nbsp;<asp:TextBox ID="MaleQuality_Txtbox" Text="0" runat="server" Width="30px"></asp:TextBox>
        <br />
        จำนวนของตัวเมีย&nbsp;<asp:TextBox ID="FemaleQuality_Txtbox" Text="0" runat="server" Width="30px"></asp:TextBox>
        <br />
        </asp:Label>
        <asp:Label ID="Item_lbl" runat="server">
        จำนวนของสินค้า&nbsp;<asp:TextBox ID="Item_Quality_Txtbox" Text="0" runat="server" Width="30px"></asp:TextBox>
         </asp:Label>
        <br />
        <br />
        <asp:Label ID="Error_lbl" runat="server" Visible="true" Text=""></asp:Label>
        <br />
        <br />
        <asp:Button ID="Return_btn" Class="Button" PostBackUrl="~/Pages/Shop/Shop_Fish.aspx" runat="server" Text="Return"/>
        <asp:Button ID="AddCart_btn" Class="Button" runat="server" OnClick="AddCart_btn_Click" Text="Add to Cart"/>
        <br />
        <br />
    </div>
</asp:Content>
