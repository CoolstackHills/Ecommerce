<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserLogin.aspx.cs" Inherits="Ecommerce.UserLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
        <tr>
            <td>Enter Username:</td>
            <td><asp:TextBox ID="t1" runat="server" required></asp:TextBox></td>
        </tr>
        <tr>
            <td>Enter Password:</td>
            <td><asp:TextBox ID="t2" runat="server" TextMode="Password" required></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="2" align="center">
                <asp:Button ID="Button1" runat="server" text="Login" OnClick="Button1_Click" />
            </td>
            </tr>
        <td colspan="2" align="center">
            <asp:LinkButton ID="LinkButton1" runat="server" ForeColor="Blue" OnClick="LinkButton1_Click">Register</asp:LinkButton>
            </td>
            </tr>
        <td colspan="2" align="center">
                <asp:Label ID="Label1" runat="server" ForeColor="Red" />
            </td>
            </tr>
    </table>
    </div>
    </form>
</body>
</html>
