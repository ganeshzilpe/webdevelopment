using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Homework5
{
    public partial class Welcome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie myCookies = Request.Cookies["myCookieId"];
            if ((myCookies == null) || (myCookies["Name"] == ""))
            {
                Label1.Text = "Welcome, new user";
                if (myCookies["City"] == "")
                    Label2.Text = "You doesn't mention your place";
                else
                    Label2.Text = myCookies["City"];
                if (myCookies["Mobile"] == "")
                    Label3.Text = "You doesn't mention your mobile number";
                else
                    Label3.Text = myCookies["Mobile"];
            }
            else
            {
                Label1.Text = myCookies["Name"];
                Label2.Text = myCookies["City"];
                Label3.Text = myCookies["Mobile"];
            }	
        }
    }
}