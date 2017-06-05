<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ShoppingHeart.Admin.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="margin: 200px;">
        <table  align="center" style="border: 1px ridge #999999; width: 450px; ">
            <tr>
                <td style="text-align:center" colspan="2">
                    <asp:Label ID="Label1" runat="server" Font-Names="Aharoni" ForeColor="#0033CC" Text="shopping online- AdminPanel1"
                        Style="font-weight:700"></asp:Label>
                    <hr />
                </td>
            </tr>
            <tr>
                <td style="text-align:center; width: 50%;">
                    LoginId :                                                      
                </td>
                <td style="width: 50%;">
                    <asp:TextBox ID="txtLoginId" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="text-align:center; width: 50%;">
                    Password :                                                      
                </td>
                <td style="width: 50%;">
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 50%;" align="center">
                    &nbsp;
                </td>
                <td style="width: 50%;">
                    <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
                </td>
            </tr>
            <tr>
                <td align="center" colspan="2">
                    <hr />
                    <asp:Label ID="lblAlert" runat="server" Font-Names="Aharoni" ForeColor="Red"></asp:Label>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>

