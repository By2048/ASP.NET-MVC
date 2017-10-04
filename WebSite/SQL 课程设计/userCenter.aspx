<%@ Page Language="C#" AutoEventWireup="true" CodeFile="userCenter.aspx.cs" Inherits="userCenter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>userCenter</title>
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
    <script src="js/hide_foot.js"></script>
    <style>
        #cart {
            margin: 15px auto;
            width: 90%;
        }

        table, tr, td {
            border: 1px solid black;
        }

        #cart tr.thead {
            background-color: #ccc;
            height: 30px;
        }

        #cart tr td input {
            height: 16px;
            width: 35px;
            margin: 0 2px;
        }

        #cart tr td img {
            vertical-align: middle;
        }

        .addItem, .subItem {
            width: 16px;
            height: 16px;
        }

        .itemImg {
            width: 100%;
            height: 100%;
        }



        .hiden {
            display: none;
        }
    </style>
</head>

<script type="text/javascript">
    $(function () {
        $("#lookdetail").click(function () {
            $("#cart2").toggleClass("hiden");
            $("#cart1").toggleClass("hiden");
        })
    })
</script>

<body>
    <form id="form1" runat="server">
        <  
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
                        
                            <a href="#" id="userName" runat="server"></a>
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
            <div class="main">

                <div class="shoping_bag1">

                    <div class="userCenter">
                        <div class="wrap">

                            <table>
                                <tr>
                                    <td align="center" width="100">账号</td>
                                    <td align="center" width="100">昵称</td>
                                    <td align="center" width="100">余额</td>
                                    <td align="center" width="100">性别</td>
                                    <td align="center" width="100">电话</td>
                                    <td align="center" width="100">生日</td>

                                </tr>

                                <tr>
                                    <td align="center" width="100"><span id="Id" runat="server"></span></td>
                                    <td align="center" width="100"><span id="Name" runat="server"></span></td>
                                    <td align="center" width="100"><span id="Balance" runat="server"></span></td>
                                    <td align="center" width="100"><span id="Sex" runat="server"></span></td>
                                    <td align="center" width="100"><span id="Phonenum" runat="server"></span></td>
                                    <td align="center" width="100"><span id="Birthday" runat="server"></span>    </td>

                                </tr>

                            </table>

                            <br />
                            <br />

                            <table class="detail">
                                <tr>
                                    <td align="center" width="100">商品名称</td>
                                    <td align="center" width="100">购买单价</td>
                                    <td align="center" width="100">购买数量</td>

                                </tr>
                                <tr>
                                    <td align="center" colspan="3"><a href="#" id="lookdetail">查看明细</a></td>

                                </tr>
                            </table>

                            <asp:Repeater ID="rptOrderDetail" runat="server">
                                <ItemTemplate>
                                    <table class="detail">

                                        <tr>
                                            <td align="center" width="100"><%#Eval( "Name") %></td>
                                            <td align="center" width="100"><%#Eval( "Price") %></td>
                                            <td align="center" width="100"><%#Eval( "Quantity") %></td>
                                            <%--  <td align="center" width="100"><a href="#" id="lookdetail">查看明细</a></td>--%>
                                        </tr>
                                    </table>
                                </ItemTemplate>
                            </asp:Repeater>


                            <br />
                            <br />

                            <table id="cart1" class="hiden">
                                <tr class="tdead">
                                    <td width="300" align="center">商品</td>
                                    <td width="300" align="center">收货人地址</td>
                                    <td width="150" align="center">联系方式</td>
                                    <td width="100" align="center">姓名</td>
                                    <td width="100" align="center">金额</td>
                                </tr>
                            </table>

                            <table id="cart2" class="hiden">

                                <asp:Repeater ID="rptOrder" runat="server">
                                    <ItemTemplate>

                                        <tr>
                                            <td colspan="7" align="left" height="30px">订单日期：<%#Eval( "OrderDate") %>&nbsp;&nbsp;&nbsp;&nbsp;订单编号：<%#Eval( "OrderId") %></td>
                                        </tr>
                                        <tr>
                                            <td width="300" align="center">
                                                <img calss="itemImg" src="<%#Eval( "ImgPath") %>" /></td>
                                            <td width="300" align="center"><%#Eval("Address") %></td>
                                            <td width="150" align="center"><%#Eval("Phone")%></td>
                                            <td width="100" align="center"><%#Eval("Recipient")%></td>
                                            <td width="100" align="center"><%#Eval("Total")%></td>
                                            <%--<td align="center"><a class="detail" href="#">查看明细</a></td>
                                            <td align="center"><a href="#">确认收货</a></td>--%>
                                        </tr>

                                    </ItemTemplate>
                                </asp:Repeater>
                            </table>


                        </div>

                    </div>

                </div>

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
