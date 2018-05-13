using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ScrollView
{
	public partial class MainPage : TabbedPage//ContentPage
    {
		public MainPage()
		{
			InitializeComponent();

            BarBackgroundColor = Color.FromHex("#1FBED6");
            BarTextColor = Color.FromHex("#000000");

            ItemsSource = MonkeyDataModel.All;
		}

        public void OnClick(object sender, EventArgs e)
        {
            DisplayAlert("Seleted", ((ToolbarItem)sender).Name, "OK");
        }

    }
}
