using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Homework5
{
    public partial class WeatherTryIt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Cache["WeatherZipCode"] != null && TextBox1.Text == "")
            {
                TextBox1.Text = "" + Cache["WeatherZipCode"].ToString();
            }
            HttpCookie myCookies = Request.Cookies["myCookieId"];
            if ((myCookies != null) && (myCookies["Name"] != ""))
            {
                Label5.Text = "User: " + myCookies["Name"];
            }
            else
            {
                Label5.Text = "User: New User";
            }	
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Cache["WeatherZipCode"] != null && (("" + Cache["WeatherZipCode"].ToString()).Equals(TextBox1.Text)))
            {
                weatherRef.ForecastInformation forecastInfo = (weatherRef.ForecastInformation)Cache["WeatherResult"];

                for (int i = 0; i < 3; i++)
                {
                    if (i == 0)
                    {
                        TextBox2.Text += "\n\nMaximum Temperature for Today = " + forecastInfo.maximumTempInfo[i] + " deg F";
                        TextBox2.Text += "\nMinimum Temperature for Today = " + forecastInfo.minimumTempInfo[i] + " deg F";
                        TextBox2.Text += "\nSnow possibility for Today = " + forecastInfo.SnowInfo[i] + " mm";
                        TextBox2.Text += "\nWind possibility for Today = " + forecastInfo.WindInfo[i] + " m/s";
                        TextBox2.Text += "\nRain possibility for Today = " + forecastInfo.RainInfo[i] + " mm";
                        TextBox2.Text += "\n------------------------------------------------------";
                    }
                    else
                    {
                        TextBox2.Text += "\n\nMaximum Temperature for the day " + i + " = " + forecastInfo.maximumTempInfo[i] + " deg F";
                        TextBox2.Text += "\nMinimum Temperature for the day " + i + " = " + forecastInfo.minimumTempInfo[i] + " deg F";
                        TextBox2.Text += "\nSnow possibility for the day " + i + " = " + forecastInfo.SnowInfo[i] + " mm";
                        TextBox2.Text += "\nWind possibility for the day " + i + " = " + forecastInfo.WindInfo[i] + " m/s";
                        TextBox2.Text += "\nRain possibility for the day " + i + " = " + forecastInfo.RainInfo[i] + " mm";
                        TextBox2.Text += "\n------------------------------------------------------";
                    }
                }

                TextBox2.Text += "\nProbability of Thunderstorm among 3 days= " + forecastInfo.StormInfo + @" %";
                TextBox2.Text += "\nProbability of Tornado among 3 days= " + forecastInfo.TornadoInfo + @" %";
            }
            else
            {
                weatherRef.Service1Client client = new weatherRef.Service1Client();
                weatherRef.ForecastInformation forecastInfo;
                forecastInfo = client.getWeatherForecast(TextBox1.Text.ToString());

                TextBox2.Text = null;
                if (forecastInfo.maximumTempInfo[0] == null)
                {
                    TextBox2.Text = "Invalid zip code";

                }
                else
                {
                    for (int i = 0; i < 3; i++)
                    {
                        if (i == 0)
                        {
                            TextBox2.Text += "\n\nMaximum Temperature for Today = " + forecastInfo.maximumTempInfo[i] + " deg F";
                            TextBox2.Text += "\nMinimum Temperature for Today = " + forecastInfo.minimumTempInfo[i] + " deg F";
                            TextBox2.Text += "\nSnow possibility for Today = " + forecastInfo.SnowInfo[i] + " mm";
                            TextBox2.Text += "\nWind possibility for Today = " + forecastInfo.WindInfo[i] + " m/s";
                            TextBox2.Text += "\nRain possibility for Today = " + forecastInfo.RainInfo[i] + " mm";
                            TextBox2.Text += "\n------------------------------------------------------";
                        }
                        else
                        {
                            TextBox2.Text += "\n\nMaximum Temperature for the day " + i + " = " + forecastInfo.maximumTempInfo[i] + " deg F";
                            TextBox2.Text += "\nMinimum Temperature for the day " + i + " = " + forecastInfo.minimumTempInfo[i] + " deg F";
                            TextBox2.Text += "\nSnow possibility for the day " + i + " = " + forecastInfo.SnowInfo[i] + " mm";
                            TextBox2.Text += "\nWind possibility for the day " + i + " = " + forecastInfo.WindInfo[i] + " m/s";
                            TextBox2.Text += "\nRain possibility for the day " + i + " = " + forecastInfo.RainInfo[i] + " mm";
                            TextBox2.Text += "\n------------------------------------------------------";
                        }
                    }

                    TextBox2.Text += "\nProbability of Thunderstorm among 3 days= " + forecastInfo.StormInfo + @" %";
                    TextBox2.Text += "\nProbability of Tornado among 3 days= " + forecastInfo.TornadoInfo + @" %";
                }
                Cache.Insert("WeatherZipCode", TextBox1.Text);
                Cache.Insert("WeatherResult", forecastInfo);
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