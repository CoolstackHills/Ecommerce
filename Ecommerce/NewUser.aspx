<%@ Page Language="C#" AutoEventWireup="True" Inherits="Ecommerce.NewUser" Codebehind="NewUser.aspx.cs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration Page</title>
    <link rel="stylesheet" type="text/css" href="Indexstyle.css">
</head>
<body>
    <header>
         <nav>
            <h2 class="logo"><img src="logo.png" alt="HAPPY HEELS"></h2>
                <ul class="nav-menu">
                    <li><a href="Index.aspx">HOME</a></li>
                    <li><a href="#">TRENDS</a></li>
                    <li><a href="#">STORES</a></li>
                    <li><a href="ContactUs.aspx">CONTACT US</a></li>
                </ul>
        </nav>
    </header>
    <br /> <br /><br /><br />
    <div class="reg">
    <form id="form1" runat="server">
     <div>
    <h1>Registration Page</h1>  
    <asp:Table runat="server" CssClass="treg">  
        <asp:TableRow>  
            <asp:TableCell>First Name </asp:TableCell><asp:TableCell><asp:TextBox runat="server" ID="textfname" required></asp:TextBox></asp:TableCell>  
        </asp:TableRow>  
         <asp:TableRow>  
            <asp:TableCell>Last Name </asp:TableCell><asp:TableCell><asp:TextBox runat="server" ID="textlname" required></asp:TextBox></asp:TableCell>  
        </asp:TableRow>  
         <asp:TableRow>  
            <asp:TableCell>Email</asp:TableCell><asp:TableCell><asp:TextBox runat="server" ID="textemail" required></asp:TextBox></asp:TableCell>  
        </asp:TableRow>  
         <asp:TableRow>  
            <asp:TableCell>Phone Number</asp:TableCell><asp:TableCell><asp:TextBox runat="server" ID="textnum" required></asp:TextBox></asp:TableCell>  
        </asp:TableRow>  
         <asp:TableRow>  
            <asp:TableCell>Address</asp:TableCell><asp:TableCell><asp:TextBox runat="server" ID="textadd"  TextMode="MultiLine" required></asp:TextBox></asp:TableCell>  
        </asp:TableRow>
        <asp:TableRow>  
            <asp:TableCell>City</asp:TableCell><asp:TableCell><asp:TextBox runat="server" ID="textcity" required></asp:TextBox></asp:TableCell>  
        </asp:TableRow>
        <asp:TableRow>  
            <asp:TableCell>State</asp:TableCell><asp:TableCell><asp:TextBox runat="server" ID="textstate" required></asp:TextBox></asp:TableCell>  
        </asp:TableRow>
        <asp:TableRow>  
            <asp:TableCell> Username</asp:TableCell><asp:TableCell><asp:TextBox runat="server" ID="textuser" required></asp:TextBox></asp:TableCell>  
        </asp:TableRow>
            <asp:TableRow>  
            <asp:TableCell> Password </asp:TableCell><asp:TableCell><asp:TextBox ID="textpass" runat="server" TextMode="Password" required/></asp:TableCell>  
        </asp:TableRow>  
        <asp:TableRow>  
            <asp:TableCell colspan="2" align="center"><asp:Button runat="server" ID="btnSave"  Text="SAVE DATA" onclick="btnSave_Click"/></asp:TableCell>  
        </asp:TableRow>  
    </asp:Table>  
    </div>
        <asp:Label runat="server" ID="lblmsg"></asp:Label>
    </form>
        </div>
</body>
</html>
