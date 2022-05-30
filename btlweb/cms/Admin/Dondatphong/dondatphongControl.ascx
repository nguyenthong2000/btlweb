<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="dondatphongControl.ascx.cs" Inherits="btlweb.cms.Admin.Dondatphong.dondatphongControl" %>
<div class="container">
    <div style="clear:both;height:20px"></div>
    <div class="cotTrai">
    <div class="head">
        Quản lý đặt phòng
    </div>
        <ul>
            <li><a href="/Admin.aspx?modul=dondatphong&modulphu=qldondatphong">Danh sách đơn đặt phòng</a></li> 
        </ul>
    </div>
    <div class="cotPhai">
        <asp:PlaceHolder ID="plhDonDatPhong" runat="server"></asp:PlaceHolder>
    </div>
    <div class="cb"></div>
 </div>
