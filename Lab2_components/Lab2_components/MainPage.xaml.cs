using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lab2_components
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            spw.IsVisible = !spw.IsVisible;
        }


        private void Btn1_Click(object sender, EventArgs e)
        {
            spw1.IsVisible = !spw1.IsVisible;
        }
    }
}

