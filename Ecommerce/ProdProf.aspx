<%@ Page Language="C#" AutoEventWireup="true" Inherits="Ecommerce.ProdProf" Codebehind="ProdProf.aspx.cs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Product Profile</title>
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
    <br /> <br /><br /><br />
    <form id="form1" runat="server">
    <div>
    <asp:Repeater id="d1" runat="server">
            <ItemTemplate>
        <div style="height:300px; width:600px; border-style:solid; border-width:1px;">
    <div style="height:300px; width:200px; float:left; border-style:solid; border-width:1px;">
    <img src="<%#Eval("prodImgPath") %>" height="300" width="200" />
    </div>
    <div style="height:300px; width:395px; float:left; border-style:solid; border-width:1px;">
    Product Name:<%#Eval("prodName") %><br />Category: <%#Eval("prodCat") %>
        <br />Price: <%#Eval("prodPrice") %><br /> Description: <%#Eval("prodDesc") %>
    </div>
                
    </div>
                </ItemTemplate>
        </asp:Repeater>
        <br />
        <table>
            <tr>
                <td>
                    Enter Quantity
                </td>
                   <td><asp:Textbox ID="t1" runat="server"></asp:Textbox> </td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:Label ID="l1" runat="server" ForeColor="Red" Text=""></asp:Label>
                    <asp:Label ID="l2" runat="server" ForeColor="Red" Text=""></asp:Label>
                </td>
            </tr>
        </table>
                <asp:Button ID="Button1" runat="server" Text="Add to Cart" OnClick="b1_Click"/>
                <asp:Button ID="Button2" runat="server" Text="View Cart" OnClick="b2_Click"/>

    </div>
    </form>
</body>
</html>
