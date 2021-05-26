using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BusLive_Server
{
    public partial class TrackCheck : System.Web.UI.Page
    {
        protected double _lat = 9.510334;
        protected double _lon = 76.550900;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                var RouteNumber = Convert.ToInt16(Request["RouteNumber"].ToString());
                using (var db = new DbBus())
                {
                    BusData bus = new BusData();
                    bus = db.BusData.FirstOrDefault(a => a.RouteNumber == RouteNumber);

                    if (bus != null)
                    {
                        _lat = bus.lat;
                        _lon = bus.lon;
                    }
                }
            }
            catch
            {
                //    Response.Redirect("Default.aspx");
            }
            ScriptManager.RegisterStartupScript(this, this.GetType(), "", "initLatLon('"+_lat+"','"+_lon+"');", true);

        }
    }
}