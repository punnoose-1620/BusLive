using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace BusLive_Server
{
    public partial class TrackPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnRefresh_Click(object sender, EventArgs e)
        {
            var iframe = locIframe as HtmlControl;

            try
            {
                var RouteNumber = Convert.ToInt16(Request["RouteNumber"].ToString());
                using (var db = new DbBus())
                {
                    BusData bus = new BusData();
                    bus = db.BusData.FirstOrDefault(a => a.RouteNumber == RouteNumber);

                    if (bus != null)
                        iframe.Attributes.Add("src", "https://maps.google.com/?q=loc:" + bus.lat + "," + bus.lon);
                }
            }
            catch
            {
                //    Response.Redirect("Default.aspx");
            }

        }
    }
}