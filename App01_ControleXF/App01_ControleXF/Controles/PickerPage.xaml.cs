using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App01_ControleXF.Controles
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PickerPage : ContentPage
	{
		public PickerPage ()
		{
			InitializeComponent ();

            //pkEmpresas.SelectedIndex = 2;
		}

        private void PickerChanged(object sender, EventArgs args)
        {
            Picker obj = (Picker)sender;

            lblPicked.Text = obj.SelectedItem.ToString() + " - " + obj.SelectedIndex;
        }

    }
}