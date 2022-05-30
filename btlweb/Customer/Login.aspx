<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="btlweb.Customer.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="../Theme/CSS/Login.css" />
    <script src="https://kit.fontawesome.com/d406e8351b.js" crossorigin="anonymous"></script>
    <form id="form-login" action="Login.aspx" method="post">
        <div id="wrapper">
            
            <h1 class="form-heading">Login</h1>
            <div class="form-group">
                <i class="fa-regular fa-user"></i>
                
                
                <asp:TextBox CssClass="form-input" ID="tb_username" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <i class="fa-light fa-lock"></i>
                <asp:TextBox CssClass="form-input" ID="tb_password" runat="server" TextMode="Password"></asp:TextBox>
                
                <div id="eye" class="open">
                    <i class="fa-regular fa-eye"></i>
                </div>
            </div>
            
            <asp:Button CssClass="form-submit" ID="loginbtn" runat="server" Text="Login" OnClick="loginbtn_Click"/>
            <a class="register" href="Register.aspx">Create Account</a>
        
        </div>
    </form>
    <asp:ScriptManager ID="ScriptManager1" runat="server">
        <Scripts>
            <asp:ScriptReference Path="../Theme/js/login.js" />
        </Scripts>
    </asp:ScriptManager>

    <script src="https://code.jquery.com/jquery-3.6.0.js"></script>
    <script src="js/login.js"></script>

</asp:Content>
