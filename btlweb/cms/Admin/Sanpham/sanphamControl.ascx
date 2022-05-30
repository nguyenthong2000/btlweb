<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="sanphamControl.ascx.cs" Inherits="btlweb.cms.Admin.Sanpham.sanphamControl" %>

<div class="container">
    <div style="clear:both;height:20px"></div>
    <div class="cotTrai">
        <div class="head">
            Quản lý
        </div>
        <ul>
            <li><a href="/Admin.aspx?modul=sanpham&modulphu=phong">Danh sách phòng</a></li>
            <li><a href="/Admin.aspx?modul=sanpham&modulphu=loaiphong">Quản lý danh mục phòng</a></li>
            <li><a href="/Admin.aspx?modul=sanpham&modulphu=aphong">Ảnh phòng</a></li>
        </ul>
        <div class="head">
            Thêm mới
        </div>
        <ul>
            <li><a href="/Admin.aspx?modul=sanpham&modulphu=phong&thaotac=themmoi">Thêm mới phòng</a></li>
            <li><a href="/Admin.aspx?modul=sanpham&modulphu=aphong&thaotac=themmoi">Thêm mới ảnh phòng</a></li>
            <li><a href="/Admin.aspx?modul=sanpham&modulphu=loaiphong&thaotac=themmoi">Thêm mới loại phòng</a></li>
        </ul>
    </div>
    <div class="cotPhai">
        <asp:PlaceHolder ID="plhSanpham" runat="server"></asp:PlaceHolder>
    </div>
    <div class="cb"></div>
</div>
