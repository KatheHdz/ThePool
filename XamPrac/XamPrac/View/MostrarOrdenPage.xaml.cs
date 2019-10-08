using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamPrac.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MostrarOrdenPage : ContentPage
	{
		public MostrarOrdenPage ()
		{
			InitializeComponent ();
		}

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            
           
        }

        private void TxtOcupantes_Unfocused(object sender, FocusEventArgs e)
        {
            LblConsumible.Text = (Convert.ToInt32(TxtOcupantes.Text) * 10).ToString();
        }
    }
}