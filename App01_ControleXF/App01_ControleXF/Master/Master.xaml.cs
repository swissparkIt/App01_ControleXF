using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App01_ControleXF.Controles;

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
            Detail = new ActivityIndicatorPage();
            IsPresented = false;
        }

        private void btnProgressBar_Click(object sender, EventArgs args)
        {
            Detail = new App01_ControleXF.Controles.ProgressBarPage();
            IsPresented = false;
        }

        private void btnBoxViewPage_Click(object sender, EventArgs args)
        {
            Detail = new App01_ControleXF.Controles.BoxViewPage();
            IsPresented = false;
        }

        private void btnLabelPage_Click(object sender, EventArgs args)
        {
            Detail = new App01_ControleXF.Controles.LabelPage();
            IsPresented = false;
        }

        private void btnButtonPage_Click(object sender, EventArgs args)
        {
            Detail = new ButtonPage();
            IsPresented = false;
        }

        private void btnEntryEditorPage_Click(object sender, EventArgs args)
        {
            Detail = new EntryEditorPage();
            IsPresented = false;
        }

        private void btnDatePickerPage_Click(object sender, EventArgs args)
        {
            Detail = new DatePickerPage();
            IsPresented = false;
        }

        private void btnTimePickerPage_Click(object sender, EventArgs args)
        {
            Detail = new TimePickerPage();
            IsPresented = false;
        }

        private void btnPickerPage_Click(object sender, EventArgs e)
        {
            Detail = new PickerPage();
            IsPresented = false;
        }

        private void btnSearchBarPage_Click(object sender, EventArgs e)
        {
            Detail = new SearchBarPage();
            IsPresented = false;
        }

        private void SliderStepperPage_Click(object sender, EventArgs e)
        {
            Detail = new SliderStepperPage();
            IsPresented = false;
        }

        private void btnSwitchPage_Click(object sender, EventArgs e)
        {
            Detail = new SwitchPage();
            IsPresented = false;
        }
    }
}