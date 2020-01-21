<%@ Page Language="C#" AutoEventWireup="true" Inherits="Ecommerce.ContactUs" Codebehind="ContactUs.aspx.cs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Contact Us</title>
    <link rel="stylesheet" type="text/css" href="Indexstyle.css">
</head>
<body>  <header>
         <nav>
            <h2 class="logo"><img src="logo.png" alt="HAPPY HEELS"></h2>
                <ul class="nav-menu">
                    <li><a href="#">NEW STOCK</a></li>
                    <li><a href="#">TRENDS</a></li>
                    <li><a href="#">STORES</a></li>
                    <li><a href="ContactUs.aspx">CONTACT US</a></li>
                </ul>
        </nav>
    </header>
     <br />
    <section id="sectprof" runat="server">
        <div>
            <div>
                Already a member? <br />
                <a href="UserLogin.aspx">Login</a>
            </div>
        </div>
    </section>
    <section id="Section1" runat="server">
        <div>
            <div>
                <asp:Label ID="Label1" runat="server" Text=""></asp:Label><br />
                <a href="Logout.aspx">Logout</a>
            </div>
        </div>
    </section>
    <form id="form1" runat="server">
    <div align="center">
    <h1>Contact Us</h1>  
    <asp:Table runat="server" >  
        <asp:TableRow>  
            <asp:TableCell>Email </asp:TableCell><asp:TableCell><asp:TextBox runat="server" ID="textemail" TextMode="Email" required></asp:TextBox></asp:TableCell>  
        </asp:TableRow>  
         <asp:TableRow>  
            <asp:TableCell>Subject</asp:TableCell><asp:TableCell><asp:TextBox runat="server" ID="textsubject" required></asp:TextBox></asp:TableCell>  
        </asp:TableRow>  
         <asp:TableRow>  
            <asp:TableCell>Message </asp:TableCell><asp:TableCell><asp:TextBox runat="server" ID="textmessage" TextMode="MultiLine" Height="100px" required></asp:TextBox></asp:TableCell>  
        </asp:TableRow>
        <asp:TableRow>  
            <asp:TableCell> </asp:TableCell><asp:TableCell> </asp:TableCell>  
        </asp:TableRow>              
        <asp:TableRow> 
            <asp:TableCell> </asp:TableCell><asp:TableCell><asp:Button runat="server" ID="btnSave"  Text="SEND MESSAGE" onclick="btnSave_Click"/></asp:TableCell>  
        </asp:TableRow>  
    </asp:Table>  
    </di>
        <asp:Label runat="server" ID="lblmsg"></asp:Label>
    </form>
</body>
</html>
