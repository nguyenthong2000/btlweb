<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TaikhoanControl.ascx.cs" Inherits="btlweb.cms.Admin.Taikhoan.TaikhoanControl" %>
<div class="container">
    <div style="clear:both;height:20px"></div>
    <div class="cotTrai">
    <div class="head">
        Quản lý tài khoản
    </div>
        <ul>
            <li><a href="/Admin.aspx?modul=taikhoan&modulphu=qltaikhoan">Danh sách tài khoản</a></li> 
        </ul>
        <ul>
            <li><a href="/Admin.aspx?modul=taikhoan&modulphu=qltaikhoan">Danh sách loai tài khoản</a></li> 
        </ul>
     <div class="head">
            Thêm mới
     </div>
        <ul>
            <li><a href="/Admin.aspx?modul=taikhoan&modulphu=qltaikhoan&thaotac=themmoi">Thêm mới dịch vụ</a></li>
        </ul>
    </div>
    <div class="cotPhai">
        <asp:PlaceHolder ID="plhDichVu" runat="server"></asp:PlaceHolder>
    </div>
    <div class="cb"></div>
 </div>
