<%@ Page Language="C#" AutoEventWireup="True" Inherits="Ecommerce.Messages" Codebehind="Messages.aspx.cs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Messages</h1>
    <form id="form1" runat="server">
    <div>
    <asp:GridView ID="GridView1" runat="server" HorizontalAlign="Center" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField="MessEmail" HeaderText="Email" />
            <asp:BoundField DataField="MessSubject" HeaderText="Subject" />
            <asp:BoundField DataField="MessDate" HeaderText="Date" />
            <asp:BoundField DataField="MessTime" HeaderText="Time" />
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:LinkButton Text="Read" ID="lnkbutton" CommandArgument='<%# Eval("MessId") %>' runat="server" OnClick="lnkbutton_OnClick" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:LinkButton Text="Delete" ID="delbutton" CommandArgument='<%# Eval("MessId") %>' runat="server" OnClick="delbutton_OnClick" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
        <br /> <br /> <br />
        <table colspan="2" align="center"><tr> <td>
        Email : </td> <td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox> </td> </tr>
       <tr> <td>Subject: </td> <td> <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox> </td> </tr>
       <tr> <td>Message </td> <td> <asp:TextBox ID="TextBox3" runat="server" TextMode="MultiLine" Height="100px"></asp:TextBox> </td> </tr>
    </table>
     </div>
    </form>
</body>
</html>
