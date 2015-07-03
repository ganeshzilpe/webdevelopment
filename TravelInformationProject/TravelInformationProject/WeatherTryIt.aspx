<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WeatherTryIt.aspx.cs" Inherits="Homework5.WeatherTryIt" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 862px">
    <form id="form1" runat="server">
    <div>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button2" runat="server" Font-Bold="True" OnClick="Button2_Click" Text="Home" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" BorderStyle="Double" Font-Bold="True" Font-Size="X-Large" ForeColor="Black" TabIndex="4" Text="America Weather Forecasting Service"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label5" runat="server" Font-Bold="True" Text="User:"></asp:Label>
        <br/>
        <br/>
        <asp:Image ID="Image1" runat="server" Height="110px" ImageUrl="~/weather_forecast.jpg" Width="782px" />
    
    </div>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="#CC0000" Text="Service Description: Weather Forecasting Service is used for getting weather information of the place. Input &lt;br/&gt;for the service is Zip code of a place. We developed the service such that it will display the weather &lt;br/&gt;information for next three days."></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="Large" Text="URL: http://10.1.12.43:8001/WeatherForecasting/ &lt;br/&gt; Method Name:  getWeatherForecast() with parameter as Zip code"></asp:Label>
        <br />
        <br />
            <b>Cache Use:</b> First time the textfield is empty. When you add zip code i.e. 85281 then on Enter button click, the web service gets called. And the zipcode and the result get saved in cache. During, second time invocation of this page, the textfield shown with previous save result i.e. 85281. But, the result area still empty. When the Enter button is clicked without changing the zip code, the saved result in cache is shown and web service does not get called. If you changed the zip code from 85281 to 10007, then the web service is called and the zipcode and the result get saved in cache.<br />
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label4" runat="server" Text="Enter Zip Code"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Use only American Zip codes (e.g. 85281 for Tempe)&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:Button ID="Button1" runat="server" Font-Bold="True" OnClick="Button1_Click" Text="Enter" />
        </p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" TextMode="MultiLine" runat="server" Height="380px" OnTextChanged="TextBox2_TextChanged" Width="435px"></asp:TextBox>
    </form>
</body>
</html>
