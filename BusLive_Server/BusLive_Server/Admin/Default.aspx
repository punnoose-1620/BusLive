<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BusLive_Server.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataSourceID="SqlDataSource1" Height="386px" Width="921px">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:BoundField DataField="RouteNumber" HeaderText="RouteNumber" SortExpression="RouteNumber" />
                    <asp:BoundField DataField="BusRegNumber" HeaderText="BusRegNumber" SortExpression="BusRegNumber" />
                    <asp:BoundField DataField="Towards" HeaderText="Towards" SortExpression="Towards" />
                    <asp:BoundField DataField="DriverName" HeaderText="DriverName" SortExpression="DriverName" />
                    <asp:BoundField DataField="DriverContactNumber" HeaderText="DriverContactNumber" SortExpression="DriverContactNumber" />
                    <asp:BoundField DataField="InchargeName" HeaderText="InchargeName" SortExpression="InchargeName" />
                    <asp:BoundField DataField="InchargeNumber" HeaderText="InchargeNumber" SortExpression="InchargeNumber" />
                </Columns>
                <FooterStyle BackColor="White" ForeColor="#000066" />
                <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                <RowStyle ForeColor="#000066" />
                <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#007DBB" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#00547E" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DbBus %>" SelectCommand="SELECT [RouteNumber], [BusRegNumber], [Towards], [DriverName], [DriverContactNumber], [InchargeName], [InchargeNumber] FROM [BusDatas]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
