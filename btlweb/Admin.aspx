<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="btlweb.Admin" %>

<%@ Register Src="~/cms/Admin/AdminControl.ascx" TagPrefix="uc1" TagName="AdminControl" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Trang quản trị</title>
    <link href="cms/Admin/css/cssAdmin/cssAdmin.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.1.1/css/all.min.css" integrity="sha512-KfkfwYDsLkIlwQp6LFnl8zNdLGxu9YAA1QvwINks4PhcElQSvqcyVLLD9aMhXd13uQjoXtEKNosOWaZqXgel0g==" crossorigin="anonymous" referrerpolicy="no-referrer" />
    <script src="cms/Admin/js/jsAdmin/jsAdmin.js"></script>
    <script src="cms/Admin/js/jsAdmin/jquery-3.6.0.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="scriptmanager1" runat="server">  
        </asp:ScriptManager>  
        <div>
             <%-- header --%>
            <div id="header">
                <div class="container"></div>
                <div class="logo">
                    <img src= "/Customer/Theme/images/luxury-logo1.jpg" alt="holiday crown">
                </div> 
            </div>
            <%-- Menu chính --%>
            <div class="mainMenu">
                <ul>
                    <li><a href="/Admin.aspx" title="Trang chủ">Trang chủ</a></li>
                    <li><a href="/Admin.aspx?modul=taikhoan" title="Tài khoản">Tài khoản</a></li>
                    <li><a href="/Admin.aspx?modul=khachhang" title="Khách hàng">Khách hàng</a></li>
                     <li><a href="/Admin.aspx?modul=sanpham" title="Sản phẩm">Sản phẩm</a></li>
                    <li><a href="/Admin.aspx?modul=dichvu" title="Tài khoản">Dịch vụ</a></li>
                    <li><a href="/Admin.aspx?modul=dondatphong" title="Tài khoản">Đơn đặt phòng</a></li>
                </ul>

            </div>
             <%-- Phần nội dung trang --%>
            <uc1:AdminControl runat="server" id="AdminControl" />
            </div>
    </form>
</body>
</html>
