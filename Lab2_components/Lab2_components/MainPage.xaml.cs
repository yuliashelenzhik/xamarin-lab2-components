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

        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item is string selectedItem)
            {
                Page nextPage = null;

                switch (selectedItem)
                {
                    case "Первый пункт":
                        nextPage = new Page1("Data for Page1");
                        break;
                    case "Второй пункт":
                        nextPage = new Page2("переход из главного меню");
                        break;
                    case "Третий пункт":
                        nextPage = new Page3("переход из главного меню");
                        break;
                        // Add more cases for additional items as needed.
                }

                if (nextPage != null)
                {
                    await Navigation.PushAsync(nextPage);
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


        private void Btn1_Click(object sender, EventArgs e)
        {
            spw1.IsVisible = !spw1.IsVisible;
        }
    }
}

