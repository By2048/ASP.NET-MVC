<%@ Page Language="C#" AutoEventWireup="true" CodeFile="sql_buy.aspx.cs" Inherits="buy" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
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
</head>
<style>
    #cart {
        margin: 15px auto;
        width: 90%;
    }

        #cart tr.thead {
            background-color: #ccc;
            height: 30px;
        }

        #cart tr td input {
            height: 25px;
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
    .hiden {
        display:none;
    }

    .itemImg {
        width: 100%;
        height: 100%;
    }
</style>
<script type="text/javascript">
    $(function () {
        var $tmp = $("#totalMoney").text();
        $("#totalMoneyCopy").text($tmp);
    })
</script>
<script type="text/javascript">
    $(function () {

        $(".addItem").click(function () {
            var $id = $(this).parent().prev().find(".hiden").text();
            var $quantity = $(this).prev().val();
            $quantity++;
            $.get(
                "handlers/CartHandler.ashx",
                {
                    type: "update",
                    id: $id,
                    quantity: $quantity
                },
                function (data) {
                    if (data != "error") {
                        $("#totalMoney").text(data);
                    }
                }
            )
            $(this).prev().val($quantity);
            var $price = $(this).parent().next().text();
            var $money = $price * 1 * $quantity;
            $(this).parent().next().next().text($money);
            location.reload();
        });

        $(".subItem").click(function () {
            var $id = $(this).parent().prev().find(".hiden").text();
            var $quantity = $(this).next().val();
            if ($quantity > 0)
                $quantity--;
            $.get(
                "handlers/CartHandler.ashx",
                {
                    type: "update",
                    id: $id,
                    quantity: $quantity
                },
                function (data) {
                    if (data != "error") {
                        $("#totalMoney").text(data);
                    }
                }
            )
            $(this).next().val($quantity);
            var $price = $(this).parent().next().text();
            var $money = $price * 1 * $quantity;
            $(this).parent().next().next().text($money);
            location.reload();
        });

        $(".deleteItem").click(function () {
            var $id = $(this).parents("tr").children().eq(1).find(".hiden").text();
            var $tr = $(this).parents("tr");
            $.get(
                "handlers/CartHandler.ashx",
                { type: "delate", id: $id },
                function (data) {
                    if (data != "error") {
                        $tr.fadeOut(400);
                        $("#totalMoney").text(data);
                    }
                }
            )
            location.reload();
        });

    });
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
            <div class="main">
                <div class="shoping_bag">
                    <h4>
                        <img src="images/bag1.png">my shopping bag / <span>11 item</span></h4>
                    <ul class="s_art">
                        <li>
                            <img src="images/art1.png"></li>
                        <li><span>11 item</span></li>
                    </ul>
                    <div class="clearfix">
                    </div>
                </div>
                <div class="shoping_bag1">
                    <table id="cart" cellpadding="5" cellspacing="0">
                        <tr class="thead">
                            <th width="150" align="left"></th>
                            <th width="200" align="left">名称
                            </th>
                            <th width="80" align="center">数量
                            </th>
                            <th width="80" align="right">价格
                            </th>
                            <th width="80" align="right">金额
                            </th>
                            <th width="80"></th>
                        </tr>
                        <asp:Repeater ID="rptCartItem" runat="server">
                            <ItemTemplate>
                                <tr>
                                    <td>
                                        <img calss="itemImg" src='<%#Eval("ImgPath") %>'  />
                                    </td>
                                    <td>
                                        <%#Eval("Name") %><span class="hiden"><%#Eval("Id") %></sapn>
                                    </td>
                                    <td align="center">
                                        <img class="subItem" src="images/sub.jpg"><input type="text" value='<%#Eval("Quantity") %>' /><img
                                            class="addItem" src="images/add.jpg">
                                    </td>
                                    <td align="right">
                                        <%#Eval("Price") %>
                                    </td>
                                    <td align="right">
                                        <%# Convert.ToDecimal(Eval("Quantity"))* Convert.ToDecimal(Eval("Price")) %>
                                    </td>
                                     <td align="center"><a href="#" class="deleteItem">
                                        <img src="images/del.png"></a></td>
                                </tr>
                                <tr>
                            </ItemTemplate>
                        </asp:Repeater>
                        <td colspan="3" align="right" height="30px"></td>
                        <td align="right" style="background: #ddd; font-weight: bold">Total
                        </td>
                        <td align="right" style="background: #ddd; font-weight: bold">$<span runat="server" id="totalMoney">0</span>
                        </td>
                        <td style="background: #ddd; font-weight: bold"></td>
                        </tr>
                    </table>
                    <div class="clearfix">
                    </div>
                </div>
                <div class="shoping_bag2">
                   
                    
                    <div class="shoping_right">
                        <p class="tot">
                            total &nbsp;<span id="totalMoneyCopy"> Rs. 211109</span>
                        </p>
                    </div>
                     <div class="shoping_left">
                        <a class="btn1" href="placeOrder.aspx">place order</a>
                    </div>
                    <div class="clearfix">
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
