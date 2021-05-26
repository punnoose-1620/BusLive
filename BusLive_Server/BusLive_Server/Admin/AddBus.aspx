<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddBus.aspx.cs" Inherits="BusLive_Server.AddBus" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <title>Bus Route</title>
</head>
<body>
   <nav class="navbar navbar-inverse">
  <div class="container-fluid">
    <div class="navbar-header">
      <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#myNavbar">
        <span class="icon-bar"></span>
        <span class="icon-bar"></span>
        <span class="icon-bar"></span>                        
      </button>
      <a class="navbar-brand" href="#">BusLive Admin</a>
    </div>
    <div class="collapse navbar-collapse" id="myNavbar">
      <ul class="nav navbar-nav">
        <li class="active"><a href="Default.aspx">Home</a></li>
        <li><a href="AddBus.aspx">Add Bus</a></li>
      </ul>
    </div>
  </div>
</nav>
    <div class="container">
        <div class="row">
            <div class="col-lg-6 col-md-12">
                <form id="form1" runat="server">
                    <div class="form-group">
                        <label for="txtBusRegNumber">Bus Reg Number:</label>
                        <asp:TextBox ID="txtBusRegNumber"  runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="txtRouteNumber">Route Number:</label>
                        <asp:TextBox ID="txtRouteNumber" TextMode="Number" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="txtTowards">Towards:</label>
                        <asp:TextBox ID="txtTowards"  runat="server" CssClass="form-control"></asp:TextBox>
                    </div>

                    <div class="form-group">
                        <label for="txtDriverName">Driver Name:</label>
                        <asp:TextBox ID="txtDriverName" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="txtDriverContactNumber">Driver Contact Number:</label>
                        <asp:TextBox ID="txtDriverContactNumber" TextMode="Number" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="txtInchargeName">Incharge Name:</label>
                        <asp:TextBox ID="txtInchargeName" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="txtInchargeNumber">Incharge Name:</label>
                        <asp:TextBox ID="txtInchargeNumber" TextMode="Number" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="container">
                        <asp:Button ID="btnSubmit" runat="server" CssClass="btn btn-primary" OnClick="btnSubmit_Click" Text="Submit" />

                    </div>
                </form>
            </div>
        </div>
    </div>
</body>
</html>
