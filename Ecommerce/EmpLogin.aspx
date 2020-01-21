<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EmpLogin.aspx.cs" Inherits="Ecommerce.EmpLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body align="center">
    <h1>Staff Login</h1>
    <form id="form1" runat="server">
    <div align="center">
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
                <asp:Button ID="Button1" runat="server" text="Login" OnClick="Button1_Click" /> &nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" text="Cancel" OnClick="Button2_Click" />
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
