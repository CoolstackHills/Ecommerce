<%@ Page Language="C#" AutoEventWireup="true" Inherits="Ecommerce.NewEmp" Codebehind="NewEmp.aspx.cs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Add New Employee</h1>  
    <asp:Table runat="server" >  
        <asp:TableRow>  
            <asp:TableCell>Employee Name </asp:TableCell><asp:TableCell><asp:TextBox runat="server" ID="textname" required></asp:TextBox></asp:TableCell>  
        </asp:TableRow>  
         <asp:TableRow>  
            <asp:TableCell>Empoyee Address </asp:TableCell><asp:TableCell><asp:TextBox runat="server" ID="textadd" TextMode="MultiLine" required></asp:TextBox></asp:TableCell>  
        </asp:TableRow>  
         <asp:TableRow>  
            <asp:TableCell>Employee Phone Number </asp:TableCell><asp:TableCell><asp:TextBox runat="server" ID="textnum" required></asp:TextBox></asp:TableCell>  
        </asp:TableRow>  
         <asp:TableRow>  
            <asp:TableCell>Employee Email </asp:TableCell><asp:TableCell><asp:TextBox runat="server" ID="texteml" required></asp:TextBox></asp:TableCell>  
        </asp:TableRow>  
         <asp:TableRow>  
            <asp:TableCell>Employee City</asp:TableCell><asp:TableCell><asp:TextBox runat="server" ID="textcit" required></asp:TextBox></asp:TableCell>  
        </asp:TableRow>
        <asp:TableRow>  
            <asp:TableCell>Employee Dept</asp:TableCell><asp:TableCell><asp:TextBox runat="server" ID="textdep" required></asp:TextBox></asp:TableCell>  
        </asp:TableRow>
        <asp:TableRow>  
            <asp:TableCell>Employee Level</asp:TableCell><asp:TableCell><asp:TextBox runat="server" ID="textlev" required></asp:TextBox></asp:TableCell>  
        </asp:TableRow>
        <asp:TableRow>  
            <asp:TableCell> Username</asp:TableCell><asp:TableCell><asp:TextBox runat="server" ID="textuser" required></asp:TextBox></asp:TableCell>  
        </asp:TableRow>
            <asp:TableRow>  
            <asp:TableCell> Password </asp:TableCell><asp:TableCell><asp:TextBox ID="textpass" runat="server" TextMode="Password" required/></asp:TableCell>  
        </asp:TableRow>  
        <asp:TableRow>  
            <asp:TableCell colspan="2" align="center" ><asp:Button runat="server" ID="btnSave"  Text="SAVE DATA" onclick="btnSave_Click"/></asp:TableCell>  
        </asp:TableRow>  
    </asp:Table>  
    </div>
        <asp:Label runat="server" ID="lblmsg"></asp:Label>
    </form>
</body>
</html>
