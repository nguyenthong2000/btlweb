<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="btlweb.Customer.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!--thay đổi phần đầu trang -->
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- banner -->
<div class="banner">
    <img src="../Theme/images/photos/banner.jpg" class="img-responsive" alt="slide">
    <div class="welcome-message">
        <div class="wrap-info">
            <div class="information">
                <h1 class="animated fadeInDown">Best hotel in Viet Nam</h1>
                <p class="animated fadeInUp">Most luxurious hotel of asia with the royal treatments and excellent customer service.</p>
            </div>
            <!--<a href="#information" class="arrow-nav scroll wowload fadeInDownBig"><i class="fa fa-angle-down"></i></a>-->
        </div>
    </div>
</div>
<!-- banner-->
<!-- reservation-information -->
<div id="information" class="spacer reserve-info ">
    <div class="container">
        <div class="row">
            <div class="col-sm-7 col-md-8">
                <div class="embed-responsive embed-responsive-16by9 wowload fadeInLeft"><video class="embed-responsive-item" src="../Theme/images/video/Hotel room introduce.mp4" width="1280" height="720" controls autoplay muted frameborder="0"  ></video></div>
            </div>
            <div class="col-sm-5 col-md-4">
                <h3>Reservation</h3>
                <p class="reserve-info" >Khách sạn Luxury là khách sạn 5 sao đẹp nhất tại Hà Nội.
                    Luxury có thiết kế sang trọng và view hướng biển vô cùng đẹp.
                    Do đó, nơi này là địa điểm được khách du lịch ưu tiên đặt phòng.
                    Vào những mùa du lịch, khách sạn thường hết phòng vì khách đặt trước.
                    Khách sạn Luxury nằm cạnh bờ biển Tô lịch – một trong những bãi biển đẹp nhất Hà Nội.
                    Rosamia có 208 phòng cao cấp. Ở đây có không gian hiện đại và những thiết bị tiện lợi tạo cho khách tại đây có được những trải nghiệm thư giãn nhất.
                    Ngoài nội thất hiện đại tiện nghi, phòng tại đây có đủ những đồ dùng cá nhân dùng một lần cho khách của khách sạn.
                    Bạn có thể trải nghiệm các dịch vụ đặc biệt tại đây mà không phải khách sạn nào cũng có.
                    Đối với những doanh nghiệp đến tổ chức họp, khách sạn có những phòng hội nghị rộng cùng với sự hỗ trợ nhiệt tình từ những bạn phục vụ.
                    Thái độ phục vụ của lễ tân hay bất kỳ nhân viên nào của khách sạn cũng vô cùng chuyên nghiệp, tạo cho khách hàng cảm giác thoải mái.
                    Nếu có cơ hội bạn có thể trải nghiệm tại Luxury để cảm nhận những điều tốt đẹp mà khách sạn này mang lại nhé.
                </p>
            </div>
        </div>
    </div>
</div>
<!-- reservation-information -->
<!-- services -->
<div class="spacer services wowload fadeInUp">
    <div class="container">
        <div class="row">
            <div class="col-sm-4">
                <!-- RoomCarousel -->
                <div id="RoomCarousel" class="carousel slide" data-ride="carousel">
                    <div class="carousel-inner">
                        <div class="item active"><img src="../Theme/images/photos/8.jpg" class="img-responsive" alt="slide"></div>
                        <div class="item  height-full"><img src="../Theme/images/photos/9.jpg" class="img-responsive" alt="slide"></div>
                        <div class="item  height-full"><img src="../Theme/images/photos/10.jpg" class="img-responsive" alt="slide"></div>
                    </div>
                    <!-- Controls -->
                    <a class="left carousel-control" href="#RoomCarousel" role="button" data-slide="prev"><i class="fa fa-angle-left"></i></a>
                    <a class="right carousel-control" href="#RoomCarousel" role="button" data-slide="next"><i class="fa fa-angle-right"></i></a>
                </div>
                <!-- RoomCarousel-->
                <div class="caption">Rooms<a href="rooms-tariff.php" class="pull-right"><i class="fa fa-edit"></i></a></div>
            </div>


            <div class="col-sm-4">
                <!-- RoomCarousel -->
                <div id="TourCarousel" class="carousel slide" data-ride="carousel">
                    <div class="carousel-inner">
                        <div class="item active"><img src="../Theme/images/photos/6.jpg" class="img-responsive" alt="slide"></div>
                        <div class="item  height-full"><img src="../Theme/images/photos/3.jpg" class="img-responsive" alt="slide"></div>
                        <div class="item  height-full"><img src="../Theme/images/photos/4.jpg" class="img-responsive" alt="slide"></div>
                    </div>
                    <!-- Controls -->
                    <a class="left carousel-control" href="#TourCarousel" role="button" data-slide="prev"><i class="fa fa-angle-left"></i></a>
                    <a class="right carousel-control" href="#TourCarousel" role="button" data-slide="next"><i class="fa fa-angle-right"></i></a>
                </div>
                <!-- RoomCarousel-->
                <div class="caption">Tour Packages<a href="#" class="pull-right"><i class="fa fa-edit"></i></a></div>
            </div>


            <div class="col-sm-4">
                <!-- RoomCarousel -->
                <div id="FoodCarousel" class="carousel slide" data-ride="carousel">
                    <div class="carousel-inner">
                        <div class="item active"><img src="../Theme/images/photos/1.jpg" class="img-responsive" alt="slide"></div>
                        <div class="item  height-full"><img src="../Theme/images/photos/2.jpg" class="img-responsive" alt="slide"></div>
                        <div class="item  height-full"><img src="../Theme/images/photos/5.jpg" class="img-responsive" alt="slide"></div>
                    </div>
                    <!-- Controls -->
                    <a class="left carousel-control" href="#FoodCarousel" role="button" data-slide="prev"><i class="fa fa-angle-left"></i></a>
                    <a class="right carousel-control" href="#FoodCarousel" role="button" data-slide="next"><i class="fa fa-angle-right"></i></a>
                </div>
                <!-- RoomCarousel-->
                <div class="caption">Food and Drinks<a href="#" class="pull-right"><i class="fa fa-edit"></i></a></div>
            </div>
        </div>
    </div>
</div>
<!-- services -->
</asp:Content>
