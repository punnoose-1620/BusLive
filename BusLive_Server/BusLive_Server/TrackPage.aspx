<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TrackPage.aspx.cs" Inherits="BusLive_Server.TrackPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnRefresh" runat="server" Text="Refresh" OnClick="btnRefresh_Click" />
            <iframe runat="server" id="locIframe" name="locIframe" frameborder="0" style="border:none; overflow:hidden; width:900px; height:500px;" />
        </div>
    </form>
</body>
</html>
