﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App01_ControleXF.Controles
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SwitchPage : ContentPage
    {

        public SwitchPage()
        {
            InitializeComponent();
        }

        private void st1_Click(object sender, ToggledEventArgs e)
        {
            lblResultado.Text = DateTime.Now.ToString("HH:mm:ss") + " - " + e.Value;
        }

    }
}