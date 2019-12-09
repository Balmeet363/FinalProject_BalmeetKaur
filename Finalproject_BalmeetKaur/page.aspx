<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="page.aspx.cs" Inherits="Finalproject_BalmeetKaur.page1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link rel="stylesheet" type="text/css" href="/Content/Style.css" />
</head>
<body>
    <form id="form1" runat="server">
        
        <a class="right" href="page.aspx?pageid=<%= Request.QueryString["pageid"] %>"></a>
        <div id="pageheading" runat="server"></div>
        <asp:Button runat="server" OnClick="back_page" Text="Back" />
        <div id="pagecontent" runat="server"></div>
        <div id="pagebody">This is a social media page.
            Socil media is touching the sky day by day due to advancement in technology.
            It is helping people a lot to explore more and more in their respective fields.
            Person can spend their leisure time in doing various activities on social media.
            Many have also get their jobs from this and are working in their in respective fiels in an efficient manner.
            Uncountable advancements have been put into this phase as compared to the earlier days.

        </div>
        <div id="pagefooter">Contact:6478704485 Email:abc@gmail.com</div>
    </form>
</body>
</html>
