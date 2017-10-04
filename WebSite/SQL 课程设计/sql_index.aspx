<%@ Page Language="C#" AutoEventWireup="true" CodeFile="sql_index.aspx.cs" Inherits="index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">



<head runat="server">
    <title>Home</title>
    <link href="css/bootstrap.css" rel='stylesheet' type='text/css' />
    <!-- jQuery (necessary JavaScript plugins) -->
    <script type='text/javascript' src="js/jquery-1.11.1.min.js"></script>
    <!-- Custom Theme files -->
    <link href="css/style.css" rel='stylesheet' type='text/css' />
    <!-- Custom Theme files -->
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false); function hideURLbar(){ window.scrollTo(0,1); } </script>
    <!-- start menu -->
    <link href="css/megamenu.css" rel="stylesheet" type="text/css" media="all" />
    <script type="text/javascript" src="js/megamenu.js"></script>
    <script>        $(document).ready(function () { $(".megamenu").megamenu(); });</script>
    <!-- start slider -->
    <link rel="stylesheet" href="css/fwslider.css" media="all">
    <script src="js/jquery-ui.min.js"></script>
    <script src="js/fwslider.js"></script>
    <script src="js/menu_jquery.js"></script>
    <script src="js/hide_foot.js"></script>
    <!--end slider -->
</head>

  <script type="text/javascript">
        $(function () {
            


            
            $("#logout").click(function () {
                
                if ($("#userName").text() != "Login") {
                    $.get(
                    "handlers/LogOutHandler.ashx",
                    function (data) {
                        window.location.href = "index.aspx";
                    }
                )
                }
            });



        })
    </script>


