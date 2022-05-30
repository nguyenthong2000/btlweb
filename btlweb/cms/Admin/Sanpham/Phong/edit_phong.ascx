<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="edit_phong.ascx.cs" Inherits="btlweb.cms.Admin.Sanpham.Loaiphong.edit_phong" %>
<div>Chỉnh sửa phòng</div>
<form action="#" method="post">
    <div class="formThemMoi">
    <div class="ThongTin">
        <div class="tenTruong">Loại phòng:</div>
        <div class="oNhap"><asp:DropDownList ID="ddlLoaiPhong" runat="server"></asp:DropDownList></div>      
    </div>
    <div class="ThongTin">
        <div class="tenTruong">Tên phòng</div>
        <div class="oNhap">
            <asp:TextBox ID="tbTenPhong" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvTenPhong" runat="server" ErrorMessage="*"
                ControlToValidate="tbTenPhong" Display="Dynamic" SetFocusOnError="true" ForeColor="red"></asp:RequiredFieldValidator>
        </div>     
   
    </div>
    <div class="ThongTin">
        <div class="tenTruong">Đơn giá</div>
        <div class="onNhap">
            <asp:TextBox ID="tbDonGia" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvDonGia" runat="server" ErrorMessage="*" 
        controlToValidate="tbDonGia" Display="Dynamic" SetFocusOnError="true" ForeColor="red"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="revtxtDonGia" runat="server" ValidationExpression="(\d)*" ControlToValidate="tbDonGia"  Display="Dynamic" ErrorMessage="Đơn giá phải là kiểu số"
                ForeColor="red"  SetFocusOnError="True"></asp:RegularExpressionValidator>
        </div>
    </div>
    <div class="ThongTin">
       <asp:Button ID="btnChinhsua" type="submit" runat="server" Text="Chỉnh sửa" OnClick="btnChinhsua_Click"  />
         <asp:Button ID="btnHuy" runat="server" Text="Hủy" CausesValidation ="false"/>
    </div>
       
    
    </div>
</form>