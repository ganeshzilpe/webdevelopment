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
    public partial class TravelCostTryIt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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
        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string originAddress, destinationAddress, travelCost, travelChoice;
            if (startingAddressTextbox.Text == null || destinationAddressTextbox.Text == null)
            {
                travelCostTextbox.Text = null;
                travelCostTextbox.Text = "Enter both addresses";
            }
            else
            {
                try
                {
                    originAddress = startingAddressTextbox.Text.ToString();
                    destinationAddress = destinationAddressTextbox.Text.ToString();
                    travelChoice = RadioButtonList1.SelectedItem.Text;

                    string url1 = @"http://10.1.12.43:8001/travelcost/Service1.svc/getTravelCost/" + originAddress + "/" + destinationAddress + "/" + travelChoice;
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url1);
                    WebResponse response = request.GetResponse();
                    Stream dataStream = response.GetResponseStream();
                    StreamReader sreader = new StreamReader(dataStream);
                    travelCost = sreader.ReadToEnd();

                    string[] data = travelCost.Split('>');
                    travelCost = data[1];
                    data = travelCost.Split('<');
                    travelCost = data[0];


                    response.Close();

                    string[] values = travelCost.Split('+');

                    try
                    {

                        if (values == null && values[2].Equals(""))
                        {
                            travelCostTextbox.Text = null;
                            travelCostTextbox.Text = "Invalid Address";
                        }
                        else
                        {
                            travelCostTextbox.Text = null;
                            travelCostTextbox.Text = "$ " + values[2];
                            out_total_dist.Text = values[1] + " miles";
                            out_total_time.Text = values[0] + " Minutes";
                        }
                    }
                    catch
                    {
                        travelCostTextbox.Text = null;
                        travelCostTextbox.Text = "Invalid input";
                    }
                }
                catch (Exception exce)
                {
                    out_total_dist.Text = "Invalid Address";
                    out_total_time.Text = "Invalid Address";
                    travelCostTextbox.Text = "Invalid input";
                }
            }

        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Welcome.aspx");
        }
    }
}