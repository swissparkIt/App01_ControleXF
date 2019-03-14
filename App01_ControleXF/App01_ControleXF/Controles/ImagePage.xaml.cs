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
    public partial class ImagePage : ContentPage
    {
        public ImagePage()
        {
            InitializeComponent();

            Image img = new Image();

            if (Device.RuntimePlatform != Device.UWP)
            {
                img.Source = ImageSource.FromFile("usb.jpg");
            }
            else
            {
                img.Source = ImageSource.FromFile("Imagem/usb.jpg");
            }

            Container.Children.Add(img);
        }

    }
}