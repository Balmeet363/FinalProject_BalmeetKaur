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
    public partial class addpage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Add_page(object sender, EventArgs e)
        {
            //create connection
            listpages db = new listpages();

            //create a new particular student
            page new_page = new page();
            //set that student data
            new_page.Settitle(pagetitle.Text);
            new_page.Setbody(pagecontent.Text);

            //add the student to the database
            summary.InnerHtml = pagetitle.Text;
            db.Addpage(new_page);


            //Response.Redirect("ListStudents.aspx");
        }
    }
}