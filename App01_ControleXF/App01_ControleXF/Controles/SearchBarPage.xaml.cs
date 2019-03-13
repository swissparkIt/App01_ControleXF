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
	public partial class SearchBarPage : ContentPage
	{
        private List<string> empresas;

        public SearchBarPage ()
		{
			InitializeComponent ();

            empresas = new List<string>();
            empresas.Add("Apple");
            empresas.Add("Habbibs");
            empresas.Add("Uol");
            empresas.Add("Fiat");
            empresas.Add("Shopping Campinas");
            empresas.Add("Itaú");
            empresas.Add("Nubank");

            PreencheLista(empresas);
        }

        private void Pesquisar_Change(object sender, TextChangedEventArgs e)
        {
            var filtradas = empresas.Where(x => x.Contains(e.NewTextValue)).ToList();
            PreencheLista(filtradas);
        }

        private void sbar_Click(object sender, EventArgs e)
        {
            var filtradas = empresas.Where(x => x.Contains(((SearchBar)sender).Text)).ToList();
            PreencheLista(filtradas);
        }

        private void PreencheLista(List<string> lista)
        {
            ListResult.Children.Clear();
            foreach (var r in lista)
            {
                ListResult.Children.Add(new Label { Text = r });
            }
        }
    }
}