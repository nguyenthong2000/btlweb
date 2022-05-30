<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Booking.aspx.cs" Inherits="btlweb.Customer.Booking" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <link rel="stylesheet" href="~/Theme/CSS/style.css">
<link rel="shortcut icon" href="~/Theme/images/favicon.png" type="image/x-icon">
<link rel="icon" href="~/Theme/images/favicon.png" type="image/x-icon">
    
<div>

    <h3>Thông tin đặt phòng</h3>
    <form role="form" class="wowload fadeInRight" >
        
        <div class="form-group">
            <div class="row">
                <div class="col-xs-6">  <label>Tên khách hàng</label>
                    <asp:TextBox type="text"  ID="txtTenkhachhang" runat="server" placeholder="Tên Khách Hàng" Width="311px" ></asp:TextBox>
                   <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtTenkhachhang" ErrorMessage="Nhap ten nguoi dat" Display="Dynamic" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                </div>
                <div class="col-xs-6">  <label>Ảnh</label>
                    <asp:Image ID="Image1" runat="server" />
                </div>
            </div>
        </div>
        <div class="form-group">
            <div class="row">
                <div class="col-xs-6">
                     <label>Email  </label>
                      <asp:TextBox type="email" ID="txtEmail" runat="server" placeholder="Email" Width="307px" />
                     <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail" Display="Dynamic" ErrorMessage="Nhap Dung email" ForeColor="Red" SetFocusOnError="True" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">Nhap Email</asp:RegularExpressionValidator>
                    </div>
                <div class="col-xs-6">
                    
                </div>
            </div>
        </div>
        <div class="form-group">
            <div class="row">
                <div class="col-xs-6">
                      <label>Số điện thoại  </label>
                        <asp:TextBox type="text" ID="txtPhone" runat="server" placeholder="So Dien Thoai" Width="308px" />
                      <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtPhone" Display="Dynamic" ErrorMessage="Mobile number" ForeColor="Red" SetFocusOnError="True" ValidationExpression="\d{10}">Nhap so dien thoai</asp:RegularExpressionValidator>
                    </div>
            </div>
        </div>
        <div class="form-group">
            <div class="row">
                <div class="col-xs-6">
                    
                        <label>Số lượng người</label>;
                       <asp:TextBox runat="server" type="number" ID="numberParent" placeholder="Số lượng người" Width="306px" />
                   
                    
                    
                        <asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="numberParent" Display="Dynamic" EnableTheming="True" ErrorMessage="Sai so luong" ForeColor="Red" MaximumValue="3" MinimumValue="1" SetFocusOnError="True" Type="Integer">nhap so luong nguoi phu hop</asp:RangeValidator>
                   
                    
                    
                </div>
            </div>
        </div>
        <div class="form-group">
            <div class="row">
                <div class="col-xs-6">
                   
                        <label>Loại Phòng</label>
                    <asp:TextBox ID="tbLPhong" runat="server" Enabled="False"></asp:TextBox>
                  
                  
                </div>
            </div>
        </div>
        <div class="form-group">
            <div class="row">
                <div class="col-xs-6">
                   
                      <label>Phòng</label>
                    <asp:TextBox ID="tbTPhong" runat="server" Enabled="False"></asp:TextBox>
                
                </div>
            </div>
        </div>
        <div class="form-group">
            <div class="row">
                <div class="col-xs-6">
                   
                        <label>Đơn giá</label>
                    <asp:TextBox ID="dongia" runat="server" Enabled="False"></asp:TextBox>
                </div>
            </div>
        </div>
        <div class="form-group">
            <div class="row">
                <div class="col-xs-6">
                   <label>Ngày Nhận Phòng</label>
                     <asp:TextBox ID="DateNP" type ="date" runat="server"></asp:TextBox>
                   
                </div>
                </div>
        </div>
        
        <div class="form-group">
            <div class="row">
           <div class="col-xs-6">
                    <label>Ngày Trả Phòng</label>
           <asp:TextBox ID="DateTP" type ="date" runat="server"></asp:TextBox>
               
                </div>
                <div class="col-xs-6">
                </div>
            </div>
        </div>
        <div >
            <asp:Button ID="submitButton" runat="server" Text="Đặt Phòng" OnClick="submitButton_Click"  />
            
        </div>

    </form>
</div>
</asp:Content>
