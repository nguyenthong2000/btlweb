<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="view_listAnhPhong.ascx.cs" Inherits="btlweb.cms.Admin.Sanpham.Anhphong.view_listAnhPhong" %>
<div class="head">Danh sách Ảnh phòng</div>
<div class="khung">
    <table class="table">
        <tr>
            <th>Mã Phòng</th>
            <th>Mã Ảnh</th>
            <th>Ảnh</th>      
            <th>Công cụ</th>
        </tr>
        <asp:Literal ID="rlAnhPhong" runat="server"></asp:Literal>      
    </table>
</div>
<script type="text/javascript">
    function XoaAnhPhong(MaAnh) {
        if (confirm("Bạn muốn xóa ảnh này?")) {
            $.post("cms/Admin/Sanpham/Anhphong/Ajax/xoa_anhphong.aspx", {
                "thaotac": "XoaAnhPhong",
                "MaAnh": MaAnh
            },
                function (data, status) {
                     //thành công
                        $("#maanh_" + MaAnh).slideUp();
                        
                    
                });
        }
    }
</script>