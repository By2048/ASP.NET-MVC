<%@ Page Language="C#" AutoEventWireup="true" CodeFile="placeOrder.aspx.cs" Inherits="placeOrder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Buy</title>
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
        h3 {
            background-color: #3B5998;
        }

        h4 {
            font-weight: bold;
        }

        .selectDiv {
            margin: 10px 30px;
            line-height: 25px;
            border-bottom: 2px solid black;
        }

            .selectDiv li span {
                margin: 0 5px;
            }

        .balance {
            color: green;
        }

        #cart {
            width: 700px;
        }

            #cart tr.head {
                background-color: #ccc;
                height: 30px;
            }

            #cart tr td {
                text-align: center;
            }

        .itemImg {
            width: 100px;
            height: 100px;
        }

        #confirm {
            text-align: center;
            line-height: 40px;
            font-size: 2em;
        }
          .hiden {
            display:none;
        }
    </style>
     <script type="text/javascript">
        $(function () {
            $("#confirmSubmit").click(function () {
                if (parseFloat( $("#balance").text() )> parseFloat( $("#totalMoney").text()))
                {
                    if ($("input[name='address']:checked").length == 0)
                        alert("请选取收货人信息");
                    else {
                        var $address = $("input[name='address']:checked").next().text();
                        var $phone = $("input[name='address']:checked").next().next().text();
                        var $name = $("input[name='address']:checked").next().next().next().text();
                        var $money = $("#totalMoney").text();
                        $.post(
                            "handlers/placeOrderHandler.ashx",
                            { address: $address,phone:$phone,name:$name,money:$money },
                            function (data) {
                                if (data == "ok") {
                                    alert("下单成功！");
                                    $("#balance").text(parseFloat($("#balance").text()) - parseFloat($("#totalMoney").text()))
                                }
                                else
                                    alert("没有商品！");
                            })
                    }
                }
                else
                {
                    $(".hiden").removeClass("hiden");
                }
               
            });
        })
    </script>
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
                            
                            <a href="userCenter.aspx" id="userName" runat="server">用户</a>
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

                    <h3>订单确认
                    </h3>
                    <div id="userinfo" class="selectDiv">
                        <h4>收货人信息
                        </h4>
                        <ul>
                            <li>
                                <input type="radio" name="address" /><span>浙江省 绍兴市 越城区 环城西路508号</span> <span>18909097788</span> <span>王一丹</span>
                            </li>
                            <li>
                                <input type="radio" name="address" checked="checked"/><span>浙江省 绍兴市 越城区 环城西路508号 </span> <span> 18909097788 </span>   <span>张晓琪</span>
                            </li>
                            <li>
                                <input type="radio" name="address" /><span>浙江省 绍兴市 越城区 环城西路508号</span>  <span> 18909097788</span>   <span>王小丹</span>
                            </li>
                        </ul>
                    </div>
                    <div id="payMethod" class="selectDiv">
                        <h4>付款方式
                        </h4>
                        <ul>
                            <li>
                                <input type="radio" name="pay" /><span>在线支付</span>
                            </li>
                            <li>
                                <input type="radio" name="pay" checked="checked" /><span>余额付款</span><span class="balance" id="balance" runat="server">5000.00</span><span class="hiden">余额不足</span>
                            </li>
                            <li>
                                <input type="radio" name="pay" /><span>货到付款</span>
                            </li>
                        </ul>
                    </div>
                    <div id="details" class="selectDiv">
                        <h4>订单详情
                        </h4>
                        <table id="cart" cellpadding="5" cellspacing="0">
                            <tr class="head">
                                <th></th>
                                <th>名称</th>
                                <th>数量</th>
                                <th>价格</th>
                                <th>金额</th>
                            </tr>


                           
                        <asp:Repeater ID="rptCartItems" runat="server">
                            <ItemTemplate>
                                <tr>
                                    <td><img calss="itemImg" src='images/pic<%# Convert.ToInt16( Eval("id"))%>.jpg' alt="image" /></td>
                                    <td><%#Eval("Name") %><span class="hiden idSign"><%#Eval("Id") %></span></td>
                                    <td><%#Eval("Quantity") %></td>
                                    <td>$<%#Eval("Price") %></td>
                                    <td>$<%# Convert.ToDecimal(Eval("Quantity"))* Convert.ToDecimal(Eval("Price")) %></td>
                                </tr>
                            </ItemTemplate>
                        </asp:Repeater>


                            <tr>
                                <td colspan="3"></td>
                                <td>Total</td>
                                 <td>$<span id="totalMoney" runat="server">0</span></td>
                                <td></td>
                            </tr>
                        </table>


                    </div>

                    <div id="confirm" class="selectDiv">
                        <a href="#" id="confirmSubmit">
                            <img src="images/order.png"  width="80" alt ="确认付款" /></a>
                    </div>
                    <!--<div class="clearfix">
                </div>-->
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
