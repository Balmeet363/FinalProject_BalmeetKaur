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
            
            
        }
        /*protected void FillClassOptions(listpages db)
        {
            string query = "select * from page1" ;
            List<Dictionary<String, String>> rs = db.List_Query(query);
            
            foreach (Dictionary<String, String> row in rs)
            {  
                string title = row["pagetitle"];
                string pid = row["pageid"];
                ListItem pageoption = new ListItem(title,pid);
                pageid.Items.Add(pageoption);
            }
        }*/

        
    }
}