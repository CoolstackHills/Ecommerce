<%@ Page Language="C#" AutoEventWireup="True" Inherits="Ecommerce.Index" Codebehind="Index.aspx.cs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>HAPPY HEELS</title>
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
    <section id="sectheader">
        <h2 class="header-title-1">WELCOME</h2>
        <h1 class="header-title-2">HAPPY HEELS</h1>
        <a href="#" class="header-cta-button">FIND A PAIR</a>
    </section>
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
  <h1>Home</h1>
    <section>
    <form id="form1" runat="server">
    <div  class="latestcl">
    <asp:Repeater ID="d1" runat="server">
            <ItemTemplate>
                <ul>
                    <li>
                        <div class="img">
                        <a href="ProdProf.aspx?id=<%#Eval("ID") %>">
                            <img width="200" height="300" src="<%#Eval("prodImgPath") %>" alt=""></a>
                        <div class="desc">
                            <h3><%#Eval("prodName") %></h3>
                            <div>
                                <p><%#Eval("prodCat") %></p>
                                <strong><%#Eval("prodPrice") %></strong>
                            </div>
                        </div>
                        </div>
                    </li>
                </ul>
            </ItemTemplate>
           </asp:Repeater>
    </div>
    </form>
        </section>
</body>
</html>
