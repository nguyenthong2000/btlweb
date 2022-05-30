<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Rooms.aspx.cs" Inherits="btlweb.Customer.Rooms" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="../Theme/CSS/StyleRooms.css" />
    
    <div class="rooms">
        <section class="rooms-contant">

            <asp:Repeater ID="ListRooms" runat="server" OnItemCommand="ListRooms_SelectedIndexChanged">
                <ItemTemplate>
                    <div class="rooms-item">
                        
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
                            <asp:Button ID="detail" runat="server" Text="Detail" CommandArgument='<%# Eval("MaLoaiphong") %>' CausesValidation="False"/>
                        </div>
                    </div>



                </ItemTemplate>

            </asp:Repeater>
        </section>
    </div>
</asp:Content>
