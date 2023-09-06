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
            //LoadPage1();
        }

        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item is string selectedItem)
            {
                // Perform navigation based on the selected item.
                switch (selectedItem)
                {
                    case "Первый пункт":
                        await Navigation.PushAsync(new Page1());
                        break;
                    case "Второй пункт":
                        await Navigation.PushAsync(new Page2());
                        break;
                    case "Третий пункт":
                        await Navigation.PushAsync(new Page3());
                        break;
                        // Add more cases for additional items as needed.
                }

                // Reset the selected item to null to allow tapping again.
                ((ListView)sender).SelectedItem = null;
            }
        }

        //private async void LoadPage1()
        //{
        //    await Navigation.PushAsync(new Page1());
        //}

        //private void Button_Click(object sender, EventArgs e)
        //{
        //    spw.IsVisible = !spw.IsVisible;
        //}
        //private async void Go_To_Page1(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new Page1());
        //}

        //private async void Go_To_Page2(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new Page2());
        //}

        //private async void Go_To_Page3(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new Page3());
        //}


        private void Btn1_Click(object sender, EventArgs e)
        {
            spw1.IsVisible = !spw1.IsVisible;
        }
    }
}

