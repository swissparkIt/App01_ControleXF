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
            Detail = new NavigationPage(new ActivityIndicatorPage());
            IsPresented = false;
        }

        private void btnProgressBar_Click(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new App01_ControleXF.Controles.ProgressBarPage());
            IsPresented = false;
        }

        private void btnBoxViewPage_Click(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new App01_ControleXF.Controles.BoxViewPage());
            IsPresented = false;
        }

        private void btnLabelPage_Click(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new App01_ControleXF.Controles.LabelPage());
            IsPresented = false;
        }

        private void btnButtonPage_Click(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new ButtonPage());
            IsPresented = false;
        }

        private void btnEntryEditorPage_Click(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new EntryEditorPage());
            IsPresented = false;
        }

        private void btnDatePickerPage_Click(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new DatePickerPage());
            IsPresented = false;
        }

        private void btnTimePickerPage_Click(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new TimePickerPage());
            IsPresented = false;
        }

        private void btnPickerPage_Click(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new PickerPage());
            IsPresented = false;
        }

        private void btnSearchBarPage_Click(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new SearchBarPage());
            IsPresented = false;
        }

        private void SliderStepperPage_Click(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new SliderStepperPage());
            IsPresented = false;
        }

        private void btnSwitchPage_Click(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new SwitchPage());
            IsPresented = false;
        }

        private void btnImagePage_Click(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new ImagePage());
            IsPresented = false;
        }

        private void btnListViewPage_Click(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new ListViewPage());
            IsPresented = false;
        }

        private void btnTableViewPage_Click(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new TableViewPage());
            IsPresented = false;
        }

        private void btnWebViewPage_Click(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new WebViewPage());
            IsPresented = false;
        }

    }
}