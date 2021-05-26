using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace busroutes
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
        }

        private void btnsttode_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new busroutes.destination());
        }

        private void btnbusno_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new busroutes.busnumber());
        }

        private void btnlive_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new busroutes.livestatus());
        }
    }
}
