<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DemographicsTryIt.aspx.cs" Inherits="Homework5.DemographicsTryIt" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button2" runat="server" Font-Bold="True" OnClick="Button2_Click" Text="Home" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="#CC0000" Text="America Demographic Service"></asp:Label>
    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label3" runat="server" Font-Bold="True" Text="User: "></asp:Label>
    
    </div>
    <p>
&nbsp;&nbsp;
        Service Description: This service provides all the demographics detaisl for the place. The input is zip code and output is bunch of demographic information of the place.</p>
        <p>
            Method: getDemographics(string zipCode) and the output is string which is demographic information.</p>
        <p>
            Url: <a href="http://10.1.12.43:8001/demographic/Service1.svc/getDemographics/{zipcode">http://10.1.12.43:8001/demographic/Service1.svc/getDemographics/{zipcode</a>} </p>
        <p>
            <b>Cache Use:</b> First time the textfield is empty. When you add zip code i.e. 85281 then on Enter button click, the web service gets called. And the zipcode and the result get saved in cache. During, second time invocation of this page, the textfield shown with previous save result i.e. 85281. But, the result area still empty. When the Enter button is clicked without changing the zip code, the saved result in cache is shown and web service does not get called. If you changed the zip code from 85281 to 10007, then the web service is called and the zipcode and the result get saved in cache.</p>
        <p>
        <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="Enter Zip Code"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Use only America zipcodes</p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="Button1" RunAt="server" Font-Bold="True" Text="Enter" Width="86px" OnClick="Button1_Click" />
    </p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" TextMode="MultiLine" runat="server" Height="348px" OnTextChanged="TextBox2_TextChanged" Width="470px"></asp:TextBox>
    </p>
    </form>
    </body>
</html>

