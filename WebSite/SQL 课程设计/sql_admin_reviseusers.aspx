<%@ Page Language="C#" AutoEventWireup="true" CodeFile="sql_admin_reviseusers.aspx.cs"
    Inherits="sql_admin_index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>New Document </title>
    <meta name="Generator" content="EditPlus">
    <meta name="Author" content="">
    <meta name="Keywords" content="">
    <meta name="Description" content="">
    <script type='text/javascript' src="js/jquery-1.11.1.min.js"></script>
    <style>
        
        *{margin: 0;padding: 0;}
        h1{font-family: 楷体; padding-top:30px;}
        h3{font-family: 楷体; padding-top:30px;padding-left:20px;}
        li{font-family: 楷体;list-style-type: none;padding-top:10px;padding-left:40px;}
        .hide{display: none;}
        
        #container{margin:0 auto;width:900px;padding-top:50px;}
	    #header{height:100px;background:#6cf;margin-bottom:5px;}
	    #mainContent{margin-bottom:5px;}
	    #sidebar{float:left;width:200px;height:500px;background:#9ff;}
	    #content{float:right;width:695px;height:500px;background:#cff;}
	    #footer{height:50px;background:#6cf;margin-top:510px;}
	    #div1{margin:0 auto;text-align:center;padding-top:50px}
	    .button{font-family: 楷体;font-size:20px;height:30px;width:90px;background:#cff;}
	    table,tr,td{font-family: 楷体; font-size:20px;}
	    a:link { text-decoration: none;} 
	    input{height:20px;}
       x
    </style>
</head>
<script type="text/javascript">
    $(function () {

        $("h3").click(function () {
            $(this).next('ul').toggleClass('hide');
        })

    })
 
</script>
<body>
    <form id="form1" runat="server">
      
    <div id="container">

        <div id="header">
            <%--This is the Header--%>
            <h1 align="center"><a href="sql_admin_index.aspx">管理员界面</a></h1>
        </div>

        <div id="mainContent">

             <div id="sidebar">
                <%--This is the sidebar--%>
                <h3>
                    商品管理</h3>
                <ul class="hide">
                    <li><a href="sql_admin_addgoods.aspx" >增加商品</a></li>
                    <li><a href="sql_admin_delgoods.aspx"  >删除商品</a></li>
                    <li><a href="sql_admin_revisegoods.aspx"  >修改商品</a></li>
                    <li><a href="sql_admin_querygoods.aspx"  >查询商品</a></li>
                </ul>
                <h3>
                    用户管理</h3>
                <ul class="hide">
                    <li>增加用户</li>
                    <li>删除用户</li>
                    <li><a href="sql_admin_reviseusers.aspx">修改用户信息</a></li>
                    <li>查询用户信息</li>
                </ul>
                <h3>
                    商品入库管理</h3>
                <ul class="hide">
                    <li>商品入库</li>
                    <li>查询入库记录</li>
                </ul>
                 <h3>
                    商品出库管理</h3>
                <ul class="hide">
                    <li>商品出库</li>
                    <li>查询出库记录</li>
                </ul>
            </div>


            <div id="content">
                <div id="div1">
                   <br /> <br /> 
                   <center>
                       <table  cellspacing="20">
                            <tr>
                                <td align="right">用户名</td>
                                <td align="left"><input type="text" id="user_name" runat="server" /></td>
                            </tr>

                             <tr>
                                <td align="right">用户新名称</td>
                                <td align="left"><input type="text" id="user_new_name" runat="server" /></td>
                            </tr>

                             <tr>
                                <td align="right">用户新密码</td>
                                <td align="left"><input type="text" id="user_new_psw" runat="server" /></td>
                            </tr>
                             <tr>
                                <td align="right">用户权限</td>
                                 <td align="left">
                                    <input type="radio" name="user_new_type" value="admin" runat="server" />管理员
                                     <input type="radio" name="user_new_type" value="tourist" runat="server" />游客
                                     <input type="radio" name="user_new_type" value="member" runat="server" />会员
                                </td>
                            </tr>
                            <tr>
                                 <td align="center" colspan="2">
                                    <asp:Button ID="button1" class="button" runat="server" OnClick="Button1_Click" Text="修改" />
                                 </td>
                            </tr>
                        
                        </table>
                    </center>

                </div>
                
                 
            </div>

        </div>
        <div id="footer">
            <%--This is the footer--%>
        </div>
    </div>
    </form>
</body>
</html>
