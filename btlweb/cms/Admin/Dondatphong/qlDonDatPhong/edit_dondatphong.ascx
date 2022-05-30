<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="edit_dondatphong.ascx.cs" Inherits="btlweb.cms.Admin.Dondatphong.qlDonDatPhong.edit_dondatphong" %>
<div>Chỉnh sửa trạng thái đơn đặt phòng</div>
<form action="#" method="post">
    <div class="formThemMoi">
    <div class="ThongTin">
        <div class="tenTruong">Mã đơn đặt</div>
        <div class="oNhap"><asp:DropDownList ID="ddlMaDonDat" runat="server"></asp:DropDownList></div>      
    </div>

    <div class="ThongTin">
        <div class="tenTruong">Trạng thái</div>
        <div class="oNhap"><asp:DropDownList ID="ddlTrangThai" runat="server"></asp:DropDownList></div>      
    </div>   
    
    <div class="ThongTin">
       <asp:Button ID="btnChinhsua" type="submit" runat="server" Text="Chỉnh sửa" OnClick="btnChinhsua_Click"  />
         <asp:Button ID="btnHuy" runat="server" Text="Hủy" CausesValidation ="false"/>
    </div>
       
    
    </div>
</form>