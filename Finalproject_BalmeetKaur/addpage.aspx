<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addpage.aspx.cs" Inherits="Finalproject_BalmeetKaur.addpage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Enter Page Title:</h3>
            <asp:TextBox ID="pagetitle" runat="server"></asp:TextBox>
            <h3>Enter Page Content:</h3>
            <asp:TextBox ID="pagecontent" runat="server"></asp:TextBox>
            <asp:Button OnClick="Add_page" Text="Add" runat="server" />
        </div>
        <div id="summary" runat="server"></div>
    </form>
</body>
</html>
