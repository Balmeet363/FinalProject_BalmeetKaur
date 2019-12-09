<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="delete.aspx.cs" Inherits="Finalproject_BalmeetKaur.delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div runat="server">
            <!-- Retrieving page id for deleting page -->
            <a class="right" href="delete.aspx?pageid=<%= Request.QueryString["pageid"] %>"></a>
        </div>
        <div id="summary" runat="server"></div>
    </form>
</body>
</html>
