<%@ Page Language="C#" MasterPageFile="~/Master_Navigation.master" AutoEventWireup="true" CodeFile="Admin_Product_Edit.aspx.cs" Inherits="Pages_Admin_Admin_Product_Edit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br />
    <br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br />
    <br /><br /><br /><br /><br /><br /><br /><br /><br />


    <link rel="stylesheet" href="../../../styles/style.css" />
    <div>
      <link href="../../../styles/Admin_Product_Edit.css" rel="stylesheet" />

      <div class="admin-product-master-container">
        <div class="admin-product-master-admin-product-master">
          <img
            src="../../../public/external/bodyview2807-v7pg-2000w.png"
            alt="bodyview2807"
            class="admin-product-master-bodyview" style="left: -5px; top: 6px"
          />
          <div class="admin-product-master-container1">
            <img
              src="../../../public/external/masterbox2807-k5bj-1800w.png"
              alt="masterbox2807"
              class="admin-product-master-masterbox"
            />
            <div class="admin-product-master-group111">
              <div class="admin-product-master-group15">
                <div class="admin-product-master-addaphoto">
                    <asp:FileUpload class="admin-product-master-addaphoto1" ID="FileUpload1" OnDataBinding="FileUpload1_DataBinding" runat="server" />
                </div>
              </div>
                <asp:LinkButton class="admin-product-master-text" ID="UploadData_btn" OnClick="UploadData_btn_Click" runat="server">UPLOAD</asp:LinkButton>
            </div>

            <div class="admin-product-master-product-id">
                <asp:TextBox class="admin-product-master-rectangle2" ID="SearchProduct_TxtBox" Font-Size="42px" runat="server"></asp:TextBox>
              <span class="admin-product-master-text02">
                <span>SearchProduct</span>
              </span>
            </div>
            <div class="admin-product-master-regisitem">
              <div class="admin-product-master-product-sub-category">
                  <asp:DropDownList class="admin-product-master-rectangle22" ID="SubCategory_DDL" Font-Size="42px" runat="server" AppendDataBoundItems="True" AutoPostBack="True">
                    <asp:ListItem>Short</asp:ListItem>
                    <asp:ListItem>Long</asp:ListItem>
                    <asp:ListItem>ToolSub</asp:ListItem>
                    <asp:ListItem>OtherSub</asp:ListItem>
                  </asp:DropDownList>
                <span class="admin-product-master-text05">
                  <span>SubCategory</span>
                </span>
                <img
                  src="../../../public/external/vector2807-hc5r.svg"
                  alt="Vector2807"
                  class="admin-product-master-vector"
                />
              </div>
              <div class="admin-product-master-product-category">
                  <asp:DropDownList class="admin-product-master-rectangle23" ID="Category_DDL" Font-Size="42px" runat="server" AppendDataBoundItems="True" AutoPostBack="True">
                      <asp:ListItem Value="BettaFish">Animal</asp:ListItem>
                      <asp:ListItem>Tool</asp:ListItem>
                  </asp:DropDownList>
                <span class="admin-product-master-text07">
                  <span>Category</span>
                </span>
                <img
                  src="../../../public/external/vector2807-klqc.svg"
                  alt="Vector2807"
                  class="admin-product-master-vector1"
                />
              </div>
              <div class="admin-product-master-product-sex">
                <span class="admin-product-master-text09">
                  <span>ProductType</span>
                </span>
                  <asp:CheckBox class="admin-product-master-button" ID="ProductType_Item" runat="server" AutoPostBack="true" style="transform: scale(2);" Text="Item" OnCheckedChanged="ProductType_Item_CheckedChanged" Font-Size="12" />
                  <asp:CheckBox class="admin-product-master-button1" ID="ProductType_Animal" runat="server" AutoPostBack="true" style="transform: scale(2);" Text="Animal" OnCheckedChanged="ProductType_Animal_CheckedChanged" Font-Size="12" />
                <div class="admin-product-master-group134">
                    <asp:TextBox class="admin-product-master-rectangle3" ID="MaleAmount_Txtbox" Font-Size="42px" ReadOnly="true" Text="0" BackColor="LightGray" runat="server"></asp:TextBox>
                  <span class="admin-product-master-text15">
                    <span>Male Amount</span>
                  </span>
                </div>
                <div class="admin-product-master-group135">
                    <asp:TextBox class="admin-product-master-rectangle31" ID="FemaleAmount_Txtbox" Font-Size="42px" ReadOnly="true" Text="0" BackColor="LightGray" runat="server"></asp:TextBox>
                  <span class="admin-product-master-text17">
                    <span>Female Amount</span>
                  </span>
                </div>
                <div class="admin-product-master-group136">
                    <asp:TextBox class="admin-product-master-rectangle32" ID="ItemAmount_Txtbox" Font-Size="42px" ReadOnly="true" Text="0" BackColor="LightGray" runat="server"></asp:TextBox>
                  <span class="admin-product-master-text19">
                    <span>Item Amount</span>
                  </span>
                </div>
              </div>
              <div class="admin-product-master-product-detail">
                  <asp:TextBox class="admin-product-master-rectangle24" ID="ProductDetail_Txtbox" Font-Size="42px" runat="server" TextMode="MultiLine"></asp:TextBox>
                <span class="admin-product-master-text21">
                  <span>ProductDetail</span>
                </span>
              </div>
              <div class="admin-product-master-product-price">
                  <asp:TextBox class="admin-product-master-rectangle25" ID="ProductPrice_Txtbox" Font-Size="42px" runat="server"></asp:TextBox>
                <span class="admin-product-master-text23">
                  <span>ProductPrice</span>
                </span>
              </div>
              <div class="admin-product-master-product-name">
                  <asp:TextBox class="admin-product-master-rectangle26" ID="ProductName_Txtbox" Font-Size="42px" runat="server"></asp:TextBox>
                <span class="admin-product-master-text25">
                  <span>ProductName</span>
                </span>
              </div>
              <div class="admin-product-master-product-id2">
                  <asp:TextBox class="admin-product-master-rectangle27" ID="ProductID_Txtbox" BackColor="LightGray" ReadOnly="true" Font-Size="42px" runat="server"></asp:TextBox>
                <span class="admin-product-master-text27">
                  <span>Product ID</span>
                </span>
              </div>
              <div class="admin-product-master-product-id3">
                  <asp:Panel class="admin-product-master-rectangle28" ID="Panel1" runat="server"></asp:Panel>
                <span class="admin-product-master-text29">
                  <span>ImageProduct</span>
                </span>
              </div>
            </div>
            <div class="admin-product-master-registergroup">
              <span class="admin-product-master-text31">
                  <asp:LinkButton ID="EditProduct_btn" ForeColor="White" runat="server" OnClick="EditProduct_btn_Click">แก้ไขข้อมูล</asp:LinkButton>
              </span>
            </div>
            <div class="admin-product-master-product-sex1">
              <span class="admin-product-master-text32">
                <span>ProductStatus</span>
              </span>
                <asp:CheckBox class="admin-product-master-button2" ID="ProductStatus_False" runat="server" AutoPostBack="true" style="transform: scale(2);" OnCheckedChanged="ProductStatus_False_CheckedChanged" Text="False" Font-Size="12" />
                <asp:CheckBox class="admin-product-master-button3" ID="ProductStatus_True" runat="server" AutoPostBack="true" style="transform: scale(2);" OnCheckedChanged="ProductStatus_True_CheckedChanged" Text="True" Font-Size="12" />
            </div>
            <div class="admin-product-master-registergroup1">
              <span class="admin-product-master-text38">
                  <asp:LinkButton ID="SearchData_btn" ForeColor="White" OnClick="SearchData_btn_Click" runat="server">ค้นหาข้อมูล</asp:LinkButton>
              </span>
            </div>
            <span class="admin-product-master-text39">
              จัดการ “แก้ไข สินค้า”
            </span>
          </div>
        </div>
      </div>
    </div>
</asp:Content>
