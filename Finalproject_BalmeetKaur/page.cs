using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Finalproject_BalmeetKaur
{
    // creating a class page.cs and two strings  title and welcome quote
    public class page
    {
        private string ptitle;
        private string pquote;

        public string Gettitle()
        {
            return ptitle;
        }

        public string Getquote()
        {
            return pquote;
        }

        public void Settitle(string value)
        {
            ptitle = value;
            
        }
        public void Setquote(string value)
        {
            pquote = value;
        }
    }
}