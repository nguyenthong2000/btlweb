<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ListRoom.aspx.cs" Inherits="btlweb.Customer.ListRoom" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../Theme/CSS/booking.css" rel="stylesheet" />



<!-- content -->
    
    <section class="wrapper">
        <div class="products id="delux">
            <h3>Phong DexuLy Room</h3>
            <ul>  <asp:Literal ID="ltpr" runat="server"></asp:Literal>
                <%--<li class="main-product no-margin">
                    <div class="img-product">
                        <img class="img-prd" src="../Theme/images/photos/1.jpg" />
                    </div>
                    <div class="content-product">
                        <p class="content-product-p">Tên Phòng</p>
                        <p class="content-product-p">Loại Phòng</p>
                        <p class="content-product-p">Giá Phòng</p>
                        <div class="content-product-deltals">
                            <button type="button" class="btn btn-cart">Đặt Phòng</button>
                        </div>
                    </div>
                </li>--%>
            </ul>
        </div>
         <div class="products id="Suit">
              <h3>Phong Suit Room</h3>
            <ul>  <asp:Literal ID="Literal2" runat="server"></asp:Literal>
                <%--<li class="main-product no-margin">
                    <div class="img-product">
                        <img class="img-prd" src="../Theme/images/photos/1.jpg" />
                    </div>
                    <div class="content-product">
                        <p class="content-product-p">Tên Phòng</p>
                        <p class="content-product-p">Loại Phòng</p>
                        <p class="content-product-p">Giá Phòng</p>
                        <div class="content-product-deltals">
                            <button type="button" class="btn btn-cart">Đặt Phòng</button>
                        </div>
                    </div>
                </li>--%>
            </ul>
        </div>
         <div class="products id="Vip">
              <h3>Phong Vip Room</h3>
            <ul>  <asp:Literal ID="Literal3" runat="server"></asp:Literal>
                <%--<li class="main-product no-margin">
                    <div class="img-product">
                        <img class="img-prd" src="../Theme/images/photos/1.jpg" />
                    </div>
                    <div class="content-product">
                        <p class="content-product-p">Tên Phòng</p>
                        <p class="content-product-p">Loại Phòng</p>
                        <p class="content-product-p">Giá Phòng</p>
                        <div class="content-product-deltals">
                            <button type="button" class="btn btn-cart">Đặt Phòng</button>
                        </div>
                    </div>
                </li>--%>
            </ul>
        </div>
    </section>

</asp:Content>
