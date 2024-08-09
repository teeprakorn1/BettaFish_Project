<%@ Page Language="C#" MasterPageFile="~/Master_Navigation.master" AutoEventWireup="true" CodeFile="Admin_Order.aspx.cs" Inherits="Pages_Admin_Admin_Order" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br />
    <br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br />

    <link rel="stylesheet" href="../../../styles/style.css" />
    <div>
      <link href="../../../styles/Admin_Order.css" rel="stylesheet" />

      <div class="admin-delivery-master-container">
        <div class="admin-delivery-master-admin-delivery-master">
          <img
            src="../../../public/external/bodyview3717-j2w9-2000w.png"
            alt="bodyview3717"
            class="admin-delivery-master-bodyview"
          />
          <div class="admin-delivery-master-deliverybox">
            <div class="admin-delivery-master-regisitem">
              <div class="admin-delivery-master-product-id">
                

                  <asp:GridView ID="GridView1" class="admin-delivery-master-rectangle2" runat="server" AutoGenerateColumns="False" DataKeyNames="Product_ID" DataSourceID="SqlDataSource1" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal">
                      <Columns>
                          <asp:BoundField DataField="Product_ID" HeaderText="Product_ID" InsertVisible="False" ReadOnly="True" SortExpression="Product_ID" />
                          <asp:BoundField DataField="Product_Name" HeaderText="Product_Name" SortExpression="Product_Name" />
                          <asp:BoundField DataField="Product_Price" HeaderText="Product_Price" SortExpression="Product_Price" />
                          <asp:BoundField DataField="Product_Detail" HeaderText="Product_Detail" SortExpression="Product_Detail" />
                          <asp:BoundField DataField="Product_Equipment_Amount" HeaderText="Product_Equipment_Amount" SortExpression="Product_Equipment_Amount" />
                          <asp:BoundField DataField="Product_Male_Amount" HeaderText="Product_Male_Amount" SortExpression="Product_Male_Amount" />
                          <asp:BoundField DataField="Product_Female_Amount" HeaderText="Product_Female_Amount" SortExpression="Product_Female_Amount" />
                          <asp:BoundField DataField="Product_ActiveStatus" HeaderText="Product_ActiveStatus" SortExpression="Product_ActiveStatus" />
                      </Columns>
                      <FooterStyle BackColor="White" ForeColor="#333333" />
                      <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                      <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                      <RowStyle BackColor="White" ForeColor="#333333" />
                      <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                      <SortedAscendingCellStyle BackColor="#F7F7F7" />
                      <SortedAscendingHeaderStyle BackColor="#487575" />
                      <SortedDescendingCellStyle BackColor="#E5E5E5" />
                      <SortedDescendingHeaderStyle BackColor="#275353" />
                  </asp:GridView>

                  <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BettaFishDBConnectionString %>" SelectCommand="SELECT [Product_ID], [Product_Name], [Product_Price], [Product_Detail], [Product_Equipment_Amount], [Product_Male_Amount], [Product_Female_Amount], [Product_ActiveStatus] FROM [Product]"></asp:SqlDataSource>

                <span class="admin-delivery-master-text">
                  <span>ProductTable</span>
                </span>
              </div>
              <div class="admin-delivery-master-group137">
                <div class="admin-delivery-master-registergroup1">
                  <span class="admin-delivery-master-text06">
                    <span>
                        <asp:LinkButton ID="SearchData_btn" ForeColor="White" PostBackUrl="~/Pages/Admin/Admin_Delivery.aspx" runat="server" >ย้อนกลับ</asp:LinkButton>
                    </span>
                  </span>
                </div>
              </div>
            </div>
            <span class="admin-delivery-master-text08" style="left: 0px; right: 826px; top: 40px; width: 926px">
              <span>จัดการ “การจัดส่ง รายระเอียดออเดอร์”</span>
            </span>
          </div>
        </div>
      </div>
    </div>
</asp:Content>
