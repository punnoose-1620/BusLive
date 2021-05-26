using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BusLive_Server
{
    public partial class AddBus : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            DbBus db = new DbBus();

            db.BusData.Add(new BusData() { BusRegNumber = txtBusRegNumber.Text, DriverContactNumber = txtDriverContactNumber.Text, DriverName = txtDriverName.Text, InchargeName = txtInchargeName.Text, InchargeNumber = txtInchargeNumber.Text, RouteNumber = Convert.ToInt16(txtRouteNumber.Text), Towards = txtTowards.Text,lat=0,lon=0,speed=0,timestamp=DateTime.Now });
            db.SaveChangesAsync();    
        }
    }
}