<%@ Page Language="C#" MasterPageFile="~/Master_Navigation.master" AutoEventWireup="true" CodeFile="Admin_Delivery.aspx.cs" Inherits="Pages_Admin_Delivery" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br />
    <br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br />
    <br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br />

    <link rel="stylesheet" href="../../../styles/style.css" />
    <div>
      <link href="../../../styles/Admin_Delivery.css" rel="stylesheet" />

      <div class="admin-delivery-master-container">
        <div class="admin-delivery-master-admin-delivery-master">
          <img
            src="../../../public/external/bodyview2806-wes-2000w.png"
            alt="bodyview2806"
            class="admin-delivery-master-bodyview" style="left: 0px; top: -1px"
          />
          <div class="admin-delivery-master-deliverybox">
            <div class="admin-delivery-master-regisitem">
              <div class="admin-delivery-master-product-sex1">
                <span class="admin-delivery-master-text06">
                  <span>DeliveryStatus</span>
                </span>
                  <asp:CheckBox class="admin-delivery-master-button3" AutoPostBack="true" ID="DeliveryStatus_Finish" runat="server" style="transform: scale(2);"  OnCheckedChanged="DeliveryStatus_Finish_CheckedChanged" Text="Finish" Font-Size="12" />
                  <asp:CheckBox class="admin-delivery-master-button4" AutoPostBack="true" ID="DeliveryStatus_Shipping" runat="server" style="transform: scale(2);" OnCheckedChanged="DeliveryStatus_Shipping_CheckedChanged" Text="Shipping" Font-Size="12" />
                  <asp:CheckBox class="admin-delivery-master-button5" AutoPostBack="true" ID="DeliveryStatus_Check" runat="server" style="transform: scale(2);" OnCheckedChanged="DeliveryStatus_Check_CheckedChanged" Text="Check" Font-Size="12" />
              </div>
              <div class="admin-delivery-master-product-id">
                  <asp:TextBox class="admin-delivery-master-rectangle2" ID="UserID_TxtBox" BackColor="LightGray" ReadOnly="true" Font-Size="42px" runat="server"></asp:TextBox>
                <span class="admin-delivery-master-text16">
                  <span>UserID</span>
                </span>
              </div>
              <div class="admin-delivery-master-product-id1">
                  <asp:TextBox class="admin-delivery-master-rectangle21" ID="OrderID_TxtBox" BackColor="LightGray" ReadOnly="true" Font-Size="42px" runat="server"></asp:TextBox>
                <span class="admin-delivery-master-text18">
                  <span>OrderID</span>
                </span>
              </div>
              <div class="admin-delivery-master-product-id2">
                  <asp:TextBox class="admin-delivery-master-rectangle22" ID="AdressID_TxtBox" BackColor="LightGray" ReadOnly="true" Font-Size="42px" runat="server"></asp:TextBox>
                <span class="admin-delivery-master-text20">
                  <span>AdressID
                  </span>
                </span>
              </div>
              <div class="admin-delivery-master-product-id3">
                  <asp:TextBox class="admin-delivery-master-rectangle23" ID="TotalPrice_TxtBox" BackColor="LightGray" ReadOnly="true" Font-Size="42px" runat="server"></asp:TextBox>
                <span class="admin-delivery-master-text22">
                  <span>TotalPrice</span>
                </span>
              </div>
              <div class="admin-delivery-master-product-id4" style="height: 508px; left: 0px; top: 1307px">
                  <asp:GridView ID="GridView1" class="admin-delivery-master-rectangle24" runat="server" style="left: 0px; right: 5px; top: 36px; margin-bottom: 300px" AutoGenerateColumns="False" DataKeyNames="Orders_ID" DataSourceID="SqlDataSource1">
                      <Columns>
                          <asp:BoundField DataField="Orders_ID" HeaderText="Orders_ID" InsertVisible="False" ReadOnly="True" SortExpression="Orders_ID" />
                          <asp:BoundField DataField="Orders_TotalPrice" HeaderText="Orders_TotalPrice" SortExpression="Orders_TotalPrice" />
                          <asp:BoundField DataField="Orders_RegisDate" HeaderText="Orders_RegisDate" SortExpression="Orders_RegisDate" />
                          <asp:BoundField DataField="Users_ID" HeaderText="Users_ID" SortExpression="Users_ID" />
                          <asp:BoundField DataField="Payment_ID" HeaderText="Payment_ID" SortExpression="Payment_ID" />
                          <asp:BoundField DataField="OrderStatus_ID" HeaderText="OrderStatus_ID" SortExpression="OrderStatus_ID" />
                          <asp:BoundField DataField="Delivery_ID" HeaderText="Delivery_ID" SortExpression="Delivery_ID" />
                      </Columns>
                  </asp:GridView>
                  <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BettaFishDBConnectionString %>" SelectCommand="SELECT [Orders_ID], [Orders_TotalPrice], [Orders_RegisDate], [Users_ID], [Payment_ID], [OrderStatus_ID], [Delivery_ID] FROM [Orders]"></asp:SqlDataSource>
                  <span class="admin-delivery-master-text24">
                  <span>ProductIdOfOrdersId</span>
                </span>
              </div>
              <div class="admin-delivery-master-product-id7">
                  <asp:Label ID="show_img" class="admin-delivery-master-rectangle27" runat="server" Text="s"></asp:Label>
                <span class="admin-delivery-master-text30">
                  <span>ImagePayment</span>
                </span>
              </div>
              <div class="admin-delivery-master-registergroup">
                <span class="admin-delivery-master-text32">
                  <span>
                      <asp:LinkButton ID="EditData_btn" ForeColor="White" OnClick="EditData_btn_Click" runat="server">แก้ไขข้อมูล</asp:LinkButton>
                  </span>
                </span>
              </div>
              <div class="admin-delivery-master-registergroup1">
                <span class="admin-delivery-master-text34">
                  <span>
                      <asp:LinkButton ID="ProductDetail_btn" ForeColor="White" PostBackUrl="~/Pages/Admin/Admin_Order.aspx" runat="server">ดูสต็อกสินค้า</asp:LinkButton>
                  </span>
                </span>
              </div>
              <div class="admin-delivery-master-group137">
                <div class="admin-delivery-master-product-id8">
                    <asp:TextBox class="admin-delivery-master-rectangle28" ID="SearchOrderID_TxtBox" Font-Size="42px" runat="server"></asp:TextBox>
                  <span class="admin-delivery-master-text36">
                    <span>SearchOrderID</span>
                  </span>
                </div>
                <div class="admin-delivery-master-registergroup2">
                  <span class="admin-delivery-master-text38">
                    <span>
                        <asp:LinkButton ID="SearchData_btn" ForeColor="White" OnClick="SearchData_btn_Click" runat="server">ค้นหาข้อมูล</asp:LinkButton>
                    </span>
                  </span>
                </div>
              </div>
            </div>
            <span class="admin-delivery-master-text40">
              <span>จัดการ “การจัดส่ง”</span>
            </span>
          </div>
        </div>
      </div>
    </div>
</asp:Content>
