using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BusRoutes
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BusList : ContentPage
	{
		public BusList ()
		{
			InitializeComponent ();
		}

        SqlClientFactory S = SqlClientFactory.Instance;
        DbConnection cmd = S.CreateConnection();
        SqlConnection con = new SqlConnection();
        con.ConnectionString = @"Data Source=. ;AttachDbFilename=|localhost.3306|id3570917_buslivesg.mdf;Integrated Security=True;User Instance=True";
        SqlCommand c = new SqlCommand();
        c.Connection = con;
        c.CommandType = CommandType.Text;
        
        
        private void Bus1_Clicked(object sender, EventArgs e)
        {
            Browser.Source = "https://buslivesg.000webhostapp.com/01%20-%20Puramattom.html";
        }

        private void Bus2_Clicked(object sender, EventArgs e)
        {
            Browser.Source = "https://buslivesg.000webhostapp.com/02%20-%20Chengannur.html";
        }

        private void Bus3_Clicked(object sender, EventArgs e)
        {
            Browser.Source = "https://buslivesg.000webhostapp.com/03%20-%20Athirampuzha.html";
        }

        private void Bus4_Clicked(object sender, EventArgs e)
        {
            Browser.Source = "https://buslivesg.000webhostapp.com/04%20-%20Thiruvalla.html";
        }

        private void Bus5_Clicked(object sender, EventArgs e)
        {
            Browser.Source = "https://buslivesg.000webhostapp.com/05%20-%20Changanacherry.html";
        }

        private void Bus6_Clicked(object sender, EventArgs e)
        {
            Browser.Source = "https://buslivesg.000webhostapp.com/06%20-%20Edathua.html";
        }

        private void Bus7_Clicked(object sender, EventArgs e)
        {
            Browser.Source = "https://buslivesg.000webhostapp.com/07%20-%20Gandhinagar.html";
        }

        private void Bus8_Clicked(object sender, EventArgs e)
        {
            Browser.Source = "https://buslivesg.000webhostapp.com/08%20-%20Kollad.html";
        }

        private void Bus9_Clicked(object sender, EventArgs e)
        {
            Browser.Source = "https://buslivesg.000webhostapp.com/09%20-%20Puthupally.html";
        }

        private void Bus10_Clicked(object sender, EventArgs e)
        {
            Browser.Source = "https://buslivesg.000webhostapp.com/10%20-%20Pala.html";
        }

        private void Bus11_Clicked(object sender, EventArgs e)
        {
            Browser.Source = "https://buslivesg.000webhostapp.com/11%20-%20Mavelikkara.html";
        }

        private void Bus12_Clicked(object sender, EventArgs e)
        {
            Browser.Source = "https://buslivesg.000webhostapp.com/12%20-%20Kalathilpady.html";
        }

        private void Bus13_Clicked(object sender, EventArgs e)
        {
            Browser.Source = "https://buslivesg.000webhostapp.com/13%20-%20Pampady.html";
        }

        private void Bus14_Clicked(object sender, EventArgs e)
        {
            Browser.Source = "https://buslivesg.000webhostapp.com/14%20-%20Kooroppada.html";
        }

        private void Bus15_Clicked(object sender, EventArgs e)
        {
            Browser.Source = "https://buslivesg.000webhostapp.com/15%20-%20Thottabhagam.html";
        }

        private void Bus16_Clicked(object sender, EventArgs e)
        {
            Browser.Source = "https://buslivesg.000webhostapp.com/16%20-%20Mallapally.html";
        }

        private void Bus17_Clicked(object sender, EventArgs e)
        {
            Browser.Source = "https://buslivesg.000webhostapp.com/17%20-%20Alappuzha.html";
        }

        private void Bus18_Clicked(object sender, EventArgs e)
        {
            Browser.Source = "https://buslivesg.000webhostapp.com/18%20-%20Kumarakom.html";
        }

        private void Bus19_Clicked(object sender, EventArgs e)
        {
            Browser.Source = "https://buslivesg.000webhostapp.com/19%20-%20Pala.html";
        }
    }
}