<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Login2.aspx.cs" Inherits="btlweb.Customer.Login2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
    <asp:ScriptManager ID="ScriptManager1" runat="server">
        <Scripts>
            <asp:ScriptReference Path="../Theme/js/login.js" />
        </Scripts>
    </asp:ScriptManager>
    <form class="form-login">
        <div class="input-login">
            <input id="email" type="text" placeholder=" Enter Email" />

        </div>
        <br />
        <div class="input-login">
            <input id="password" type="text" placeholder=" Enter Password" />
        </div>
        <br />
        <input type="button" text="submit" onclick="validator()"  />

        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Label ID="lb_time" runat="server" Text=""></asp:Label>
            </ContentTemplate>
        </asp:UpdatePanel>
        <asp:Button ID="updatebtn" runat="server" Text="Update" OnClick="updatebtn_Click" />
    </form>


</asp:Content>