<body>
    <form id="form1" runat="server">
        <!-- header_top -->
        <div class="top_bg">
            <div class="container">
                <div class="header_top">
                    <div class="top_right">
                        <ul>
                            <li></li>
                             
                            <li><a href="index.aspx">主页 1</a></li>
                            |
                            <li><a href="indexNew.aspx">主页 2</a></li>
                            |
                             <li><a href="about.html">about</a></li>
                            |
                            <li><a href="buy.aspx">购物车</a></li>
                           
                            |
                            <li><a href="userCenter.aspx">用户中心</a></li>
                            |
                             <li><a href="placeOrder.aspx">支付界面</a></li>
                             |
                            <li><a href="login.html">登录</a></li>
                        </ul>
                    </div>
                    <div class="clearfix">
                    </div>
                </div>
            </div>
        </div>
        <!-- header -->
        <div class="header_bg">
            <div class="container">
                <div class="header">
                    <div class="logo">
                        <a href="index.aspx">
                            <img src="images/logo.png" alt="" />
                        </a>
                    </div>
                    <!-- start header_right -->
                    <div class="header_right">
                        <div class="create_btn">

                           <%--  <a class="arrow" href="registration.aspx">create account
                            <img src="images/right_arrow.png" alt="" />
                            </a>--%>

                            <a href="sql_buy.aspx">Cart(<span id="cartNum" runat="server">0</span>)</a>
                            <a href="sql_userCenter.aspx" id="userName" runat="server">登陆</a>
                            <a href="#" id="logout" runat="server">注销</a>
                        </div>
                     <%--   <ul class="icon1 sub-icon1 profile_img">
                            <li><a class="active-icon c2" href="#"></a>
                                <ul class="sub-icon1 list">
                                    <li>
                                        <h3>shopping cart empty</h3>
                                        <a href=""></a></li>
                                    <li>
                                        <p>
                                            if items in your wishlit are missing, <a href="">login to your account</a> to view
                                        them
                                        </p>
                                    </li>
                                </ul>
                            </li>
                        </ul>
                        <ul class="icon1 sub-icon1 profile_img">
                            <li><a class="active-icon c1" href="#"></a>
                                <ul class="sub-icon1 list">
                                    <li>
                                        <h3>wishlist empty</h3>
                                        <a href=""></a></li>
                                    <li>
                                        <p>
                                            if items in your wishlit are missing, <a href="">login to your account</a> to view
                                        them
                                        </p>
                                    </li>
                                </ul>
                            </li>
                        </ul>--%>
                        <div class="search">
                            <form>
                                <input type="text" id="searchbox" value="" placeholder="Search"/>
                                <input type="submit" value="">
                              <%--   <input type="button" id="search" value="Search"/>--%>
                            </form>
                        </div>
                        <div class="clearfix">
                        </div>
                    </div>
                    <!-- start header menu -->

                </div>
            </div>
        </div>
        <!-- content -->
        <div class="container">
            <div class="main">
                <div class="row content_top">
                    <div class="col-md-9 content_left">
                        <!-- start slider -->
                        <div id="fwslider">
                            <div class="slider_container">
                                <div class="slide">
                                    <!-- Slide image -->
                                    <img src="images/slider1.jpg" class="img-responsive" alt="" />
                                    <!-- /Slide image -->
                                </div>
                                <!-- /Duplicate to create more slides -->
                                <div class="slide">
                                    <img src="images/slider2.jpg" class="img-responsive" alt="" />
                                </div>
                                <div class="slide">
                                    <img src="images/slider3.jpg" class="img-responsive" alt="" />
                                </div>
                                <!--/slide -->
                            </div>
                            <div class="timers">
                            </div>
                            <div class="slidePrev">
                                <span></span>
                            </div>
                            <div class="slideNext">
                                <span></span>
                            </div>
                        </div>
                        <!-- end  slider -->
                    </div>
                    <div class="col-md-3 sidebar">
                        <div class="grid_list">
                            <a href="details.aspx">
                                <div class="grid_img">
                                    <img src="images/grid_pic1.jpg" class="img-responsive" alt="" />
                                </div>
                                <div class="grid_text left">
                                    <h3>
                                        <a href="#">extra 35<sub>%</sub> off</a></h3>
                                    <p>
                                        on select merchandise
                                    </p>
                                </div>
                                <div class="clearfix">
                                </div>
                            </a>
                        </div>
                        <div class="grid_list">
                            <a href="details.aspx">
                                <div class="grid_text-middle">
                                    <h3>
                                        <a href="#">celina unpluged</a></h3>
                                    <p>
                                        on select merchandise
                                    </p>
                                </div>
                                <div class="grid_img last">
                                    <img src="images/grid_pic2.jpg" class="img-responsive" alt="" />
                                </div>
                                <div class="clearfix">
                                </div>
                            </a>
                        </div>
                        <div class="grid_list">
                            <a href="details.aspx">
                                <div class="grid_img">
                                    <img src="images/grid_pic3.jpg" class="img-responsive" alt="" />
                                </div>
                                <div class="grid_text left">
                                    <h3>
                                        <a href="#">active gear store</a></h3>
                                    <p>
                                        shop now
                                    </p>
                                </div>
                                <div class="clearfix">
                                </div>
                            </a>
                        </div>
                    </div>
                    <div class="clearfix">
                    </div>
                </div>
                <!-- start content -->
                <div class="content">
                    <div class="content_text">
                        <p>
                            It is a long established fact that a reader will be distracted by the readable content
                        of a page when looking at its layout.
                        </p>
                    </div>

                    <!-- grids_of_3 -->
                    <div class="row grids">

                        <asp:Repeater ID="rptProducts" runat="server">
                            <ItemTemplate>
                                <div class="col-md-3 grid1">
                                    <a href="sql_details.aspx?id=<%#Eval("Id") %>">
                                        <img src="<%#Eval("Imgpath") %>" class="img-responsive" alt="" />
                                        <div class="look">
                                            <h4>
                                                <%#Eval("Name") %></h4>
                                            <p>
                                                ￥<%#Eval("Price") %>
                                            </p>
                                        </div>
                                    </a>

                                    </a>
                                </div>
                            </ItemTemplate>
                        </asp:Repeater>

                    </div>
                    <!-- end grids_of_3 -->
                </div>
                <!-- end content -->
            </div>
        </div>
        <!-- footer_top -->

        <!-- footer -->
        <div class="footer">
            <div class="container">
                <div class="copy">
                    <p class="link">
                        Copyright &copy; 4-2 14145305 付祥运 计算机142
                    </p>
                </div>
            </div>
        </div>

    </form>
</body>
</html>
