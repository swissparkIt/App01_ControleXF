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
	public partial class ProgressBarPage : ContentPage
	{
		public ProgressBarPage ()
		{
			InitializeComponent ();
		}

        private void btnModificar_Click(object sender, EventArgs args)
        {
            pb1.Progress = 1;
            pb2.ProgressTo(1, 5000, Easing.Linear);
            pb3.ProgressTo(1, 5000, Easing.SpringIn);
        }


    }
}