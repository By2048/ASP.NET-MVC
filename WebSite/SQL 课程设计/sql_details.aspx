<%@ Page Language="C#" AutoEventWireup="true" CodeFile="sql_details.aspx.cs" Inherits="details" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Details</title>
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
    <script src="js/menu_jquery.js"></script>
    <link rel="stylesheet" href="css/etalage.css">
    <script src="js/jquery.etalage.min.js"></script>
    <script src="js/hide_foot.js"></script>

    <style>
        select {
            height: 28px;
            width:80px;
            font-size: 13px;
        }

        :root select {
            padding: 0;
            height: 28px;
        }
    </style>

    <script>
        jQuery(document).ready(function ($) {
            $('#etalage').etalage({
                thumb_image_width: 300,
                thumb_image_height: 400,
                source_image_width: 900,
                source_image_height: 1200,
                show_hint: true,
                click_callback: function (image_anchor, instance_id) {
                    alert('Callback example:\nYou clicked on an image with the anchor: "' + image_anchor + '"\n(in Etalage instance: "' + instance_id + '")');
                }
            });
        });
       
    </script>
    <!-- the jScrollPane script -->
    <script type="text/javascript" src="js/jquery.jscrollpane.min.js"></script>
    <script type="text/javascript" id="sourcecode">
        $(function () {
            $('.scroll-pane').jScrollPane();
        });
    </script>
<%--    <script type="text/javascript">
        $(function () {
            $("#cart").click(function () {

                var pro_name = $("#productName").text();
                var pro_price = $("#productPrice").text();
                var pro_num = $("#productNum").find("option:selected").val();
                //alert(pro_name + pro_price + pro_num);
                $.post(
                         //url
                         "handlers/CartHandler.ashx",
                         //ashx 是一般处理程序
                         //aspx 是Web窗体
                         //parameters
                         {
                             type: "add",
                             id: getUrlParam("id"),
                             name: pro_name,
                             price: pro_price,
                             quantity: pro_num
                         },
                         //回调函数 data表示请求返回的数据
                         function (data) {
                             $("#cartNum").text(data);
                         })
            });
        })

        function getUrlParam(name) {
            var reg = new RegExp("(^|&)" + name + "=([^&]*)(&|$)"); //构造一个含有目标参数的正则表达式对象
            var r = window.location.search.substr(1).match(reg);  //匹配目标参数
            if (r != null) return unescape(r[2]); return null; //返回参数值
        }
    </script>--%>

</head>
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

                            <a href="sql_buy.aspx">Cart(<span id="cartNum" runat="server">0</span>)
                            </a>
                            <a href="userCenter.aspx" id="userName" runat="server">登陆</a>
                        </div>

                        <div class="search">
                            <form>
                                <input type="text" value="" placeholder="search...">
                                <input type="submit" value="">
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
            <div class="women_main">
                <!-- start content -->
                <div class="row single">
                    <div class="col-md-9">
                        <div class="single_left">
                            <div class="grid images_3_of_2">
                                <ul id="etalage">
                                    <li>
                                        <a href="optionallink.html">

                                            <img id="bigImg" runat="server" src="images/d1.jpg"  class="etalage_source_image" title="" />

                                        </a>
                                    </li>

                                </ul>
                                <div class="clearfix">
                                </div>
                            </div>
                            <div class="desc1 span_3_of_2">
                               
                               <h3 class="hidden">商品id：</h3> 
                               <h3 id="productId" runat="server" class="hidden">id</h3>
                                <h3>商品名称：</h3> 
                                <h3 id="productName" runat="server">name</h3>
                                <h3>商品价格：</h3> 
                                <p id="productPrice" runat="server">
                                    price
                                </p>
                                <div class="det_nav">
                                    <h4>详细信息 :</h4>
                                    <ul>
                                        <li><a href="#">
                                            <img src="images/w6.jpg" class="img-responsive" alt="" /></a></li>
                                        <li><a href="#">
                                            <img src="images/w8.jpg" class="img-responsive" alt="" /></a></li>
                                        <li><a href="#">
                                            <img src="images/w4.jpg" class="img-responsive" alt="" /></a></li>
                                        <li><a href="#">
                                            <img src="images/w9.jpg" class="img-responsive" alt="" /></a></li>
                                    </ul>
                                </div>
                                <div class="det_nav1">
                                    <h4>购买的数量 :</h4>
                                    <div class=" sky-form col col-4">
                                        <select id="productNum">
                                            <option value="1">1</option>
                                            <option value="2">2</option>
                                            <option value="3">3</option>
                                            <option value="4">4</option>
                                            <option value="5">5</option>
                                        </select>                                       
                                    </div>
                                </div>
                                  <%--<div class="btn_form" id="Div1" >--%>
                             
                       
                                    <asp:Button ID="button1"  class="button" runat="server" OnClick="Button1_Click" Text="购买" />
                                    
                            </div>
                            <div class="clearfix">
                            </div>
                        </div>
                        <div class="single-bottom1">
                            <h6>Details</h6>
                            <p class="prod-desc">
                                Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh
                            euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad
                            minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip
                            ex ea commodo consequat. Duis autem vel eum iriure dolor in hendrerit in vulputate
                            velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis at vero
                            eros et accumsan et iusto odio dignissim qui blandit praesent luptatum zzril delenit
                            augue duis dolore te feugait nulla facilisi. Nam liber tempor cum soluta nobis eleifend
                            option
                            </p>
                        </div>
                     
                    </div>
               
                    <div class="clearfix">
                    </div>
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
