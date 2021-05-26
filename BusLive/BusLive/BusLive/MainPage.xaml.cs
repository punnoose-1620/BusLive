using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Plugin.Geolocator;

namespace BusLive
{

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            getLocationAsync();
        }

        private async Task getLocationAsync()
        {
            try
            {
                var locator = CrossGeolocator.Current;
                locator.DesiredAccuracy = 50;

                var position = await locator.GetPositionAsync(TimeSpan.FromSeconds(10));
                if (position == null)
                    return;

                lblLoc.Text = "Timestamp: " + position.Timestamp + " & lat: " + position.Latitude + " & lon:" + position.Longitude + " & speed" + position.Speed;
              
            }
            catch (Exception ex)
            {
            }
        }
    }
}
