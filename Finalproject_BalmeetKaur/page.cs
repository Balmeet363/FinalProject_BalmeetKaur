using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Finalproject_BalmeetKaur
{
    public class page
    {
        private string ptitle;
        private string pbody;

        public string Gettitle()
        {
            return ptitle;
        }

        public string Getbody()
        {
            return pbody;
        }

        public void Settitle(string value)
        {
            ptitle = value;
            
        }
        public void Setbody(string value)
        {
            pbody = value;
        }
    }
}