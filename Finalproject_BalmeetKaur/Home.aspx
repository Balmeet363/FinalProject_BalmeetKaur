<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Finalproject_BalmeetKaur.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
      <div class="_table">
        <div class="listitem">
            <div class="col3">Pages List</div>
            <ul>
                <li><a href="page.aspx?pageid=3">Page1</a></li>
                <li><a href="page.aspx?pageid=4">Page2</a></li>
                <li><a href="page.aspx?pageid=5">Page3</a></li>
                <li><a href="page.aspx?pageid=6">Page4</a></li>
            </ul>
        </div>
    </div> 
        
     <div>
         <a href="managepages.aspx">Manage Pages</a>
     </div>
        <div>
            <a href="addpage.aspx">Add New Page</a>
        </div>
    </form>
</body>
</html>
