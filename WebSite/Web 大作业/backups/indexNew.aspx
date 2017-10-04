﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="indexNew.aspx.cs" Inherits="indexNew" %>

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
</head>
<body>
    <form id="form1" runat="server">
    <!-- header_top -->
    <div class="top_bg">
        <div class="container">
            <div class="header_top">
                <div class="top_left">
                    <h2>
                        <a href="#">50%off</a> use coupon code "big61" and get extra 33% off on orders above
                        rs 2,229
                    </h2>
                </div>
                <div class="top_right">
                    <ul>
                        <li><a href="#">Recently viewed</a></li>|
                        <li><a href="contact.html">Contact</a></li>|
                        <li class="login">
                            <div id="loginContainer">
                                <a href="#" id="loginButton"><span>Login</span></a>
                                <div id="loginBox">
                                    <form id="loginForm">
                                    <fieldset id="body">
                                        <fieldset>
                                            <label for="email">
                                                Email Address</label>
                                            <input type="text" name="email" id="email">
                                        </fieldset>
                                        <fieldset>
                                            <label for="password">
                                                Password</label>
                                            <input type="password" name="password" id="password">
                                        </fieldset>
                                        <input type="submit" id="login" value="Sign in">
                                        <label for="checkbox">
                                            <input type="checkbox" id="checkbox">
                                            <i>Remember me</i></label>
                                    </fieldset>
                                    <span><a href="#">Forgot your password?</a></span>
                                    </form>
                                </div>
                            </div>
                        </li>
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
                    <a href="index.html">
                        <img src="images/logo.png" alt="" />
                    </a>
                </div>
                <!-- start header_right -->
                <div class="header_right">
                    <div class="create_btn">
                        <a class="arrow" href="registration.html">create account
                            <img src="images/right_arrow.png" alt="" />
                        </a>
                    </div>
                    <ul class="icon1 sub-icon1 profile_img">
                        <li><a class="active-icon c2" href="#"></a>
                            <ul class="sub-icon1 list">
                                <li>
                                    <h3>
                                        shopping cart empty</h3>
                                    <a href=""></a></li>
                                <li>
                                    <p>
                                        if items in your wishlit are missing, <a href="">login to your account</a> to view
                                        them</p>
                                </li>
                            </ul>
                        </li>
                    </ul>
                    <ul class="icon1 sub-icon1 profile_img">
                        <li><a class="active-icon c1" href="#"></a>
                            <ul class="sub-icon1 list">
                                <li>
                                    <h3>
                                        wishlist empty</h3>
                                    <a href=""></a></li>
                                <li>
                                    <p>
                                        if items in your wishlit are missing, <a href="">login to your account</a> to view
                                        them</p>
                                </li>
                            </ul>
                        </li>
                    </ul>
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
                <ul class="megamenu skyblue">
                    <li><a class="color1" href="index.html">Home</a></li>
                    <li class="grid"><a class="color2" href="#">new arrivals</a>
                        <div class="megapanel">
                            <div class="row">
                                <div class="col1">
                                    <div class="h_nav">
                                        <h4>
                                            shop</h4>
                                        <ul>
                                            <li><a href="women.html">new arrivals</a></li>
                                            <li><a href="women.html">men</a></li>
                                            <li><a href="women.html">women</a></li>
                                            <li><a href="women.html">accessories</a></li>
                                            <li><a href="women.html">kids</a></li>
                                            <li><a href="women.html">brands</a></li>
                                        </ul>
                                    </div>
                                </div>
                                <div class="col1">
                                    <div class="h_nav">
                                        <h4>
                                            help</h4>
                                        <ul>
                                            <li><a href="women.html">trends</a></li>
                                            <li><a href="women.html">sale</a></li>
                                            <li><a href="women.html">style videos</a></li>
                                            <li><a href="women.html">accessories</a></li>
                                            <li><a href="women.html">kids</a></li>
                                            <li><a href="women.html">style videos</a></li>
                                        </ul>
                                    </div>
                                </div>
                                <div class="col1">
                                    <div class="h_nav">
                                        <h4>
                                            my company</h4>
                                        <ul>
                                            <li><a href="women.html">trends</a></li>
                                            <li><a href="women.html">sale</a></li>
                                            <li><a href="women.html">style videos</a></li>
                                            <li><a href="women.html">accessories</a></li>
                                            <li><a href="women.html">kids</a></li>
                                            <li><a href="women.html">style videos</a></li>
                                        </ul>
                                    </div>
                                </div>
                                <div class="col1">
                                    <div class="h_nav">
                                        <h4>
                                            account</h4>
                                        <ul>
                                            <li><a href="women.html">login</a></li>
                                            <li><a href="women.html">create an account</a></li>
                                            <li><a href="women.html">create wishlist</a></li>
                                            <li><a href="women.html">my shopping bag</a></li>
                                            <li><a href="women.html">brands</a></li>
                                            <li><a href="women.html">create wishlist</a></li>
                                        </ul>
                                    </div>
                                </div>
                                <div class="col1">
                                    <div class="h_nav">
                                        <h4>
                                            my company</h4>
                                        <ul>
                                            <li><a href="women.html">trends</a></li>
                                            <li><a href="women.html">sale</a></li>
                                            <li><a href="women.html">style videos</a></li>
                                            <li><a href="women.html">accessories</a></li>
                                            <li><a href="women.html">kids</a></li>
                                            <li><a href="women.html">style videos</a></li>
                                        </ul>
                                    </div>
                                </div>
                                <div class="col1">
                                    <div class="h_nav">
                                        <h4>
                                            popular</h4>
                                        <ul>
                                            <li><a href="women.html">new arrivals</a></li>
                                            <li><a href="women.html">men</a></li>
                                            <li><a href="women.html">women</a></li>
                                            <li><a href="women.html">accessories</a></li>
                                            <li><a href="women.html">kids</a></li>
                                            <li><a href="women.html">style videos</a></li>
                                        </ul>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col2">
                                </div>
                                <div class="col1">
                                </div>
                                <div class="col1">
                                </div>
                                <div class="col1">
                                </div>
                                <div class="col1">
                                </div>
                            </div>
                        </div>
                    </li>
                    <li class="active grid"><a class="color4" href="#">women</a>
                        <div class="megapanel">
                            <div class="row">
                                <div class="col1">
                                    <div class="h_nav">
                                        <h4>
                                            shop</h4>
                                        <ul>
                                            <li><a href="women.html">new arrivals</a></li>
                                            <li><a href="women.html">men</a></li>
                                            <li><a href="women.html">women</a></li>
                                            <li><a href="women.html">accessories</a></li>
                                            <li><a href="women.html">kids</a></li>
                                            <li><a href="women.html">brands</a></li>
                                        </ul>
                                    </div>
                                </div>
                                <div class="col1">
                                    <div class="h_nav">
                                        <h4>
                                            help</h4>
                                        <ul>
                                            <li><a href="women.html">trends</a></li>
                                            <li><a href="women.html">sale</a></li>
                                            <li><a href="women.html">style videos</a></li>
                                            <li><a href="women.html">accessories</a></li>
                                            <li><a href="women.html">kids</a></li>
                                            <li><a href="women.html">style videos</a></li>
                                        </ul>
                                    </div>
                                </div>
                                <div class="col1">
                                    <div class="h_nav">
                                        <h4>
                                            my company</h4>
                                        <ul>
                                            <li><a href="women.html">trends</a></li>
                                            <li><a href="women.html">sale</a></li>
                                            <li><a href="women.html">style videos</a></li>
                                            <li><a href="women.html">accessories</a></li>
                                            <li><a href="women.html">kids</a></li>
                                            <li><a href="women.html">style videos</a></li>
                                        </ul>
                                    </div>
                                </div>
                                <div class="col1">
                                    <div class="h_nav">
                                        <h4>
                                            account</h4>
                                        <ul>
                                            <li><a href="women.html">login</a></li>
                                            <li><a href="women.html">create an account</a></li>
                                            <li><a href="women.html">create wishlist</a></li>
                                            <li><a href="women.html">my shopping bag</a></li>
                                            <li><a href="women.html">brands</a></li>
                                            <li><a href="women.html">create wishlist</a></li>
                                        </ul>
                                    </div>
                                </div>
                                <div class="col1">
                                    <div class="h_nav">
                                        <h4>
                                            my company</h4>
                                        <ul>
                                            <li><a href="women.html">trends</a></li>
                                            <li><a href="women.html">sale</a></li>
                                            <li><a href="women.html">style videos</a></li>
                                            <li><a href="women.html">accessories</a></li>
                                            <li><a href="women.html">kids</a></li>
                                            <li><a href="women.html">style videos</a></li>
                                        </ul>
                                    </div>
                                </div>
                                <div class="col1">
                                    <div class="h_nav">
                                        <h4>
                                            popular</h4>
                                        <ul>
                                            <li><a href="women.html">new arrivals</a></li>
                                            <li><a href="women.html">men</a></li>
                                            <li><a href="women.html">women</a></li>
                                            <li><a href="women.html">accessories</a></li>
                                            <li><a href="women.html">kids</a></li>
                                            <li><a href="women.html">style videos</a></li>
                                        </ul>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col2">
                                </div>
                                <div class="col1">
                                </div>
                                <div class="col1">
                                </div>
                                <div class="col1">
                                </div>
                                <div class="col1">
                                </div>
                            </div>
                        </div>
                    </li>
                    <li><a class="color5" href="#">accessories</a>
                        <div class="megapanel">
                            <div class="row">
                                <div class="col1">
                                    <div class="h_nav">
                                        <h4>
                                            shop</h4>
                                        <ul>
                                            <li><a href="women.html">new arrivals</a></li>
                                            <li><a href="women.html">men</a></li>
                                            <li><a href="women.html">women</a></li>
                                            <li><a href="women.html">accessories</a></li>
                                            <li><a href="women.html">kids</a></li>
                                            <li><a href="women.html">brands</a></li>
                                        </ul>
                                    </div>
                                </div>
                                <div class="col1">
                                    <div class="h_nav">
                                        <h4>
                                            help</h4>
                                        <ul>
                                            <li><a href="women.html">trends</a></li>
                                            <li><a href="women.html">sale</a></li>
                                            <li><a href="women.html">style videos</a></li>
                                            <li><a href="women.html">accessories</a></li>
                                            <li><a href="women.html">kids</a></li>
                                            <li><a href="women.html">style videos</a></li>
                                        </ul>
                                    </div>
                                </div>
                                <div class="col1">
                                    <div class="h_nav">
                                        <h4>
                                            my company</h4>
                                        <ul>
                                            <li><a href="women.html">trends</a></li>
                                            <li><a href="women.html">sale</a></li>
                                            <li><a href="women.html">style videos</a></li>
                                            <li><a href="women.html">accessories</a></li>
                                            <li><a href="women.html">kids</a></li>
                                            <li><a href="women.html">style videos</a></li>
                                        </ul>
                                    </div>
                                </div>
                                <div class="col1">
                                    <div class="h_nav">
                                        <h4>
                                            account</h4>
                                        <ul>
                                            <li><a href="women.html">login</a></li>
                                            <li><a href="women.html">create an account</a></li>
                                            <li><a href="women.html">create wishlist</a></li>
                                            <li><a href="women.html">my shopping bag</a></li>
                                            <li><a href="women.html">brands</a></li>
                                            <li><a href="women.html">create wishlist</a></li>
                                        </ul>
                                    </div>
                                </div>
                                <div class="col1">
                                    <div class="h_nav">
                                        <h4>
                                            my company</h4>
                                        <ul>
                                            <li><a href="women.html">trends</a></li>
                                            <li><a href="women.html">sale</a></li>
                                            <li><a href="women.html">style videos</a></li>
                                            <li><a href="women.html">accessories</a></li>
                                            <li><a href="women.html">kids</a></li>
                                            <li><a href="women.html">style videos</a></li>
                                        </ul>
                                    </div>
                                </div>
                                <div class="col1">
                                    <div class="h_nav">
                                        <h4>
                                            popular</h4>
                                        <ul>
                                            <li><a href="women.html">new arrivals</a></li>
                                            <li><a href="women.html">men</a></li>
                                            <li><a href="women.html">women</a></li>
                                            <li><a href="women.html">accessories</a></li>
                                            <li><a href="women.html">kids</a></li>
                                            <li><a href="women.html">style videos</a></li>
                                        </ul>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col2">
                                </div>
                                <div class="col1">
                                </div>
                                <div class="col1">
                                </div>
                                <div class="col1">
                                </div>
                                <div class="col1">
                                </div>
                            </div>
                        </div>
                    </li>
                    <li><a class="color6" href="#">kids</a>
                        <div class="megapanel">
                            <div class="row">
                                <div class="col1">
                                    <div class="h_nav">
                                        <h4>
                                            shop</h4>
                                        <ul>
                                            <li><a href="women.html">new arrivals</a></li>
                                            <li><a href="women.html">men</a></li>
                                            <li><a href="women.html">women</a></li>
                                            <li><a href="women.html">accessories</a></li>
                                            <li><a href="women.html">kids</a></li>
                                            <li><a href="women.html">brands</a></li>
                                        </ul>
                                    </div>
                                </div>
                                <div class="col1">
                                    <div class="h_nav">
                                        <h4>
                                            help</h4>
                                        <ul>
                                            <li><a href="women.html">trends</a></li>
                                            <li><a href="women.html">sale</a></li>
                                            <li><a href="women.html">style videos</a></li>
                                            <li><a href="women.html">accessories</a></li>
                                            <li><a href="women.html">kids</a></li>
                                            <li><a href="women.html">style videos</a></li>
                                        </ul>
                                    </div>
                                </div>
                                <div class="col1">
                                    <div class="h_nav">
                                        <h4>
                                            my company</h4>
                                        <ul>
                                            <li><a href="women.html">trends</a></li>
                                            <li><a href="women.html">sale</a></li>
                                            <li><a href="women.html">style videos</a></li>
                                            <li><a href="women.html">accessories</a></li>
                                            <li><a href="women.html">kids</a></li>
                                            <li><a href="women.html">style videos</a></li>
                                        </ul>
                                    </div>
                                </div>
                                <div class="col1">
                                    <div class="h_nav">
                                        <h4>
                                            account</h4>
                                        <ul>
                                            <li><a href="women.html">login</a></li>
                                            <li><a href="women.html">create an account</a></li>
                                            <li><a href="women.html">create wishlist</a></li>
                                            <li><a href="women.html">my shopping bag</a></li>
                                            <li><a href="women.html">brands</a></li>
                                            <li><a href="women.html">create wishlist</a></li>
                                        </ul>
                                    </div>
                                </div>
                                <div class="col1">
                                    <div class="h_nav">
                                        <h4>
                                            my company</h4>
                                        <ul>
                                            <li><a href="women.html">trends</a></li>
                                            <li><a href="women.html">sale</a></li>
                                            <li><a href="women.html">style videos</a></li>
                                            <li><a href="women.html">accessories</a></li>
                                            <li><a href="women.html">kids</a></li>
                                            <li><a href="women.html">style videos</a></li>
                                        </ul>
                                    </div>
                                </div>
                                <div class="col1">
                                    <div class="h_nav">
                                        <h4>
                                            popular</h4>
                                        <ul>
                                            <li><a href="women.html">new arrivals</a></li>
                                            <li><a href="women.html">men</a></li>
                                            <li><a href="women.html">women</a></li>
                                            <li><a href="women.html">accessories</a></li>
                                            <li><a href="women.html">kids</a></li>
                                            <li><a href="women.html">style videos</a></li>
                                        </ul>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col2">
                                </div>
                                <div class="col1">
                                </div>
                                <div class="col1">
                                </div>
                                <div class="col1">
                                </div>
                                <div class="col1">
                                </div>
                            </div>
                        </div>
                    </li>
                    <li><a class="color7" href="#">brands</a>
                        <div class="megapanel">
                            <div class="row">
                                <div class="col1">
                                    <div class="h_nav">
                                        <h4>
                                            shop</h4>
                                        <ul>
                                            <li><a href="women.html">new arrivals</a></li>
                                            <li><a href="women.html">men</a></li>
                                            <li><a href="women.html">women</a></li>
                                            <li><a href="women.html">accessories</a></li>
                                            <li><a href="women.html">kids</a></li>
                                            <li><a href="women.html">brands</a></li>
                                        </ul>
                                    </div>
                                </div>
                                <div class="col1">
                                    <div class="h_nav">
                                        <h4>
                                            help</h4>
                                        <ul>
                                            <li><a href="women.html">trends</a></li>
                                            <li><a href="women.html">sale</a></li>
                                            <li><a href="women.html">style videos</a></li>
                                            <li><a href="women.html">accessories</a></li>
                                            <li><a href="women.html">kids</a></li>
                                            <li><a href="women.html">style videos</a></li>
                                        </ul>
                                    </div>
                                </div>
                                <div class="col1">
                                    <div class="h_nav">
                                        <h4>
                                            my company</h4>
                                        <ul>
                                            <li><a href="women.html">trends</a></li>
                                            <li><a href="women.html">sale</a></li>
                                            <li><a href="women.html">style videos</a></li>
                                            <li><a href="women.html">accessories</a></li>
                                            <li><a href="women.html">kids</a></li>
                                            <li><a href="women.html">style videos</a></li>
                                        </ul>
                                    </div>
                                </div>
                                <div class="col1">
                                    <div class="h_nav">
                                        <h4>
                                            account</h4>
                                        <ul>
                                            <li><a href="women.html">login</a></li>
                                            <li><a href="women.html">create an account</a></li>
                                            <li><a href="women.html">create wishlist</a></li>
                                            <li><a href="women.html">my shopping bag</a></li>
                                            <li><a href="women.html">brands</a></li>
                                            <li><a href="women.html">create wishlist</a></li>
                                        </ul>
                                    </div>
                                </div>
                                <div class="col1">
                                    <div class="h_nav">
                                        <h4>
                                            my company</h4>
                                        <ul>
                                            <li><a href="women.html">trends</a></li>
                                            <li><a href="women.html">sale</a></li>
                                            <li><a href="women.html">style videos</a></li>
                                            <li><a href="women.html">accessories</a></li>
                                            <li><a href="women.html">kids</a></li>
                                            <li><a href="women.html">style videos</a></li>
                                        </ul>
                                    </div>
                                </div>
                                <div class="col1">
                                    <div class="h_nav">
                                        <h4>
                                            popular</h4>
                                        <ul>
                                            <li><a href="women.html">new arrivals</a></li>
                                            <li><a href="women.html">men</a></li>
                                            <li><a href="women.html">women</a></li>
                                            <li><a href="women.html">accessories</a></li>
                                            <li><a href="women.html">kids</a></li>
                                            <li><a href="women.html">style videos</a></li>
                                        </ul>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col2">
                                </div>
                                <div class="col1">
                                </div>
                                <div class="col1">
                                </div>
                                <div class="col1">
                                </div>
                                <div class="col1">
                                </div>
                            </div>
                        </div>
                    </li>
                    <li><a class="color8" href="#">trends</a>
                        <div class="megapanel">
                            <div class="row">
                                <div class="col1">
                                    <div class="h_nav">
                                        <h4>
                                            shop</h4>
                                        <ul>
                                            <li><a href="women.html">new arrivals</a></li>
                                            <li><a href="women.html">men</a></li>
                                            <li><a href="women.html">women</a></li>
                                            <li><a href="women.html">accessories</a></li>
                                            <li><a href="women.html">kids</a></li>
                                            <li><a href="women.html">brands</a></li>
                                        </ul>
                                    </div>
                                </div>
                                <div class="col1">
                                    <div class="h_nav">
                                        <h4>
                                            help</h4>
                                        <ul>
                                            <li><a href="women.html">trends</a></li>
                                            <li><a href="women.html">sale</a></li>
                                            <li><a href="women.html">style videos</a></li>
                                            <li><a href="women.html">accessories</a></li>
                                            <li><a href="women.html">kids</a></li>
                                            <li><a href="women.html">style videos</a></li>
                                        </ul>
                                    </div>
                                </div>
                                <div class="col1">
                                    <div class="h_nav">
                                        <h4>
                                            my company</h4>
                                        <ul>
                                            <li><a href="women.html">trends</a></li>
                                            <li><a href="women.html">sale</a></li>
                                            <li><a href="women.html">style videos</a></li>
                                            <li><a href="women.html">accessories</a></li>
                                            <li><a href="women.html">kids</a></li>
                                            <li><a href="women.html">style videos</a></li>
                                        </ul>
                                    </div>
                                </div>
                                <div class="col1">
                                    <div class="h_nav">
                                        <h4>
                                            account</h4>
                                        <ul>
                                            <li><a href="women.html">login</a></li>
                                            <li><a href="women.html">create an account</a></li>
                                            <li><a href="women.html">create wishlist</a></li>
                                            <li><a href="women.html">my shopping bag</a></li>
                                            <li><a href="women.html">brands</a></li>
                                            <li><a href="women.html">create wishlist</a></li>
                                        </ul>
                                    </div>
                                </div>
                                <div class="col1">
                                    <div class="h_nav">
                                        <h4>
                                            my company</h4>
                                        <ul>
                                            <li><a href="women.html">trends</a></li>
                                            <li><a href="women.html">sale</a></li>
                                            <li><a href="women.html">style videos</a></li>
                                            <li><a href="women.html">accessories</a></li>
                                            <li><a href="women.html">kids</a></li>
                                            <li><a href="women.html">style videos</a></li>
                                        </ul>
                                    </div>
                                </div>
                                <div class="col1">
                                    <div class="h_nav">
                                        <h4>
                                            popular</h4>
                                        <ul>
                                            <li><a href="women.html">new arrivals</a></li>
                                            <li><a href="women.html">men</a></li>
                                            <li><a href="women.html">women</a></li>
                                            <li><a href="women.html">accessories</a></li>
                                            <li><a href="women.html">kids</a></li>
                                            <li><a href="women.html">style videos</a></li>
                                        </ul>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col2">
                                </div>
                                <div class="col1">
                                </div>
                                <div class="col1">
                                </div>
                                <div class="col1">
                                </div>
                                <div class="col1">
                                </div>
                            </div>
                        </div>
                    </li>
                    <li><a class="color9" href="#">sale</a>
                        <div class="megapanel">
                            <div class="row">
                                <div class="col1">
                                    <div class="h_nav">
                                        <h4>
                                            shop</h4>
                                        <ul>
                                            <li><a href="women.html">new arrivals</a></li>
                                            <li><a href="women.html">men</a></li>
                                            <li><a href="women.html">women</a></li>
                                            <li><a href="women.html">accessories</a></li>
                                            <li><a href="women.html">kids</a></li>
                                            <li><a href="women.html">brands</a></li>
                                        </ul>
                                    </div>
                                </div>
                                <div class="col1">
                                    <div class="h_nav">
                                        <h4>
                                            help</h4>
                                        <ul>
                                            <li><a href="women.html">trends</a></li>
                                            <li><a href="women.html">sale</a></li>
                                            <li><a href="women.html">style videos</a></li>
                                            <li><a href="women.html">accessories</a></li>
                                            <li><a href="women.html">kids</a></li>
                                            <li><a href="women.html">style videos</a></li>
                                        </ul>
                                    </div>
                                </div>
                                <div class="col1">
                                    <div class="h_nav">
                                        <h4>
                                            my company</h4>
                                        <ul>
                                            <li><a href="women.html">trends</a></li>
                                            <li><a href="women.html">sale</a></li>
                                            <li><a href="women.html">style videos</a></li>
                                            <li><a href="women.html">accessories</a></li>
                                            <li><a href="women.html">kids</a></li>
                                            <li><a href="women.html">style videos</a></li>
                                        </ul>
                                    </div>
                                </div>
                                <div class="col1">
                                    <div class="h_nav">
                                        <h4>
                                            account</h4>
                                        <ul>
                                            <li><a href="women.html">login</a></li>
                                            <li><a href="women.html">create an account</a></li>
                                            <li><a href="women.html">create wishlist</a></li>
                                            <li><a href="women.html">my shopping bag</a></li>
                                            <li><a href="women.html">brands</a></li>
                                            <li><a href="women.html">create wishlist</a></li>
                                        </ul>
                                    </div>
                                </div>
                                <div class="col1">
                                    <div class="h_nav">
                                        <h4>
                                            my company</h4>
                                        <ul>
                                            <li><a href="women.html">trends</a></li>
                                            <li><a href="women.html">sale</a></li>
                                            <li><a href="women.html">style videos</a></li>
                                            <li><a href="women.html">accessories</a></li>
                                            <li><a href="women.html">kids</a></li>
                                            <li><a href="women.html">style videos</a></li>
                                        </ul>
                                    </div>
                                </div>
                                <div class="col1">
                                    <div class="h_nav">
                                        <h4>
                                            popular</h4>
                                        <ul>
                                            <li><a href="women.html">new arrivals</a></li>
                                            <li><a href="women.html">men</a></li>
                                            <li><a href="women.html">women</a></li>
                                            <li><a href="women.html">accessories</a></li>
                                            <li><a href="women.html">kids</a></li>
                                            <li><a href="women.html">style videos</a></li>
                                        </ul>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col2">
                                </div>
                                <div class="col1">
                                </div>
                                <div class="col1">
                                </div>
                                <div class="col1">
                                </div>
                                <div class="col1">
                                </div>
                            </div>
                        </div>
                    </li>
                    <li><a class="color10" href="contact.html">Contact</a>
                        <div class="megapanel">
                            <div class="row">
                                <div class="col3">
                                    <div class="h_nav">
                                        <h4>
                                            contact us</h4>
                                    </div>
                                    <form class="contact">
                                    <label for="name">
                                        Name</label>
                                    <input id="name" type="text" />
                                    <label for="email">
                                        E-mail</label>
                                    <input id="email" type="text" />
                                    <label for="message">
                                        Message</label>
                                    <textarea rows="8" id="message"></textarea>
                                    <input type="submit" value="Send" />
                                    </form>
                                </div>
                                <div class="col3">
                                </div>
                            </div>
                        </div>
                    </li>
                </ul>
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
                        <h4>
                            All</h4>
                        <ul>
                            <li><a href="women.html">women</a>
                            <ul>
                                <li>111</li>
                                <li>222</li>
                                <l1>333</l1>
                            </ul>
                            </li>
                            <li><a href="#">new arrivals</a></li>
                            <li><a href="#">trends</a></li>
                            <li><a href="#">boys</a></li>
                            <li><a href="#">girls</a></li>
                            <li><a href="#">sale</a></li>
                        </ul>
                    </div>
                    <h3>
                        filter by</h3>
                    <section class="sky-form">
					<h4>catogories</h4>
						<div class="row1 scroll-pane">
							<div class="col col-4">
								<label class="checkbox"><input type="checkbox" name="checkbox" checked=""><i></i>kurtas</label>
							</div>
							<div class="col col-4">
								<label class="checkbox"><input type="checkbox" name="checkbox"><i></i>kutis</label>
								<label class="checkbox"><input type="checkbox" name="checkbox"><i></i>churidar kurta</label>
								<label class="checkbox"><input type="checkbox" name="checkbox"><i></i>salwar</label>
								<label class="checkbox"><input type="checkbox" name="checkbox"><i></i>printed sari</label>
								<label class="checkbox"><input type="checkbox" name="checkbox" ><i></i>shree</label>
								<label class="checkbox"><input type="checkbox" name="checkbox"><i></i>Anouk</label>
								<label class="checkbox"><input type="checkbox" name="checkbox"><i></i>biba</label>
								<label class="checkbox"><input type="checkbox" name="checkbox"><i></i>fashion sari</label>
								<label class="checkbox"><input type="checkbox" name="checkbox"><i></i>fashion sari</label>
								<label class="checkbox"><input type="checkbox" name="checkbox"><i></i>fashion sari</label>
								<label class="checkbox"><input type="checkbox" name="checkbox"><i></i>fashion sari</label>
								<label class="checkbox"><input type="checkbox" name="checkbox"><i></i>fashion sari</label>
								<label class="checkbox"><input type="checkbox" name="checkbox"><i></i>fashion sari</label>
								<label class="checkbox"><input type="checkbox" name="checkbox"><i></i>fashion sari</label>
								<label class="checkbox"><input type="checkbox" name="checkbox"><i></i>fashion sari</label>	
							</div>
						</div>
		</section>
                    <section class="sky-form">
					<h4>brand</h4>
						<div class="row1 scroll-pane">
							<div class="col col-4">
								<label class="checkbox"><input type="checkbox" name="checkbox" checked=""><i></i>shree</label>
								<label class="checkbox"><input type="checkbox" name="checkbox"><i></i>Anouk</label>
								<label class="checkbox"><input type="checkbox" name="checkbox"><i></i>biba</label>
							</div>
							<div class="col col-4">
								<label class="checkbox"><input type="checkbox" name="checkbox"><i></i>vishud</label>
								<label class="checkbox"><input type="checkbox" name="checkbox"><i></i>amari</label>
								<label class="checkbox"><input type="checkbox" name="checkbox"><i></i>shree</label>
								<label class="checkbox"><input type="checkbox" name="checkbox"><i></i>Anouk</label>
								<label class="checkbox"><input type="checkbox" name="checkbox"><i></i>biba</label>
								<label class="checkbox"><input type="checkbox" name="checkbox" ><i></i>shree</label>
								<label class="checkbox"><input type="checkbox" name="checkbox"><i></i>Anouk</label>
								<label class="checkbox"><input type="checkbox" name="checkbox"><i></i>biba</label>
								<label class="checkbox"><input type="checkbox" name="checkbox"><i></i>shree</label>
								<label class="checkbox"><input type="checkbox" name="checkbox"><i></i>Anouk</label>
								<label class="checkbox"><input type="checkbox" name="checkbox"><i></i>biba</label>																								
							</div>
						</div>
		</section>
                    <section class="sky-form">
			<h4>colour</h4>
			<ul class="w_nav2">
				<li><a class="color1" href="#"></a></li>
				<li><a class="color2" href="#"></a></li>
				<li><a class="color3" href="#"></a></li>
				<li><a class="color4" href="#"></a></li>
				<li><a class="color5" href="#"></a></li>
				<li><a class="color6" href="#"></a></li>
				<li><a class="color7" href="#"></a></li>
				<li><a class="color8" href="#"></a></li>
				<li><a class="color9" href="#"></a></li>
				<li><a class="color10" href="#"></a></li>
				<li><a class="color12" href="#"></a></li>
				<li><a class="color13" href="#"></a></li>
				<li><a class="color14" href="#"></a></li>
				<li><a class="color15" href="#"></a></li>
				<li><a class="color5" href="#"></a></li>
				<li><a class="color6" href="#"></a></li>
				<li><a class="color7" href="#"></a></li>
				<li><a class="color8" href="#"></a></li>
				<li><a class="color9" href="#"></a></li>
				<li><a class="color10" href="#"></a></li>
			</ul>
		</section>
                    <section class="sky-form">
						<h4>discount</h4>
						<div class="row1 scroll-pane">
							<div class="col col-4">
								<label class="radio"><input type="radio" name="radio" checked=""><i></i>60 % and above</label>
								<label class="radio"><input type="radio" name="radio"><i></i>50 % and above</label>
								<label class="radio"><input type="radio" name="radio"><i></i>40 % and above</label>
							</div>
							<div class="col col-4">
								<label class="radio"><input type="radio" name="radio"><i></i>30 % and above</label>
								<label class="radio"><input type="radio" name="radio"><i></i>20 % and above</label>
								<label class="radio"><input type="radio" name="radio"><i></i>10 % and above</label>
							</div>
						</div>						
		</section>
                </div>
            </div>
            <!-- start content -->
            <div class="col-md-9 w_content">
                <div class="women">
                    <a href="#">
                        <h4>
                            Enthecwear - <span>4449 itemms</span>
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
                <div class="grids_of_4">
                    <div class="grid1_of_4">
                        <div class="content_box">
                            <a href="details.html">
                                <div class="view view-fifth">
                                    <img src="images/w1.jpg" class="img-responsive" alt="" />
                                    <div class="mask">
                                        <div class="info">
                                            Quick View</div>
                                    </div>
                            </a>
                        </div>
                        <h4>
                            <a href="details.html">Duis autem</a></h4>
                        <p>
                            It is a long established fact that a reader</p>
                        Rs. 499
                    </div>
                </div>
                <div class="grid1_of_4">
                    <div class="content_box">
                        <a href="details.html">
                            <div class="view view-fifth">
                                <img src="images/w2.jpg" class="img-responsive" alt="" />
                                <div class="mask">
                                    <div class="info">
                                        Quick View</div>
                                </div>
                        </a>
                    </div>
                    <h4>
                        <a href="details.html">Duis autem</a></h4>
                    <p>
                        It is a long established fact that a reader</p>
                    Rs. 499
                </div>
            </div>
            <div class="grid1_of_4">
                <div class="content_box">
                    <a href="details.html">
                        <div class="view view-fifth">
                            <img src="images/w3.jpg" class="img-responsive" alt="" />
                            <div class="mask">
                                <div class="info">
                                    Quick View</div>
                            </div>
                    </a>
                </div>
                <h4>
                    <a href="details.html">Duis autem</a></h4>
                <p>
                    It is a long established fact that a reader</p>
                Rs. 499
            </div>
        </div>
        <div class="grid1_of_4">
            <div class="content_box">
                <a href="details.html">
                    <div class="view view-fifth">
                        <img src="images/w4.jpg" class="img-responsive" alt="" />
                        <div class="mask">
                            <div class="info">
                                Quick View</div>
                        </div>
                </a>
            </div>
            <h4>
                <a href="details.html">Duis autem</a></h4>
            <p>
                It is a long established fact that a reader</p>
            Rs. 499
        </div>
    </div>
    <div class="clearfix">
    </div>
    </div>
    <div class="grids_of_4">
        <div class="grid1_of_4">
            <div class="content_box">
                <a href="details.html">
                    <div class="view view-fifth">
                        <img src="images/w5.jpg" class="img-responsive" alt="" />
                        <div class="mask">
                            <div class="info">
                                Quick View</div>
                        </div>
                </a>
            </div>
            <h4>
                <a href="details.html">Duis autem</a></h4>
            <p>
                It is a long established fact that a reader</p>
            Rs. 499
        </div>
    </div>
    <div class="grid1_of_4">
        <div class="content_box">
            <a href="details.html">
                <div class="view view-fifth">
                    <img src="images/w6.jpg" class="img-responsive" alt="" />
                    <div class="mask">
                        <div class="info">
                            Quick View</div>
                    </div>
            </a>
        </div>
        <h4>
            <a href="details.html">Duis autem</a></h4>
        <p>
            It is a long established fact that a reader</p>
        Rs. 499
    </div>
    </div>
    <div class="grid1_of_4">
        <div class="content_box">
            <a href="details.html">
                <div class="view view-fifth">
                    <img src="images/w7.jpg" class="img-responsive" alt="" />
                    <div class="mask">
                        <div class="info">
                            Quick View</div>
                    </div>
            </a>
        </div>
        <h4>
            <a href="details.html">Duis autem</a></h4>
        <p>
            It is a long established fact that a reader</p>
        Rs. 499
    </div>
    </div>
    <div class="grid1_of_4">
        <div class="content_box">
            <a href="details.html">
                <div class="view view-fifth">
                    <img src="images/w8.jpg" class="img-responsive" alt="" />
                    <div class="mask">
                        <div class="info">
                            Quick View</div>
                    </div>
            </a>
        </div>
        <h4>
            <a href="details.html">Duis autem</a></h4>
        <p>
            It is a long established fact that a reader</p>
        Rs. 499
    </div>
    </div>
    <div class="clearfix">
    </div>
    </div>
    <div class="grids_of_4">
        <div class="grid1_of_4">
            <div class="content_box">
                <a href="details.html">
                    <div class="view view-fifth">
                        <img src="images/w9.jpg" class="img-responsive" alt="" />
                        <div class="mask">
                            <div class="info">
                                Quick View</div>
                        </div>
                </a>
            </div>
            <h4>
                <a href="details.html">Duis autem</a></h4>
            <p>
                It is a long established fact that a reader</p>
            Rs. 499
        </div>
    </div>
    <div class="grid1_of_4">
        <div class="content_box">
            <a href="details.html">
                <div class="view view-fifth">
                    <img src="images/w10.jpg" class="img-responsive" alt="" />
                    <div class="mask">
                        <div class="info">
                            Quick View</div>
                    </div>
            </a>
        </div>
        <h4>
            <a href="details.html">Duis autem</a></h4>
        <p>
            It is a long established fact that a reader</p>
        Rs. 499
    </div>
    </div>
    <div class="grid1_of_4">
        <div class="content_box">
            <a href="details.html">
                <div class="view view-fifth">
                    <img src="images/w11.jpg" class="img-responsive" alt="" />
                    <div class="mask">
                        <div class="info">
                            Quick View</div>
                    </div>
            </a>
        </div>
        <h4>
            <a href="details.html">Duis autem</a></h4>
        <p>
            It is a long established fact that a reader</p>
        Rs. 499
    </div>
    </div>
    <div class="grid1_of_4">
        <div class="content_box">
            <a href="details.html">
                <div class="view view-fifth">
                    <img src="images/w12.jpg" class="img-responsive" alt="" />
                    <div class="mask">
                        <div class="info">
                            Quick View</div>
                    </div>
            </a>
        </div>
        <h4>
            <a href="details.html">Duis autem</a></h4>
        <p>
            It is a long established fact that a reader</p>
        Rs. 499
    </div>
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
    <div class="footer_top">
        <div class="container">
            <div class="span_of_4">
                <div class="span1_of_4">
                    <h4>
                        Shop</h4>
                    <ul class="f_nav">
                        <li><a href="#">new arrivals</a></li>
                        <li><a href="#">men</a></li>
                        <li><a href="#">women</a></li>
                        <li><a href="#">accessories</a></li>
                        <li><a href="#">kids</a></li>
                        <li><a href="#">brands</a></li>
                        <li><a href="#">trends</a></li>
                        <li><a href="#">sale</a></li>
                        <li><a href="#">style videos</a></li>
                    </ul>
                </div>
                <div class="span1_of_4">
                    <h4>
                        help</h4>
                    <ul class="f_nav">
                        <li><a href="#">frequently asked questions</a></li>
                        <li><a href="#">men</a></li>
                        <li><a href="#">women</a></li>
                        <li><a href="#">accessories</a></li>
                        <li><a href="#">kids</a></li>
                        <li><a href="#">brands</a></li>
                    </ul>
                    <h4 class="top">
                        company name</h4>
                    <ul class="f_nav">
                        <li><a href="#">frequently asked questions</a></li>
                        <li><a href="#">men</a></li>
                        <li><a href="#">women</a></li>
                        <li><a href="#">accessories</a></li>
                        <li><a href="#">kids</a></li>
                        <li><a href="#">brands</a></li>
                    </ul>
                </div>
                <div class="span1_of_4">
                    <h4>
                        account</h4>
                    <ul class="f_nav">
                        <li><a href="#">login</a></li>
                        <li><a href="#">create an account</a></li>
                        <li><a href="#">create wishlist</a></li>
                        <li><a href="#">my shopping bag</a></li>
                        <li><a href="#">brands</a></li>
                        <li><a href="#">create wishlist</a></li>
                    </ul>
                    <h4 class="top">
                        style zone</h4>
                    <ul class="f_nav">
                        <li><a href="#">frequently asked questions</a></li>
                        <li><a href="#">men</a></li>
                        <li><a href="#">women</a></li>
                        <li><a href="#">accessories</a></li>
                        <li><a href="#">kids</a></li>
                        <li><a href="#">brands</a></li>
                    </ul>
                </div>
                <div class="span1_of_4">
                    <h4>
                        popular</h4>
                    <ul class="f_nav">
                        <li><a href="#">new arrivals</a></li>
                        <li><a href="#">men</a></li>
                        <li><a href="#">women</a></li>
                        <li><a href="#">accessories</a></li>
                        <li><a href="#">kids</a></li>
                        <li><a href="#">brands</a></li>
                        <li><a href="#">trends</a></li>
                        <li><a href="#">sale</a></li>
                        <li><a href="#">style videos</a></li>
                        <li><a href="#">login</a></li>
                        <li><a href="#">brands</a></li>
                    </ul>
                </div>
                <div class="clearfix">
                </div>
            </div>
            <!-- start span_of_2 -->
            <div class="span_of_2">
                <div class="span1_of_2">
                    <h5>
                        need help? <a href="#">contact us <span>></span> </a>
                    </h5>
                    <p>
                        (or) Call us: +91-70-45022088</p>
                </div>
                <div class="span1_of_2">
                    <h5>
                        follow us
                    </h5>
                    <div class="social-icons">
                        <ul>
                            <li><a href="#" target="_blank"></a></li>
                            <li><a href="#" target="_blank"></a></li>
                            <li><a href="#" target="_blank"></a></li>
                            <li><a href="#" target="_blank"></a></li>
                            <li><a href="#" target="_blank"></a></li>
                        </ul>
                    </div>
                </div>
                <div class="clearfix">
                </div>
            </div>
        </div>
    </div>
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
