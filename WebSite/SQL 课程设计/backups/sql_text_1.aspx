<%@ Page Language="C#" AutoEventWireup="true" CodeFile="sql_text_1.aspx.cs" Inherits="sql_text_1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>


        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
            SelectCommand="select * from goods">
        </asp:SqlDataSource>



         <div>
        <asp:ListView ID="ListView1" runat="server" DataKeyNames="goods_id" 
            DataSourceID="SqlDataSource1">
            <AlternatingItemTemplate>
                <tr style="">
                    <td>
                        <asp:Label ID="goods_idLabel" runat="server" Text='<%# Eval("goods_id") %>' />
                    </td>
                    <td>
                        <asp:Label ID="goods_nameLabel" runat="server" Text='<%# Eval("goods_name") %>' />
                    </td>
                    <td>
                        <asp:Label ID="goods_priceLabel" runat="server" Text='<%# Eval("goods_price") %>' />
                    </td>
                </tr>
            </AlternatingItemTemplate>

            <EditItemTemplate>
                <tr style="">
                    <td>
                        <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="更新" />
                        <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="取消" />
                    </td>
                    <td>
                        <asp:Label ID="goods_idLabel1" runat="server" Text='<%# Eval("goods_id") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="goods_nameTextBox" runat="server" Text='<%# Bind("goods_name") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="goods_priceTextBox" runat="server" Text='<%# Bind("goods_price") %>' />
                    </td>
                </tr>
            </EditItemTemplate>
            <EmptyDataTemplate>
                <table id="Table1" runat="server" style="">
                    <tr>
                        <td>
                            未返回数据。</td>
                    </tr>
                </table>
            </EmptyDataTemplate>
            <InsertItemTemplate>
                <tr style="">
                    <td>
                        <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="插入" />
                        <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="清除" />
                    </td>
                    <td>
                        <asp:TextBox ID="goods_idTextBox" runat="server" Text='<%# Bind("goods_id") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="goods_nameTextBox" runat="server" Text='<%# Bind("goods_name") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="goods_priceTextBox" runat="server" Text='<%# Bind("goods_price") %>' />
                    </td>
                </tr>
            </InsertItemTemplate>
            <ItemTemplate>
                <tr style="">
                    <td>
                        <asp:Label ID="goods_idLabel" runat="server" Text='<%# Eval("goods_id") %>' />
                    </td>
                    <td>
                        <asp:Label ID="goods_nameLabel" runat="server" Text='<%# Eval("goods_name") %>' />
                    </td>
                    <td>
                        <asp:Label ID="goods_priceLabel" runat="server" Text='<%# Eval("goods_price") %>' />
                    </td>
                </tr>
            </ItemTemplate>

            <LayoutTemplate>
                <table id="Table2" runat="server">
                    <tr id="Tr1" runat="server">
                        <td id="Td1" runat="server">
                            <table ID="itemPlaceholderContainer" runat="server" border="0" style="">
                                <tr id="Tr2" runat="server" style="">
                                    <th id="Th1" runat="server">
                                        goods_id</th>
                                    <th id="Th2" runat="server">
                                        goods_name</th>
                                    <th id="Th3" runat="server">
                                        goods_price</th>
                                </tr>
                                <tr ID="itemPlaceholder" runat="server">
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr id="Tr3" runat="server">
                        <td id="Td2" runat="server" style="">
                        </td>
                    </tr>
                </table>
            </LayoutTemplate>
            <SelectedItemTemplate>
                <tr style="">
                    <td>
                        <asp:Label ID="goods_idLabel" runat="server" Text='<%# Eval("goods_id") %>' />
                    </td>
                    <td>
                        <asp:Label ID="goods_nameLabel" runat="server" Text='<%# Eval("goods_name") %>' />
                    </td>
                    <td>
                        <asp:Label ID="goods_priceLabel" runat="server" Text='<%# Eval("goods_price") %>' />
                    </td>
                </tr>
            </SelectedItemTemplate>
        </asp:ListView>
    
    </div>


    </div>
    </form>
</body>
</html>
