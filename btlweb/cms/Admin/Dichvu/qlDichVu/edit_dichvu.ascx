<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="edit_dichvu.ascx.cs" Inherits="btlweb.cms.Admin.Dichvu.qlDichVu.edit_dichvu" %>
<div>Chỉnh sửa dịch vụ</div>
<form action="#" method="post">
    <div class="formThemMoi">
    <div class="ThongTin">
        <div class="tenTruong">Phòng:</div>
        <div class="oNhap"><asp:DropDownList ID="ddlPhong" runat="server"></asp:DropDownList></div>      
    </div>
    <div class="ThongTin">
        <div class="tenTruong">Tên dịch vụ</div>
        <div class="oNhap">
            <asp:TextBox ID="tbTenDichVu" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvDichVu" runat="server" ErrorMessage="*"
                ControlToValidate="tbTenDichVu" Display="Dynamic" SetFocusOnError="true" ForeColor="red"></asp:RequiredFieldValidator>
        </div>     
    <div class="ThongTin">
       <asp:Button ID="btnChinhsua" type="submit" runat="server" Text="Chỉnh sửa" OnClick="btnChinhsua_Click"  />
         <asp:Button ID="btnHuy" runat="server" Text="Hủy" CausesValidation ="false"/>
    </div>
       
    
    </div>
</form>