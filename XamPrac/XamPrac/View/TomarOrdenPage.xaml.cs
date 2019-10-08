using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamPrac.ViewModel;

namespace XamPrac.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TomarOrdenPage : ContentPage
	{
		public TomarOrdenPage ()
		{
			InitializeComponent ();

		}

        private void TxtOcupantes_Unfocused(object sender, FocusEventArgs e)
        {
            lblConsumible.Text = (Convert.ToInt32(txtOcupantes.Text) * 10).ToString();
        }


    }
}