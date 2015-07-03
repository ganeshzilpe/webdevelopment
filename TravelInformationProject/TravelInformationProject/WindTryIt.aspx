<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WindTryIt.aspx.cs" Inherits="Homework5.WindTryIt" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            &nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button2" runat="server" Font-Bold="True" OnClick="Button2_Click" Text="Home" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="#CC0000" Text="America Wind Information Service"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label7" runat="server" Font-Bold="True" Text="User: "></asp:Label>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Image ID="Image1" runat="server" Height="118px" ImageUrl="~/wind.jpg" Width="547px" />
            <br />
&nbsp;&nbsp;
            <br />
&nbsp;&nbsp;&nbsp; Service Description: Wind Service provides the wind information about the wind capacity, breeze<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; and type of breeze. This service only take Zip code of United States.<br />
            <br />
            Method: getWindInformation(string zipcode)<br />
            output: string wind_information includes speed value, wind name, direction value and direction name<br />
            <br />
            Url: http://10.1.12.43:8001/windservice<a href="http://localhost:1559/Service1.svc/windInfo/{zip">/Service1.svc/windInfo/{zip_code}</a>&nbsp; &nbsp;&nbsp;&nbsp;
            <br />
            <p>
            <b>Cache Use:</b> First time the textfield is empty. When you add zip code i.e. 85281 then on Enter button click, the web service gets called. And the zipcode and the result get saved in cache. During, second time invocation of this page, the textfield shown with previous save result i.e. 85281. But, the result area still empty. When the Enter button is clicked without changing the zip code, the saved result in cache is shown and web service does not get called. If you changed the zip code from 85281 to 10007, then the web service is called and the zipcode and the result get saved in cache.</p>
        <p>
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label1" runat="server" Text="Enter Zip Code" Font-Bold="True"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:TextBox ID="zipCodeTextbox" runat="server" Width="121px"></asp:TextBox>
            &nbsp;&nbsp; (Use only America Zip Codes)<br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Invoke" Width="94px" Font-Bold="True" Height="25px" />
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="windInfoTextbox" TextMode="MultiLine" runat="server" Height="218px" Width="352px"></asp:TextBox>
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>