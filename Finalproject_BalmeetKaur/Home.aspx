<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Finalproject_BalmeetKaur.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="/Content/Style.css" />
</head>
<body>
    <!--Christine I was not well so I have not added any designing All the pages are working but no designing is there
        Sorry for late submission
        -->
    <form id="form1" runat="server">
      <div class="_table">
        <div class="listitem">
            <div class="col3"><h2>Pages:</h2></div>
        </div>
    </div> 
        <div id="pages" runat="server"></div>
        <div class="listitem">
     <div class="col3">
         <div id="manage_pages"><h2>Manage Pages</h2></div>
          <div id="add_page">
              <a href="addpage.aspx">Add New Page</a> 

          </div>
    </div></div>
        <div class="_table" runat="server">
        <div class="listitem">
            <div class="col4">Title</div>
            <div class="col4last">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                Action</div> 
        </div>
        </div>
        <div id="pages_list" runat="server"></div>
    </form>
</body>
</html>
