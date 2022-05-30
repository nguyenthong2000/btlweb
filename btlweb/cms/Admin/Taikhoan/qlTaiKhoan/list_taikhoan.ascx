<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="list_taikhoan.ascx.cs" Inherits="btlweb.cms.Admin.Taikhoan.qlTaiKhoan.list_taikhoan" %>
<div class="head">Danh sách tài khoản</div>
<div>
    <asp:TextBox ID="txtSearch" runat="server" Width="350px" Height="23px" placeholder="Nhập từ khóa tìm kiếm..." OnTextChanged="txtSearch_TextChanged" ></asp:TextBox>
    <br />
    <br />
</div>
<div class="khung">
    <table class="table">
        <tr>
            <th>Mã tài khoản</th>
            <th>Email</th>
            <th>Mật khẩu</th>
            <th>Trạng thái</th>
            <th>Mã loại TK</th>
            <th>Công cụ</th>
        </tr>
        <asp:Literal ID="rlTaiKhoan" runat="server"></asp:Literal>      
    </table>
</div>
<script type="text/javascript">
    function XoaDichVu(MaDichVu) {
        if (confirm("Bạn muốn xóa tài khoản này?")) {
            $.post("cms/Admin/Taikhoan/qlTaiKhoan/Ajax/delete_taikhoan.aspx", {
                "thaotac": "XoaTaiKhoan",
                "MaTaiKhoan": MaTK
            },
                function (data, status) {
                     //thành công
                        $("#mataikhoan_" + MaTaiKhoan).slideUp();
                });
        }
    }
</script>