<%@ Page Language="C#" AutoEventWireup="true" Inherits="Ecommerce.AddProd" CodeFile="AddProd.aspx.cs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
    <h1>Add New Products</h1>  
    <asp:Table runat="server" >  
        <asp:TableRow>  
            <asp:TableCell>Product Name </asp:TableCell><asp:TableCell><asp:TextBox runat="server" ID="pName" required></asp:TextBox></asp:TableCell>  
        </asp:TableRow>  
         <asp:TableRow>  
            <asp:TableCell>Product Category </asp:TableCell><asp:TableCell><asp:TextBox runat="server" ID="pCat" required></asp:TextBox></asp:TableCell>  
        </asp:TableRow>  
         <asp:TableRow>  
            <asp:TableCell>Product Description </asp:TableCell><asp:TableCell><asp:TextBox runat="server" ID="pDesc" required></asp:TextBox></asp:TableCell>  
        </asp:TableRow>  
         <asp:TableRow>  
            <asp:TableCell>Product Price </asp:TableCell><asp:TableCell><asp:TextBox runat="server" ID="pPrice" required></asp:TextBox></asp:TableCell>  
        </asp:TableRow>  
         <asp:TableRow>  
            <asp:TableCell>Quantity Available </asp:TableCell><asp:TableCell><asp:TextBox runat="server" ID="qAvail" required></asp:TextBox></asp:TableCell>  
        </asp:TableRow>
            <asp:TableRow>  
            <asp:TableCell>Image Upload </asp:TableCell><asp:TableCell><asp:FileUpload ID="FileUpload1" runat="server"/></asp:TableCell>  
        </asp:TableRow>  
        <asp:TableRow>  
            <asp:TableCell><asp:Button runat="server" ID="btnSave"  Text="SAVE DATA" onclick="btnSave_Click"/></asp:TableCell>  
        </asp:TableRow>  
    </asp:Table>  
    </div>
        <asp:Label runat="server" ID="lblmsg"></asp:Label>
    </form>
</body>
</html>
