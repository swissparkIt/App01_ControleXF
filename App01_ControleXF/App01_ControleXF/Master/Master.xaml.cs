using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App01_ControleXF.Master
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Master : MasterDetailPage
	{
		public Master ()
		{
			InitializeComponent ();
		}

        private void btnActivityIndicator_Click(object sender, EventArgs args)
        {
            Detail = new App01_ControleXF.Controles.ActivityIndicatorPage();
            IsPresented = false;
        }

        private void btnProgressBar_Click(object sender, EventArgs args)
        {
            Detail = new App01_ControleXF.Controles.ProgressBarPage();
            IsPresented = false;
        }
        

    }
}