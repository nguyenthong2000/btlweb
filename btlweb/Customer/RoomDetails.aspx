<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="RoomDetails.aspx.cs" Inherits="btlweb.Customer.RoomDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="room-details">
        <section class="room-details-contant">

            <asp:Repeater ID="ListRooms" runat="server">
                <ItemTemplate>
                    <div class="room-details">
                       
                        <asp:Label runat="server" ID="id" Text='<%#Eval("MaLoaiphong") %>' Visible="false"></asp:Label>
                        <div>
                            <img class="room-img" src="../Theme/images/photos/<%# Eval("Anh") %>" />

                        </div>

                        <div>
                            <a class="loaiphong" href="#"><%# Eval("tenLoaiPhong") %></a>
                        </div>

                        <div>
                            <p class="dongia"><%# Eval("DonGia") %></p>
                        </div>
                        <div>
                           <p class="mota"><%#Eval("MoTaLoaiPhong") %></p>
                        </div>
                    </div>



                </ItemTemplate>

            </asp:Repeater>
        </section>
    </div>
</asp:Content>
