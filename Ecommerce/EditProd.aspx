<%@ Page Language="C#" AutoEventWireup="true" Inherits="Ecommerce.EditProd" Codebehind="EditProd.aspx.cs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
    <h1>Edit Product</h1>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:GridView ID="gv1" runat="server" HorizontalAlign="Center" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField="prodName" HeaderText="Product Name" />
            <asp:BoundField DataField="prodPrice" HeaderText="Product Price" />
            <asp:BoundField DataField="prodCat" HeaderText="Product Category" />
            <asp:BoundField DataField="prodQua" HeaderText="Product Quantity" />
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:LinkButton Text="Select" ID="lnkbutton" CommandArgument='<%# Eval("ID") %>' runat="server" OnClick="lnkbutton_OnClick" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:LinkButton Text="Delete" ID="delbutton" CommandArgument='<%# Eval("ID") %>' runat="server" OnClick="delbutton_OnClick" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
        <br /> <br /> <br />
        <table colspan="2" align="center"><tr> 
            <td>
        ID : </td> <td><asp:TextBox ID="TextBox4" runat="server" Enabled="False"></asp:TextBox> </td> </tr>
            <tr> <td> Name : </td> <td><asp:TextBox ID="TextBox1" runat="server" required></asp:TextBox> </td> </tr>
       <tr> <td>Price : </td> <td> <asp:TextBox ID="TextBox2" runat="server" required></asp:TextBox> </td> </tr>
       <tr> <td>Quantity </td> <td> <asp:TextBox ID="TextBox3" runat="server" required></asp:TextBox> </td> </tr>
    </table>
     </div>
    <br /><br /><br /><br />
        <div align="center">
            <asp:Button ID="Button1" runat="server" Text="Update" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
