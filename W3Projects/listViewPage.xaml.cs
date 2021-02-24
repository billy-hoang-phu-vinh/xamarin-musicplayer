using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace W3Projects
{
    public partial class listViewPage : ContentPage
    {
        ObservableCollection<Contact> contacts;
        public listViewPage()
        {
            InitializeComponent();
            //a list that its element could be removed later
            contacts = new ObservableCollection<Contact>
            {
                new Contact(){name = "Stella", number="1234" , image="https://images.freeimages.com/images/small-previews/5da/coloured-paper-1421280.jpg"},
                new Contact(){name = "Nilan", number="33333", image="https://images.freeimages.com/images/small-previews/0cf/tulips-1-1377350.jpg"},
                new Contact(){name = "Irfan", number="4444" , image="https://images.freeimages.com/images/small-previews/48d/marguerite-1372118.jpg"}
            };
            mylist.ItemsSource = contacts;

        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
           
        }

        void Call_Clicked(System.Object sender, System.EventArgs e)
        {
            var menuItem = sender as MenuItem; //cast as menuitem
            var call_contact = menuItem.CommandParameter as Contact; //CommandParameter=property -> access to property and SAVE as contact structure
            DisplayAlert("Calling ", call_contact.name, "OK");
        }

        void Delete_Clicked(System.Object sender, System.EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var delete_contact = menuItem.CommandParameter as Contact;
            contacts.Remove(delete_contact);//search and remove
        }

        void mylist_ItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            DisplayAlert("Contanct", (e.SelectedItem as Contact).name, "OK");
        }
    }
}
