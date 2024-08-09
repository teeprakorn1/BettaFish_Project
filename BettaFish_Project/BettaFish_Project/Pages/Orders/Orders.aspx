<%@ Page Title="" Language="C#" MasterPageFile="~/Master_Navigation.master" AutoEventWireup="true" CodeFile="Orders.aspx.cs" Inherits="Pages_Orders" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <br /><br /><br /><br /><br /><br /><br /><br /><br />
    <br /><br /><br /><br /><br />

    <link rel="stylesheet" href="../../../../styles/NewStyle.css" />
    <div class="HD">Order</div>
    <br />
    <div class="Heardnong">
        <table style="width:100%;">
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="height: 31px">
                    <asp:Label ID="address_lbl" runat="server" Text="ที่อยู่จัดส่ง" style="font-size: 40px"></asp:Label>
                </td>
                <td style="height: 31px">
                    <asp:DropDownList ID="Address_ddl" runat="server" Height="80px" Width="1000px" AppendDataBoundItems="True" AutoPostBack="True" OnSelectedIndexChanged="Address_ddl_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
                <td style="height: 31px">
                    <asp:DropDownList ID="DeliveryType_ddl" runat="server" Height="80px" style="margin-left: 0" Width="400px" AppendDataBoundItems="True" AutoPostBack="True">
                        <asp:ListItem Value="1">Kerry</asp:ListItem>
                        <asp:ListItem Value="2">EMS</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td style="height: 31px">
                    
                </td>
            </tr>
        </table>
    </div>
    <br />
    <div>

        <asp:Label ID="show_lbl" runat="server" style="font-size: 40px" Text="show_lbl"></asp:Label>

    </div>
    <br />
    <br />
    <div class="ngong">
                <asp:Label ID="Label2" runat="server" style="font-size: 30px" Text="โปรโมชั่น(Promotion)"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            &nbsp;<asp:TextBox ID="Promotion_Txtbox" runat="server"  Width="800px" Height="61px" OnTextChanged="Promotion_Txtbox_TextChanged"></asp:TextBox>
            &nbsp;&nbsp;&nbsp; <asp:Button ID="PromotionUse_btn" style="font-size: 30px" runat="server" Text="USE" Height="60px" Width="150px" OnClick="PromotionUse_btn_Click" />
            &nbsp;<asp:Label ID="Error_lbl" runat="server" style="font-size: 30px" Text=""></asp:Label>

            </div>
    <br />
    <br />
    <div class="Tomyum">
        <div class="BankIMG" style="text-align: left">
        <div class="BMGG"><img src="../../../public/KBANK.jpg" style="width: 274px; height: 215px" />&nbsp;
            <div class="Raka"></div>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;<asp:Label ID="Label9" runat="server" Text="1-1005-752-88" style="font-size: 30px"></asp:Label>
                <br />
            <br />
            <asp:FileUpload ID="FileUpload1" runat="server" Height="50px" style="margin-left: 82px;font-size: 20px" Width="180px" />
&nbsp;&nbsp;<asp:Button ID="Button1" runat="server" font-size="30px" Text="อัปโหลด" Height="55px" Width="159px" OnClick="Button1_Click" />
            <div class="Raka">
                <br />
                <br />
                <br />
                <br />
                <asp:Label ID="Label7" runat="server" Text="จำนวนสินค้า: " style="font-size: 30px"></asp:Label>
                <asp:Label ID="TotalAmount_lbl" runat="server" style="font-size: 30px" Text="Label"></asp:Label>
                <br />
                <asp:Label ID="Label1" runat="server" Text="รวมการสั่งซื้อ: " style="font-size: 30px"></asp:Label>&nbsp;<asp:Label ID="TotalPrice_lbl" runat="server" style="font-size: 30px" Text="Label"></asp:Label>
                &nbsp;</div>

            <div class="Raka"><asp:Label ID="Label3" runat="server" Text="ยอดชำระเงินทั้งหมด: " style="font-size: 30px"></asp:Label>&nbsp;<asp:Label ID="TotalAll_lbl" runat="server" style="font-size: 30px" Text="Label"></asp:Label>
            </div>
        </div>
    </div>
        <br />
    <br />
    <div class="BTPAYAGAIN" style="text-align: right">
                <asp:Button ID="MakeOrder_btn" runat="server" font-size="40px" Text="ชำระเงิน" Height="80px" Width="200px" OnClick="MakeOrder_btn_Click" />
            </div>
    </div>
    <br />

    </asp:Content>
