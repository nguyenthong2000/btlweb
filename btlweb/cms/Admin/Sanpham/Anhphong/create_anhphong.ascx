<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="create_anhphong.ascx.cs" Inherits="btlweb.cms.Admin.Sanpham.Anhphong.create_anhphong" %>
<div class="head">Thêm ảnh phòng</div>
<form action="#" method="post">
    <div class="formThemMoi">
        <div class="ThongTin">
            <div class="tenTruong">Phòng:</div>
            <div class="oNhap"><asp:DropDownList ID="ddlPhong" runat="server"></asp:DropDownList></div>      
        </div>
    
        <div class="ThongTin">
            <div class="tenTruong">Ảnh</div>
            <div class="oNhap">
                <asp:FileUpload ID="fuAnhPhong" runat="server" />
            </div>
            </div>
        <div class="ThongTin">
           <asp:Button ID="btnThem" type="submit" runat="server" Text="Thêm" OnClick="btnThem_Click" />
             <asp:Button ID="btnHuy" runat="server" Text="Hủy" CausesValidation ="false"/>
        </div>
   </div>
       
</form>

