using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace Homework5
{
    public partial class WindTryIt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Cache["WindZipCode"] != null && zipCodeTextbox.Text == "")
            {
                zipCodeTextbox.Text = "" + Cache["WindZipCode"].ToString();
            }
            HttpCookie myCookies = Request.Cookies["myCookieId"];
            if ((myCookies != null) && (myCookies["Name"] != ""))
            {
                Label7.Text = "User: " + myCookies["Name"];
            }
            else
            {
                Label7.Text = "User: New User";
            }	
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Cache["WindZipCode"] != null && (("" + Cache["WindZipCode"].ToString()).Equals(zipCodeTextbox.Text)))
            {
                windInfoTextbox.Text = "" + Cache["WindResult"].ToString();
            }
            else
            {
                try
                {
                    string url = @"http://10.1.12.43:8001/windservice/Service1.svc/windInfo/" + zipCodeTextbox.Text;
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                    WebResponse response = request.GetResponse();
                    Stream dataStream = response.GetResponseStream();
                    StreamReader sreader = new StreamReader(dataStream);
                    string responsereader = sreader.ReadToEnd();

                    string[] data = responsereader.Split('>');
                    responsereader = data[1];
                    data = responsereader.Split('<');
                    responsereader = data[0];

                    response.Close();

                    windInfoTextbox.Text = responsereader;
                    Cache.Insert("WindZipCode", zipCodeTextbox.Text);
                    Cache.Insert("WindResult", responsereader);
                }
                catch (Exception exce)
                {
                    windInfoTextbox.Text = "Zip code not found. \nEnter valid Zip code";
                }
            }
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Welcome.aspx");
        }
    }
}