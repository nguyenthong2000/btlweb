<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="btlweb.Customer.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <link rel="stylesheet" href="../Theme/CSS/Login.css" />
    <script src="https://kit.fontawesome.com/d406e8351b.js" crossorigin="anonymous"></script>
    
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
        <div class="form-group">
                        <i class="fa-light fa-lock"></i>
            <asp:TextBox CssClass="form-input" ID="tb_password_again" runat="server" TextMode="Password"></asp:TextBox>
             <div id="eye_again" class="open">
                <i class="fa-regular fa-eye"></i>
            </div>
        </div>
            
        <asp:Button CssClass="form-submit" ID="registerbtn" runat="server" Text="Register" OnClick="registerbtn_Click"/>
        <a class="register" href="Login.aspx">Login</a>
        
    </div>

    <script src="https://code.jquery.com/jquery-3.6.0.js"></script>
    <script src="js/login.js"></script>
</asp:Content>
