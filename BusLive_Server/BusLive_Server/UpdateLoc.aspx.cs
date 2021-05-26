using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BusLive_Server
{
    public partial class UpdateLoc : System.Web.UI.Page
    {
        int routeNumber;
        double lat, lon, speed;

        DbBus db = new DbBus();

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                routeNumber = Convert.ToInt16(Request["RouteNumber"].ToString());
                lat = Convert.ToDouble(Request["Lat"].ToString());
                lon = Convert.ToDouble(Request["Lon"].ToString());
                speed = Convert.ToDouble(Request["Speed"].ToString());

                BusData b = new BusData();
                b = db.BusData.FirstOrDefault(i => i.RouteNumber == routeNumber);
                if (b != null)
                {
                    b.lat = lat;
                    b.lon = lon;
                    b.speed = speed;
                    b.timestamp = DateTime.Now;
                    db.Entry(b).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch
            {

            }
        }
    }
}