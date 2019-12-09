using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Finalproject_BalmeetKaur
{
    public partial class edit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
            protected void Update_Page(object sender, EventArgs e)
            {
                // Christine I have made the page content static and have added a welcome quote that the new user can change everytime.
                String New_Title = new_title.Text;
                String New_Quote = new_quote.Text;
                //this connection instance is for editing data
                listpages db = new listpages();

                bool valid = true;
                string pageid = Request.QueryString["pageid"];
                if (String.IsNullOrEmpty(pageid)) valid = false;
                if (valid)
                {
                page new_page = new page();
                //set that page data
                    new_page.Settitle(New_Title);
                    new_page.Setquote(New_Quote);
               

                    //add the page to the database
                    try
                    {
                        db.UpdatePage(Int32.Parse(pageid), new_page);
                        Response.Redirect("page.aspx?pageid=" +pageid);
                    }
                    catch
                    {
                        valid = false;
                    }

                }

                if (!valid)
                {
                    
                }

            }
        }
    }