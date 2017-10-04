<%@ Page Language="C#" AutoEventWireup="true" CodeFile="sql_text_2.aspx.cs" Inherits="sql_text_2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        table
        {
            border: 1px solid black;
        }
        table, tr, td
        {
            border: 1px solid black;
        }
        table tr td input
        {
            height: 16px;
            width: 55px;
            margin: 0 2px;
        }
        .hide
        {
            display: none;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="goods_id"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="goods_name"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="goods_price"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="goods_num"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="添加" />
        <asp:Label ID="output" runat="server" Text=''></asp:Label>
        <br />
        <br />
        <br />
        <br />
    </div>
    <div>
        <asp:Label ID="Label11" runat="server" Text="goods_id"></asp:Label>
        <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button11" runat="server" OnClick="Button11_Click" Text="删除" />
        <asp:Label ID="output1" runat="server" Text=''></asp:Label>
        <br />
        <br />
        <br />
        <br />
    </div>

    <div>

        <asp:Label ID="Label5" runat="server" Text="goods_id"></asp:Label>
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label6" runat="server" Text="goods_New_name"></asp:Label>
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1111" runat="server" OnClick="Button1111_Click" Text="修改" />
        <asp:Label ID="output3" runat="server" Text=''></asp:Label>
        <br />
        <br />
        <br />
        <br />
    </div>


    <div>
        <table class="hide">
            <tr>
                <td>
                    Id
                </td>
                <td>
                    Name
                </td>
                <td>
                    Price
                </td>
                <td>
                    Img
                </td>
            </tr>
            <asp:Repeater ID="rptProducts" runat="server">
                <ItemTemplate>
                    <tr>
                        <td>
                            <%#Eval("Id") %>
                        </td>
                        <td>
                            <%#Eval("Name") %>
                        </td>
                        <td>
                            <%#Eval("Price") %>
                        </td>
                        <td>
                            <img src="<%#Eval("Imgpath") %>" />
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>
    </div>
    

    <div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" EnableViewState="false"
            CellPadding="4">
            <Columns>
                <asp:BoundField DataField="goods_id" HeaderText="Id" />
                <asp:BoundField DataField="goods_name" HeaderText="Name" />
                <asp:BoundField DataField="goods_Price" HeaderText="Price" />
                <asp:BoundField DataField="goods_img" HeaderText="Img" />
                <asp:BoundField DataField="goods_num" HeaderText="Num" />
            </Columns>

        </asp:GridView>        
    </div>

    </form>
</body>
</html>
