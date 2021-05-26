using Plugin.Geolocator;
using Plugin.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace geo
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();
            CrossGeolocator.Current.StartListeningAsync(10000, 100);
            CrossGeolocator.Current.AllowsBackgroundUpdates = true;
            CrossGeolocator.Current.PositionChanged += Current_PositionChanged;
        }

        private void Current_PositionChanged(object sender, Plugin.Geolocator.Abstractions.PositionEventArgs e)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                LongitudeLabel.Text = e.Position.Longitude.ToString();
                LatitudeLabel.Text = e.Position.Latitude.ToString();
            });
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            try
            {

                var locator = CrossGeolocator.Current;
                locator.DesiredAccuracy = 50;

                var position = await locator.GetPositionAsync(10000);
                LongitudeLabel.Text = position.Longitude.ToString();
                LatitudeLabel.Text = position.Latitude.ToString();
            }
            catch { }
        }

        private void Call_Clicked(object sender, EventArgs e)
        {
            var phoneDialer = CrossMessaging.Current.PhoneDialer;
            if (phoneDialer.CanMakePhoneCall)
                phoneDialer.MakePhoneCall("+914812436169");

        }
    }
}
