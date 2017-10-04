<%@ Page Language="C#" AutoEventWireup="true" CodeFile="sql_login.aspx.cs" Inherits="sql_text_3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script type='text/javascript' src="js/jquery-1.11.1.min.js"></script>
    <title></title>
     <style>
        *{margin: 0;padding: 0;}
	    .button{font-family: 楷体;font-size:20px;height:35px;width:350px;background:white;}
	     table{font-family: 楷体; font-size:30px;width:350px; height:50px; text-align:center;padding-top:300px}
	    input{height:25px;}   	    	    
    </style>
    <script type="text/javascript">
         $(function () {
             $("#users_psw").val("123");
         })
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <center>
            <div id="div1">
                <table cellspacing="20">
                    <tr><td align="right">用户账号</td>
                        <td align="left"><input type="text" id="users_name" runat="server" value='user1' /></td>
                    </tr>
                    <tr>
                        <td align="right">用户密码</td>
                        <td align="left"><input type="password" id="users_psw" runat="server" /></td>
                    </tr>
                    <tr>
                        <td align="center" colspan="2">
                            <asp:Button ID="button1" class="button" runat="server" OnClick="Button1_Click" Text="登陆" />
                        </td>
                    </tr>
                </table>
              
            </div>
        </center>
     
        <%--<div>
        <asp:GridView ID="GridView1" runat="server" CssClass="table" AutoGenerateColumns="False"
            EnableViewState="false">
            <Columns>
                <asp:BoundField DataField="users_id" HeaderText="users_id" />
                <asp:BoundField DataField="users_name" HeaderText="users_name" />
                <asp:BoundField DataField="users_psw" HeaderText="users_psw" />
                <asp:BoundField DataField="users_sex" HeaderText="users_sex" />
                <asp:BoundField DataField="users_type" HeaderText="users_type" />
                <asp:BoundField DataField="users_address" HeaderText="users_address" />
                <asp:BoundField DataField="users_phone" HeaderText="users_phone" />
                <asp:BoundField DataField="users_balance" HeaderText="users_balance" />
                <asp:BoundField DataField="users_real_name" HeaderText="users_real_name" />
            </Columns>
        </asp:GridView>
    </div>--%>


    </div>
    </form>
</body>
</html>
