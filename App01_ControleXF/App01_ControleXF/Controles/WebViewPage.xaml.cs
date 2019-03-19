using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App01_ControleXF.Controles
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class WebViewPage : ContentPage
	{

		public WebViewPage ()
		{
			InitializeComponent ();
		}

        private void btnIr_Click(object sender, EventArgs e)
        {
            Navegador.Source = txtEndereco.Text;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if (Navegador.CanGoBack)
            {
                Navegador.GoBack();
            }
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (Navegador.CanGoForward)
            {
                Navegador.GoForward();
            }
        }

        private void Navigating_Event(object sender, WebNavigatingEventArgs e)
        {
            lblStatus.Text = "Carregando...";
        }

        private void Navigated_Event(object sender, WebNavigatedEventArgs e)
        {
            lblStatus.Text = "Pronto.";
        }

    }
}