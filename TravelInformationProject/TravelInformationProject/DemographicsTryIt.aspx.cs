using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Net;
using System.Xml;
using System.IO;
using System.Collections.Specialized;

namespace Homework5
{
    public partial class DemographicsTryIt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Cache["ZipCode"] != null && TextBox1.Text == "")
            {
                TextBox1.Text = "" + Cache["ZipCode"].ToString();
            }
            HttpCookie myCookies = Request.Cookies["myCookieId"];
            if ((myCookies != null) && (myCookies["Name"] != ""))
            {
                Label3.Text = "User: " + myCookies["Name"];
            }
            else
            {
                Label3.Text = "User: New User";
            }
                
        }
        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string demographicData = "";
            if (Cache["ZipCode"] != null && (("" + Cache["ZipCode"].ToString()).Equals(TextBox1.Text)))
            {
                TextBox2.Text = ""+Cache["Result"].ToString();
            }
            else
            {
                try
                {
                    string url1 = @"http://10.1.12.43:8001/demographic/Service1.svc/getDemographics/" + TextBox1.Text;
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url1);
                    WebResponse response = request.GetResponse();
                    Stream dataStream = response.GetResponseStream();
                    StreamReader sreader = new StreamReader(dataStream);
                    demographicData = sreader.ReadToEnd();
                    response.Close();

                    string[] data = demographicData.Split('>');
                    demographicData = data[1];
                    data = demographicData.Split('<');
                    demographicData = data[0];
                    TextBox2.Text = demographicData;
                    Cache.Insert("ZipCode", TextBox1.Text);
                    Cache.Insert("Result", demographicData);

                }
                catch
                {
                    TextBox2.Text = "Wrong Zip code. Enter Valid Zip code.";
                    return;
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Welcome.aspx");
        }
    }
}