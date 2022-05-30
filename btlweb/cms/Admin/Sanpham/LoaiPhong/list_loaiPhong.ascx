<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="list_LoaiPhong.ascx.cs" Inherits="btlweb.cms.Admin.Sanpham.LoaiPhong.list_LoaiPhong" %>
<div class="head">Danh sách Loai phòng</div>
<div class="khung">
    <table class="table">
        <tr>
            <th>Mã Loại Phòng</th>
            <th>Tên loại phòng</th>
            <th>Mô tả phòng</th>      
        </tr>
        <asp:Literal ID="rlLoaiPhong" runat="server"></asp:Literal> 
        </table>
    </div>