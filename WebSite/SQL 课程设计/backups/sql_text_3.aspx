<%@ Page Language="C#" AutoEventWireup="true" CodeFile="sql_text_3.aspx.cs" Inherits="sql_text_3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>


      <div>

        <asp:Label ID="Label1" runat="server" Text="user_id"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="user_psw"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" />
        <asp:Label ID="output1" runat="server" Text=''></asp:Label>
       
    </div>

 

    <div>
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
    </div>


    </div>
    </form>
</body>
</html>
