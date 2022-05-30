<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="create_taikhoan.ascx.cs" Inherits="btlweb.cms.Admin.Taikhoan.create_taikhoan" %>
<div>Thêm tài khoản</div>
<form action="#" method="post">
    <div class="formThemMoi">
    <div class="ThongTin">
        <div class="tenTruong">Loại tài khoản:</div>
        <div class="oNhap"><asp:DropDownList ID="ddlLoaiTK" runat="server"></asp:DropDownList></div>      
    </div>
    <div class="ThongTin">
        <div class="tenTruong">Email</div>
        <div class="oNhap">
            <asp:TextBox ID="tbEmail" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ErrorMessage="*"
                ControlToValidate="tbEmail" Display="Dynamic" SetFocusOnError="true" ForeColor="red"></asp:RequiredFieldValidator>
        </div>     
    </div>
    <div class="ThongTin">
        <div class="tenTruong">Mật khẩu</div>
        <div class="oNhap">
            <asp:TextBox ID="tbMK" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*"
                ControlToValidate="tbMK" Display="Dynamic" SetFocusOnError="true" ForeColor="red"></asp:RequiredFieldValidator>
        </div>     
    </div>
    <div class="ThongTin">
       <asp:Button ID="btnThem" type="submit" runat="server" Text="Thêm" OnClick="btnThem_Click" />
         <asp:Button ID="btnHuy" runat="server" Text="Hủy" CausesValidation ="false" OnClick="btnHuy_Click"/>
    </div>
       
    
</div>
</form>