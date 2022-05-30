<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="list_phong.ascx.cs" Inherits="btlweb.cms.Admin.Sanpham.Phong.list_phong" %>

<div class="head">Danh sách phòng</div>
<div>
    <asp:TextBox ID="txtSearch" runat="server" Width="350px" Height="23px" placeholder="Nhập từ khóa tìm kiếm..." OnTextChanged="txtSearch_TextChanged" ></asp:TextBox>
    <br />
    <br />
</div>

<div>
 Sắp xếp theo <asp:DropDownList ID="ddlSapXep" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DDLSapxep_SelectedIndexChanged" >
    </asp:DropDownList>
</div>

<div class="khung">
    <table class="table">
        <tr>
            <th>Mã Phòng</th>
            <th>Tên Phòng</th>
            <th>Trạng Thái</th>
            <th>Đơn Giá</th>  
            <th>Mã Loại Phòng</th>
            <th>Công cụ</th>
        </tr>
        <asp:Literal ID="rlPhong" runat="server"></asp:Literal>      
    </table>
</div>
