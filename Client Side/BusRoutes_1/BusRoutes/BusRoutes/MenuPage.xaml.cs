using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BusRoutes
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuPage : ContentPage
	{
		public MenuPage ()
		{
			InitializeComponent ();
		}

        private void routes_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new BusList());
        }

        private void status_Clicked(Object sender, System.EventArgs e)
        {
            Browser.Source = "http://saintgitsbuslive.thopps.com/default.aspx";
        }
    }
}