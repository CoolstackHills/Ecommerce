<%@ Page Language="C#" AutoEventWireup="true" Inherits="Ecommerce.ViewCart" Codebehind="ViewCart.aspx.cs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
    <h1>View Cart</h1>
    </div>
        <div>

        <asp:DataList ID="d1" runat="server">
            <HeaderTemplate>
                <table border="0" style=" border:0px;">
                    <tr style="background-color:silver; color:white; font-weight:bold;">
                        <td>Product Image</td>
                        <td>Product Name</td>
                        <td>Product Category</td>
                        <td>Product Price</td>
                        <td>Product Description</td>
                        <td>Product Quantity</td>
                        <td>Delete</td>
                    </tr>
            </HeaderTemplate>
            <ItemTemplate>
            <tr>
                <td><img src="<%#Eval("prodimg") %>" height="100" width="100"/></td>
                <td><%#Eval("prodname") %></td>
                <td><%#Eval("prodcat") %></td>
                <td><%#Eval("prodprice") %></td>
                <td><%#Eval("proddesc") %></td>
                <td><%#Eval("prodqua1") %></td>
                <td><a href="delcart.aspx?id=<%#Eval("id") %>" >Delete</a></td>
            </tr>
                </ItemTemplate>
            <FooterTemplate>
        </table>
                </FooterTemplate>
            </asp:DataList>
            <br />
            <p align="center">
                <asp:Label ID="li" runat="server"></asp:Label>
            </p>

    </div>
    </form>
</body>
</html>
