using App01_ControleXF.Modelos;
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
	public partial class ListViewPage : ContentPage
	{
		public ListViewPage ()
		{
			InitializeComponent ();

            var lst = new List<Pessoa>();
            lst.Add(new Pessoa { Nome = "Vardy", Idade = 30 });
            lst.Add(new Pessoa { Nome = "Lukaku", Idade = 29 });

            lvView2.ItemsSource = lst;
        }
	}
}