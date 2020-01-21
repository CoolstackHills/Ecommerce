<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EmpIndex.aspx.cs" Inherits="Ecommerce.EmpIndex" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <div>
    <h1>Employee Page</h1>
        
    </div>
    <form id="form1" runat="server">
     <div>
        <asp:Button ID="Button1" runat="server" Text="LOG OUT" OnClick="Button1_Click" />
    </div>
        <div>
        <asp:Button ID="Button2" runat="server" Text="Register New Employee" OnClick="Button2_Click" />
            <asp:Button ID="Button3" runat="server" Text="Read Messages" OnClick="Button3_Click" />
            <asp:Button ID="Button4" runat="server" Text="Add Products" OnClick="Button4_Click" />
            <asp:Button ID="Button5" runat="server" Text="Edit Products" OnClick="Button5_Click" />
    </div>
    </form>
    </body>
</html>
