<%@ Page Language="C#" AutoEventWireup="true" CodeFile="sql_userCenter.aspx.cs" Inherits="userCenter" %>

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
                                    <td align="center" width="100">性别</td>
                                    <td align="center" width="100">地址</td>

                                </tr>

                                <tr>
                                    <td align="center" width="100"><span id="Id" runat="server"></span></td>
                                    <td align="center" width="100"><span id="Name" runat="server"></span></td>
                                    <td align="center" width="100"><span id="Balance" runat="server"></span></td>
                                    <td align="center" width="100"><span id="Sex" runat="server"></span></td>
                                    <td align="center" width="100"><span id="Phonenum" runat="server"></span></td>
                                    <td align="center" width="100"><span id="Birthday" runat="server"></span>    </td>
                                     <td align="center" width="100"><span id="Address" runat="server"></span>    </td>

                                </tr>

                            </table>

                            <br />
                            <br />

                          <h2>你以购买的商品</h2>
                        <br /> <br />
                         <asp:GridView ID="GridView1" runat="server"
                            AutoGenerateColumns="False" 
                            EnableViewState="false"
                            cellspacing="10">
                           <Columns>
                               <asp:BoundField DataField="goods_name" HeaderText="商品名" />
                               <asp:BoundField DataField="goods_Price" HeaderText="商品价格" />
                               <asp:BoundField DataField="goods_num" HeaderText="商品数量" />
                           </Columns>
                       </asp:GridView>

                            <br />
                            <br />

                            

                            


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
