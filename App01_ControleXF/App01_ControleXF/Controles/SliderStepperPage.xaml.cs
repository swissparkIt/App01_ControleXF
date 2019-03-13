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
	public partial class SliderStepperPage : ContentPage
	{
		public SliderStepperPage ()
		{
			InitializeComponent ();
		}

        private void sld1_Changed(object sender, ValueChangedEventArgs e)
        {
            SliderResult.Text = e.NewValue.ToString();
        }

        private void stp1_Chenged(object sender, ValueChangedEventArgs e)
        {
            StepperResult.Text = e.NewValue.ToString();
        }
    }
}