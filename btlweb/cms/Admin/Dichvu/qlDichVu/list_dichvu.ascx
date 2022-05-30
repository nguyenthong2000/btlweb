<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="list_dichvu.ascx.cs" Inherits="btlweb.cms.Admin.Dichvu.qlDichVu.list_dichvu" %>
<div class="head">Danh sách dịch vụ</div>
<div>
    <asp:TextBox ID="txtSearch" runat="server" Width="350px" Height="23px" placeholder="Nhập từ khóa tìm kiếm..." OnTextChanged="txtSearch_TextChanged" ></asp:TextBox>
    <br />
    <br />
</div>
<div class="khung">
    <table class="table">
        <tr>
            <th>Mã dịch vụ</th>
            <th>Tên dịch vụ</th>
            <th>Mã Phòng</th>
            <th>Công cụ</th>
        </tr>
        <asp:Literal ID="rlDichVu" runat="server"></asp:Literal>      
    </table>
</div>
<script type="text/javascript">
    function XoaDichVu(MaDichVu) {
        if (confirm("Bạn muốn xóa dịch vụ này?")) {
            $.post("cms/Admin/Dichvu/qlDichVu/Ajax/delete_dichvu.aspx", {
                "thaotac": "XoaDichVu",
                "MaDichVu": MaDichVu
            },
                function (data, status) {
                     //thành công
                        $("#madichvu_" + MaDichVu).slideUp();
                        
                    
                });
        }
    }
</script>