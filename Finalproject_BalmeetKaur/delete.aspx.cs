using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Finalproject_BalmeetKaur
{
    public partial class delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool valid = true;
            string pageid = Request.QueryString["pageid"];
            if (String.IsNullOrEmpty(pageid)) valid = false;

            listpages db = new listpages();

            //deleting the page from the system
            if (valid)
            {
                db.DeletePage(Int32.Parse(pageid));
                //Redirecting to home page after deleting
                Response.Redirect("home.aspx");
            }
        }
    }
}