using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace W3Projects
{
    public partial class ManagerPage : ContentPage
    {
        ObservableCollection<Item> item_menu;
        ObservableCollection<ItemHistory> history;
        public ManagerPage(ObservableCollection<Item> item_menu, ObservableCollection<ItemHistory> history)
        {
            this.item_menu = item_menu;
            this.history = history;
            InitializeComponent();
        }

        
        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {

            //await Navigation.PushAsync(new nextPage(Item));

            await Navigation.PushModalAsync(new Restock(item_menu));
            ///
            ///

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            
            //show history page
            Navigation.PushModalAsync(new History(history));

        }
    }
}
