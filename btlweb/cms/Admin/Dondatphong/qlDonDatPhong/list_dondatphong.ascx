<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="list_dondatphong.ascx.cs" Inherits="btlweb.cms.Admin.Dondatphong.qlDonDatPhong.list_dondatphong" %>
<div class="head">Danh sách dơn đặt phòng</div>
<div>
    <asp:TextBox ID="txtSearch" runat="server" Width="350px" Height="23px" placeholder="Nhập từ khóa tìm kiếm..." OnTextChanged="txtSearch_TextChanged" ></asp:TextBox>
    <br />
    <br />
</div>

<div class="khung">
    <table class="table">
        <tr>
            <th>Mã Đơn Đặt</th>
            <th>Số Lượng Người</th>
            <th>Ngày Bắt Đầu</th>
            <th>Ngày Kết Thúc</th> 
            <th>Trạng Thái</th>
            <th>Mã Khách Hàng</th>
            <th>Đổi Trạng Thái</th>
        </tr>
        <asp:Literal ID="rlDDPhong" runat="server"></asp:Literal>      
    </table>
</div>
