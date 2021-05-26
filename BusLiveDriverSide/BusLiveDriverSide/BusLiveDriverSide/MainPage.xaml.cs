using Plugin.Geolocator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BusLiveDriverSide
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}
        private async void Button_OnClicked(object sender, EventArgs e)
        {


            var locator = CrossGeolocator.Current;
            locator.DesiredAccuracy = 50;

            var position = await locator.GetPositionAsync(10000);
            LongitudeLabel.Text = position.Longitude.ToString();
            LatitudeLabel.Text = position.Latitude.ToString();
        }
        private void BrkDwn_Clicked(object sender, System.EventArgs e)
        {

        }
        private void Delay_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new DelayRsn());
        }
	}
}
