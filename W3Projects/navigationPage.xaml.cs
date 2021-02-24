using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace W3Projects
{
    public partial class navigationPage : ContentPage
    {
        ObservableCollection<Item> item_menu; //empty list
        public navigationPage()
        {
            InitializeComponent();
        }

       async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            item_menu = new ObservableCollection<Item>
            {

                new Item(){name = "Hat", price = 12 ,quantity = 120},
                new Item(){name = "Toy", price = 4 ,quantity = 200},
                new Item(){name = "Jacket", price = 40 ,quantity = 140},
                new Item(){name = "Belt", price = 6 ,quantity = 80},

            };
            //await Navigation.PushAsync(new nextPage(Item));

            await Navigation.PushModalAsync(new CashMain(item_menu));
            ///
            ///

        }
    }
}
