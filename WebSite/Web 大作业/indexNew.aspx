<%@ Page Language="C#" AutoEventWireup="true" CodeFile="indexNew.aspx.cs" Inherits="indexNew" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Women</title>
    <link href="css/bootstrap.css" rel='stylesheet' type='text/css' />
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
    <script src="js/hide_foot.js"></script>
    <!-- the jScrollPane script -->
    <script type="text/javascript" src="js/jquery.jscrollpane.min.js"></script>
    <script type="text/javascript" id="sourcecode">
        $(function () {
            $('.scroll-pane').jScrollPane();
        });
    </script>
    <style type="text/css">
        .hiden {
            display: none;
        }
        /*.navition
        {
            cursor: pointer;
            position: relative;
            top: -50px;
            width: 80px;
            margin: 5px;
        }*/
    </style>
</head>

<script type="text/javascript">
    $(function () {
        $(".navition >span:first-child").click(function () {
            var $li = $(this).parent("li");
            var $cid = $li.data("cid");
            $.get(
                "handlers/CategoryHandler.ashx",
                {                    
                    cid: $cid
                },
                function (data) {
                    var jsonObjArray = eval("(" + data + ")");
                    $(".navition > ul").remove();
                    $li.append("<ul id='smcul'></ul>");
                    for (var i = 0; i < jsonObjArray.length; i++) {
                        $li.children("ul").append("<li data-smallcid='" + jsonObjArray[i].Id + "'>" + jsonObjArray[i].Name + "</li><div class='clear'></div>");
                    }
                    $("#smcul > li").click(function () {
                        //alert($(this).data("smallcid"));
                        var scUrl = "indexNew.aspx?scid=" + $(this).data("smallcid");
                        window.location.href = scUrl;
                    });
                }
            )
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
                            <a class="arrow" href="registration.aspx">create account
                            <img src="images/right_arrow.png" alt="" />
                            </a>
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
                <!-- start sidebar -->
                <div class="col-md-3">
                    <div class="w_sidebar">
                        <div class="w_nav1">
                            <h4>产品类</h4>


                            <asp:Repeater ID="RepeaterItem" runat="server">
                                <ItemTemplate>
                                    <li class="navition" data-cid='<%#Eval("Id") %>'><span>
                                        <%#Eval("Name") %></span></li>
                                </ItemTemplate>
                            </asp:Repeater>



                        </div>

                        <section class="sky-form">
		                </section>

                        <section class="sky-form">
		                </section>

                    </div>
                </div>
                <!-- start content -->
                <div class="col-md-9 w_content">
                    <div class="women">
                        <a href="#">
                            <h4>Enthecwear - <span>4449 itemms</span>
                            </h4>
                        </a>
                        <ul class="w_nav">
                            <li>Sort : </li>
                            <li><a class="active" href="#">popular</a></li>
                            |
                        <li><a href="#">new </a></li>
                            |
                        <li><a href="#">discount</a></li>
                            |
                        <li><a href="#">price: Low High </a></li>
                            <div class="clear">
                            </div>
                        </ul>
                        <div class="clearfix">
                        </div>
                    </div>
                    <!-- grids_of_4 -->

                    <asp:Repeater ID="Repeater1" runat="server">
                        <ItemTemplate>
                            <div class="grids_of_4">
                                <div class="grid1_of_4">
                                    <div class="content_box">
                                        <a href="details.aspx">
                                            <div class="view view-fifth">
                                                <img src="<%#Eval("Imgpath") %>" class="img-responsive" alt="" />
                                                <div class="mask">
                                                    <div class="info">
                                                        Quick View
                                                    </div>
                                                </div>
                                        </a>
                                    </div>
                                    <h4>
                                        <a href="details.aspx"><%#Eval("Name") %></a></h4>
                                    <p>
                                        It is a long established fact that a reader
                                    </p>
                                    ￥<%#Eval("Price") %>
                                </div>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>

                </div>
               

                
        <div class="clearfix">
        </div>


                <asp:Repeater ID="Repeater2" runat="server">
                    <ItemTemplate>
                        <div class="grids_of_4">
                            <div class="grid1_of_4">
                                <div class="content_box">
                                    <a href="details.aspx">
                                        <div class="view view-fifth">
                                            <img src="<%#Eval("Imgpath") %>" class="img-responsive" alt="" />
                                            <div class="mask">
                                                <div class="info">
                                                    Quick View
                                                </div>
                                            </div>
                                    </a>
                                </div>
                                <h4>
                                    <a href="details.aspx"><%#Eval("Name") %></a></h4>
                                <p>
                                    It is a long established fact that a reader
                                </p>
                                ￥<%#Eval("Price") %>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>


                          
        <div class="clearfix">
        </div>



                <asp:Repeater ID="Repeater3" runat="server">
                    <ItemTemplate>
                        <div class="grids_of_4">
                            <div class="grid1_of_4">
                                <div class="content_box">
                                    <a href="details.aspx">
                                        <div class="view view-fifth">
                                            <img src="<%#Eval("Imgpath") %>" class="img-responsive" alt="" />
                                            <div class="mask">
                                                <div class="info">
                                                    Quick View
                                                </div>
                                            </div>
                                    </a>
                                </div>
                                <h4>
                                    <a href="details.aspx"><%#Eval("Name") %></a></h4>
                                <p>
                                    It is a long established fact that a reader
                                </p>
                                ￥<%#Eval("Price") %>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>




                          
        <div class="clearfix">
        </div>


            </div>

        </div>
        <div class="clearfix">
        </div>















        <div class="clearfix">
        </div>
        </div>
    <!-- end grids_of_4 -->
        </div>
    <div class="clearfix">
    </div>
        <!-- end content -->
        </div> </div>
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
