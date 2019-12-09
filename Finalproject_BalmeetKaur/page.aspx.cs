using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Finalproject_BalmeetKaur
{
    public partial class page1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool valid = true;
            string pageid = Request.QueryString["pageid"];
            String query = "Select * from page1 where pageid=" + pageid;
            var db = new listpages();
            List<Dictionary<String, String>> rs = db.List_Query(query);
            foreach (Dictionary<String, String> row in rs)
            {


                string pagetitle = row["pagetitle"];
                string pagebody = row["pagebody"];
                pageheading.InnerHtml = "<h2>" + pagetitle + "</h2>";
                pagecontent.InnerHtml = pagebody;

            }
        }

        protected void back_page(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}