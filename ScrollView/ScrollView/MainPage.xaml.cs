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
		}

        public void OnClick(object sender, EventArgs e)
        {
            DisplayAlert("Seleted", ((ToolbarItem)sender).Name, "OK");
        }

    }
}
