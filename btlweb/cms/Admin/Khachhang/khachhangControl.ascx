<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="khachhangControl.ascx.cs" Inherits="btlweb.cms.Admin.Khachhang.khachhangControl" %>

<div class="container">
    <div style="clear:both;height:20px"></div>
    <div class="cotTrai">
        <div class="head">
            Quản lý
        </div>
        <ul>
            <li><a href="/Admin.aspx?modul=khachhang&modulphu=qlkhachhang">Danh sách khách hàng</a></li> 
        </ul>
    </div>
    <div class="cotPhai">
        <asp:PlaceHolder ID="plhKhachHang" runat="server"></asp:PlaceHolder>
    </div>
    <div class="cb"></div>
</div>
