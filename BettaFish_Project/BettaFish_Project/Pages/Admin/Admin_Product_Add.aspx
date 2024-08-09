<%@ Page Language="C#" MasterPageFile="~/Master_Navigation.master" AutoEventWireup="true" CodeFile="Admin_Product_Add.aspx.cs" Inherits="Pages_Admin_Admin_Product_Add" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br />
      <br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br />
    <br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br />



    <link rel="stylesheet" href="../../../styles/style.css" />
    <div>
      <link href="../../../styles/Admin_Product_Add.css" rel="stylesheet" />

      <div class="admin-add-product-master-container">
        <div class="admin-add-product-master-admin-add-product-master">
          <img
            src="../../../public/external/bodyview2464-drq-2000w.png"
            alt="bodyview2464"
            class="admin-add-product-master-bodyview" style="margin-left: 0; left: 0px; top: -1px;"
          />
          <div class="admin-add-product-master-regisitem">
            <div class="admin-add-product-master-product-sub-category">
                <asp:DropDownList class="admin-add-product-master-rectangle2" ID="SubCategory_DDL" Font-Size="42px" AppendDataBoundItems="True" AutoPostBack="True" runat="server" style="left: 0px; top: 45px">
                    <asp:ListItem>Short</asp:ListItem>
                    <asp:ListItem>Long</asp:ListItem>
                    <asp:ListItem>ToolSub</asp:ListItem>
                    <asp:ListItem>OtherSub</asp:ListItem>
                  </asp:DropDownList>
              <span class="admin-add-product-master-text">
                <span>SubCategory</span>
              </span>
              <img
                src="../../../public/external/vector2464-hkf.svg"
                alt="Vector2464"
                class="admin-add-product-master-vector"
              />
            </div>
            <div class="admin-add-product-master-product-category">
                <asp:DropDownList class="admin-add-product-master-rectangle21" ID="Category_DDL" AppendDataBoundItems="True" AutoPostBack="True" Font-Size="42px" runat="server" >
                    <asp:ListItem>Animal</asp:ListItem>
                    <asp:ListItem>Tool</asp:ListItem>
                  </asp:DropDownList>
              <span class="admin-add-product-master-text02">
                <span>Category</span>
              </span>
              <img
                src="../../../public/external/vector2464-kpe.svg"
                alt="Vector2464"
                class="admin-add-product-master-vector1"
              />
            </div>
            <div class="admin-add-product-master-product-sex">
              <span class="admin-add-product-master-text04">
                <span>ProductType</span>
              </span>
                <asp:CheckBox class="admin-add-product-master-button" ID="ProductType_Item" runat="server" style="transform: scale(2);" Text="Item" AutoPostBack="true" Font-Size="12" OnCheckedChanged="ProductType_Item_CheckedChanged"/>
                <asp:CheckBox class="admin-add-product-master-button1" ID="ProductType_Animal" runat="server" style="transform: scale(2);" Text="Animal" AutoPostBack="true" Font-Size="12" OnCheckedChanged="ProductType_Animal_CheckedChanged" />
              <div class="admin-add-product-master-group134">
                  <asp:TextBox class="admin-add-product-master-rectangle3" ID="MaleAmount_TxtBox" Font-Size="42px" BackColor="LightGray" Text="0" runat="server"></asp:TextBox>
                <span class="admin-add-product-master-text10">
                  <span>Male Amount</span>
                </span>
              </div>
              <div class="admin-add-product-master-group135">
                  <asp:TextBox class="admin-add-product-master-rectangle31" ID="FemaleAmount_TxtBox" Font-Size="42px" BackColor="LightGray" Text="0" runat="server"></asp:TextBox>
                <span class="admin-add-product-master-text12">
                  <span>Female Amount</span>
                </span>
              </div>
              <div class="admin-add-product-master-group136">
                  <asp:TextBox class="admin-add-product-master-rectangle32" ID="ItemAmount_TxtBox" Font-Size="42px" BackColor="LightGray" Text="0" runat="server"></asp:TextBox>
                <span class="admin-add-product-master-text14">
                  <span>Item Amount</span>
                </span>
              </div>
            </div>
            <div class="admin-add-product-master-product-detail">
                <asp:TextBox class="admin-add-product-master-rectangle22" ID="ProductDetail_TxtBox" Font-Size="42px" runat="server" TextMode="MultiLine"></asp:TextBox>
              <span class="admin-add-product-master-text16">
                <span>ProductDetail</span>
              </span>
            </div>
            <div class="admin-add-product-master-product-price">
                <asp:TextBox class="admin-add-product-master-rectangle23" ID="ProductPrice_TxtBox" Font-Size="42px" runat="server"></asp:TextBox>
              <span class="admin-add-product-master-text18">
                <span>ProductPrice</span>
              </span>
            </div>
            <div class="admin-add-product-master-product-name">
                <asp:TextBox class="admin-add-product-master-rectangle24" ID="ProductName_TxtBox" Font-Size="42px" runat="server"></asp:TextBox>
              <span class="admin-add-product-master-text20">
                <span>ProductName</span>
              </span>
            </div>
            <div class="admin-add-product-master-group111">
              <div class="admin-add-product-master-group15">
                <div class="admin-add-product-master-addaphoto">
                    <asp:FileUpload class="admin-add-product-master-addaphoto1" ID="FileUpload1" runat="server" />
                </div>
              </div>
              <span class="admin-add-product-master-text24">
                <span>เพิ่มรูปภาพสินค้า</span>
              </span>
            </div>

            <div class="admin-add-product-master-registergroup">
              <span class="admin-add-product-master-text28">
                    <asp:LinkButton ID="EditProduct_btn" ForeColor="White" runat="server" OnClick="EditProduct_btn_Click">แก้ไขสินค้า</asp:LinkButton>
              </span>
            </div>
            <div class="admin-add-product-master-registergroup1">
              <span class="admin-add-product-master-text28">
                    <asp:LinkButton ID="AddProduct_btn" ForeColor="White" runat="server" OnClick="AddProduct_btn_Click">เพิ่มสินค้า</asp:LinkButton>
              </span>
            </div>

            </div>
            <span class="admin-add-product-master-text30">
              <span>จัดการ “เพิ่ม สินค้า”</span>
            </span>
          </div>
        </div>
      </div>
    </div>
</asp:Content>