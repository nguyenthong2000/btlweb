<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="create_loaiphong.ascx.cs" Inherits="btlweb.cms.Admin.Sanpham.LoaiPhong.create_loaiphong" %>
<div class="head">Thêm loại phòng</div>
<form action="#" method="post">
    <div class="formThemMoi">
        <div class="ThongTin">
            <div class="tenTruong">Tên loại phòng:</div>
            <div class="oNhap"><asp:TextBox ID="TbTenLoaiPhong" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvTenLoaiPhong" runat="server" ErrorMessage="*" 
                controlToValidate="tbTenLoaiPhong" Display="Dynamic" SetFocusOnError="true" ForeColor="red"></asp:RequiredFieldValidator>
            </div>      
        </div>
         <div class="ThongTin">
            <div class="tenTruong">Mô tả:</div>
            <div class="oNhap"><asp:TextBox ID="tbMoTaLoaiPhong" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvtbMoTaLoaiPhong" runat="server" ErrorMessage="*" 
                controlToValidate="tbMoTaLoaiPhong" Display="Dynamic" SetFocusOnError="true" ForeColor="red"></asp:RequiredFieldValidator>
            </div>      
        </div>
    
    <div class="ThongTin">
       <asp:Button ID="btnThem" type="submit" runat="server" Text="Thêm" OnClick="btnThem_Click" />
         <asp:Button ID="btnHuy" runat="server" Text="Hủy" CausesValidation ="false"/>
    </div>
       </div>
 </form>

