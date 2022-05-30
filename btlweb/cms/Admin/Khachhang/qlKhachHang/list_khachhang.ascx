<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="list_khachhang.ascx.cs" Inherits="btlweb.cms.Admin.Khachhang.qlKhachHang.list_khachhang" %>

<div class="head">Danh sách khách hàng</div>
<div>
    <asp:TextBox ID="txtSearch" runat="server" Width="350px" Height="23px" placeholder="Nhập từ khóa tìm kiếm..." OnTextChanged="txtSearch_TextChanged" ></asp:TextBox>
    <br />
    <br />
</div>
<div class="khung">
    <table class="table">
        <tr>
            <th>Mã khách hàng</th>
            <th>Tên khách hàng</th>
            <th>Trạng Thái</th>
            <th>Số điện thoại</th>  
            <th>CMND</th>
            <th>Email</th>
            <th>Mã TK</th>
        </tr>
        <asp:Literal ID="rlKhachHang" runat="server"></asp:Literal>      
    </table>
</div>
