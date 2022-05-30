<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="dichvuControl.ascx.cs" Inherits="btlweb.cms.Admin.Dichvu.dichvuControl" %>

<div class="container">
    <div style="clear:both;height:20px"></div>
    <div class="cotTrai">
    <div class="head">
        Quản lý dịch vụ
    </div>
        <ul>
            <li><a href="/Admin.aspx?modul=dichvu&modulphu=qldichvu">Danh sách dịch vụ</a></li> 
        </ul>
     <div class="head">
            Thêm mới
     </div>
        <ul>
            <li><a href="/Admin.aspx?modul=dichvu&modulphu=qldichvu&thaotac=themmoi">Thêm mới dịch vụ</a></li>
        </ul>
    </div>
    <div class="cotPhai">
        <asp:PlaceHolder ID="plhDichVu" runat="server"></asp:PlaceHolder>
    </div>
    <div class="cb"></div>
 </div>
