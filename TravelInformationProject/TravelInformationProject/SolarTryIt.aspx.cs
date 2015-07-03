using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Homework5
{
    public partial class SolarTryIt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie myCookies = Request.Cookies["myCookieId"];
            if ((myCookies != null) && (myCookies["Name"] != ""))
            {
                Label10.Text = "User: " + myCookies["Name"];
            }
            else
            {
                Label10.Text = "User: New User";
            }	
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SolarRef.Service1Client client = new SolarRef.Service1Client();
            SolarRef.inputData inputData = new SolarRef.inputData();
            SolarRef.SolarEnergyInformation outputData = new SolarRef.SolarEnergyInformation();

            if (TextBox1.Text != null)
            {
                inputData.zipcode = TextBox1.Text;
            }
            else
            {
                TextBox1.Text = "Please Enter Correct Value";
            }

            if (TextBox3.Text != null)
            {
                inputData.capacity = TextBox3.Text;
            }
            else
            {
                TextBox3.Text = "Please Enter Correct Value";
            }

            if (TextBox4.Text != null)
            {
                inputData.losses = TextBox4.Text;
            }
            else
            {
                TextBox4.Text = "Please Enter Correct Value";
            }


            outputData = client.getSolarIntensity(inputData);

            if (outputData.annualSolarRadOutput == null)
            {
                TextBox2.Text = null;
                TextBox2.Text = "Invalid Entry";
            }
            else
            {
                TextBox2.Text = null;
                for (int i = 0; i < 12; i++)
                {
                    TextBox2.Text += string.Format("\nAC Output for Month {0}: {1} kWh", i + 1, outputData.monthlyACOutput[i]);
                    TextBox2.Text += string.Format("\nDC Output for Month {0}: {1} kWh", i + 1, outputData.monthlyDCOutput[i]);
                    TextBox2.Text += string.Format("\n--------------------------------------");
                }
                TextBox2.Text += string.Format("\nAnnual Solar radiation : {0}", outputData.annualSolarRadOutput);
                TextBox2.Text += string.Format("\nAnnual AC Output :{0} kWh", outputData.annualACOutput);

            }
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Welcome.aspx");
        }
    }
}