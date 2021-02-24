using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace W3Projects
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Restock : ContentPage
    {
        
        ObservableCollection<Contact> contacts;
        ObservableCollection<Item> item_menu;
        public Restock(ObservableCollection<Item> item_menu)
        {
            InitializeComponent();
            this.item_menu = item_menu;

                
            mylist.ItemsSource = item_menu;

        }

        void mylist_ItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            Contact c = e.SelectedItem as Contact;
            Item i = e.SelectedItem as Item;
            updatedQuantity.Text = i.quantity.ToString();

        }

        void call_Clicked(System.Object sender, System.EventArgs e)
        {
            var menu = sender as MenuItem;
            DisplayAlert("Calling  ", (menu.CommandParameter as Contact).name, "OK");
        }

        void delete_Clicked(System.Object sender, System.EventArgs e)
        {
            var todelete = ((sender as MenuItem).CommandParameter as Contact);
            contacts.Remove(todelete);
        }

        void Update_Clicked(System.Object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(updatedQuantity.Text) ||
                
                mylist.SelectedItem == null)
            {
                DisplayAlert("Error  ", "You have to select an Item and provide a new quantity", "OK");
            }
            else
            {
                (mylist.SelectedItem as Item).quantity = Convert.ToInt32(updatedQuantity.Text);

            }

        }
    }
}