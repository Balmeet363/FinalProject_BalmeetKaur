using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Diagnostics;
namespace Finalproject_BalmeetKaur
{
    public partial class Home : System.Web.UI.Page
    {
        private static string User { get { return "root"; } }
        private static string Password { get { return ""; } }
        private static string Database { get { return "listpages"; } }
        private static string Server { get { return "localhost"; } }
        private static string Port { get { return "3306"; } }
        private static string ConnectionString
        {
            get
            {
                return "server = " + Server
                    + "; user = " + User
                    + "; database = " + Database
                    + "; port = " + Port
                    + "; password = " + Password;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            // I have created a database named listpages and page1 is a table inside it
            String query = "Select * from page1";
            var db = new listpages();
            List<Dictionary<String, String>> rs = db.List_Query(query);
            foreach (Dictionary<String, String> row in rs)
            {
                pages_list.InnerHtml += "<div class=\"listitem\">";
                pages.InnerHtml += "<div class=\"listitem\">";
                string pageid = row["pageid"];

                string pagetitle = row["pagetitle"];
                pages_list.InnerHtml += "<div class=\"col4\"><a href=\"page.aspx?pageid=" + pageid + "\">" + pagetitle +"</a></div>";
                pages.InnerHtml += "<a href=\"page.aspx?pageid=" + pageid + "\">" + pagetitle + "</a></div>";
                pages_list.InnerHtml += "<div class=\"col4last\"><a href=\"edit.aspx?pageid=" + pageid + "\">Edit</a></div>";
                pages_list.InnerHtml += "<div class=\"col4last\"><a href=\"delete.aspx?pageid=" + pageid + "\">Delete</a></div>";
                pages_list.InnerHtml += "</div>";
            }

        }
       

        
    }
}