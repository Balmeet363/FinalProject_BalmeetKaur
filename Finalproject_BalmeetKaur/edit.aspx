<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="edit.aspx.cs" Inherits="Finalproject_BalmeetKaur.edit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <a class="right" href="edit.aspx?pageid=<%= Request.QueryString["pageid"] %>"></a>
        <div>
            <h2>Edit Page Title And Welcome Quote!</h2>
            </div>
        <div>
            <label >Enter New Title:</label>
            <asp:TextBox ID="new_title" runat="server"></asp:TextBox>
            </div>
        <div>
            <label>Enter New Welcome Quote:</label>
            <asp:TextBox runat="server" ID="new_quote"></asp:TextBox>
            </div>
        <div>
            <asp:Button Text="Edit" runat="server" OnClick="Update_Page" />
        </div>
    </form>
</body>
</html>
