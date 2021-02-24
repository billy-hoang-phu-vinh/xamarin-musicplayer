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
    public partial class CashMain : ContentPage
    {
        ObservableCollection<Item> list_items;
        ObservableCollection<ItemHistory> history;
        int num1, num2;
        int selected_price;
        string op;
        Item temp_item;
        public CashMain(ObservableCollection<Item> item_menu)
        {
            //create empty history 
            history = new ObservableCollection<ItemHistory>() { } ;//{}
            InitializeComponent();
            //selected_item.Text = "0";
            list_items = item_menu;
            mylist.ItemsSource = list_items;
            selected_price = 0;
        }
        void Number_Clicked(System.Object sender, System.EventArgs e)
        {
            DisplayAlert("Contanct", "test", "OK");
        }
        void mylist_ItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            
            //Label item_element = (Label)sender;
            type.Text= (e.SelectedItem as Item).name;
            selected_price = (e.SelectedItem as Item).price;
            temp_item = (e.SelectedItem as Item);
        }
        void Call_Clicked(System.Object sender, System.EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var call_contact = menuItem.CommandParameter as Contact;
            DisplayAlert("Calling ", call_contact.name, "OK");
        }

        void Delete_Clicked(System.Object sender, System.EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var delete_item = menuItem.CommandParameter as Item;
            list_items.Remove(delete_item);
        }

        /*calculator*/
        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            if (((Button)sender).Text == "+")
            {
                num1 = Convert.ToInt32(number.Text);

                op = "+";
                number.Text = "";
            }
            else if (((Button)sender).Text == "-")
            {
                num1 = Convert.ToInt32(number.Text);
                op = "-";
                number.Text = "";
            }
            else if (((Button)sender).Text == "*")
            {
                num1 = Convert.ToInt32(number.Text);
                op = "*";
                number.Text = "";
            }
            else if (((Button)sender).Text == "/")
            {
                num1 = Convert.ToInt32(number.Text);
                op = "/";
                number.Text = "";
            }
            else if (((Button)sender).Text == "=")
            {
                num2 = Convert.ToInt32(number.Text);
                if (op == "+")
                {
                    number.Text = (num1 + num2).ToString();
                }
            }
        }

        void Quantity(System.Object sender, System.EventArgs e)
        {
            Button digit = (Button)sender;
            //double num = Double.Parse(digit.Text);
            //display
            //number.Text = digit.Text;
            number.Text = number.Text + ((Button)sender).Text;
        }
        void Buy(System.Object sender, System.EventArgs e)
        {
            //update: there is an anotherway: save the index and insert to position
            //testing, not work
            Item newItem = temp_item;
            if (string.IsNullOrEmpty(number.Text) ||
                mylist.SelectedItem == null)
            {
                DisplayAlert("Error  ", "You have to select an Item and provide a new quantity", "OK");
            } else
            {
                int result = newItem.quantity - (Convert.ToInt32(number.Text));
                //* case *//
                if (result < 0)
                {
                    DisplayAlert("Error", "Item is out of stock, please update the quantity and try again", "Continue");
                    //type.Text = "Total";
                    number.Text = "";
                    //total.Text = "";

                }
                else
                {
                    //list_items.Insert(list_items.IndexOf(temp_item), newItem);
                    newItem.quantity = result; //update
                    list_items.Remove(temp_item);
                    //list_items.Remove(temp_item);
                    list_items.Add(newItem);
                    mylist.ItemsSource = list_items.Reverse();
                    // work
                    //mylist.ItemsSource = list_items;
                    //temp_item.quantity = 999;
                    //list_items.Add(temp_item);

                    //add to history
                    ItemHistory tempHistory = new ItemHistory(temp_item.name, temp_item.price, temp_item.quantity, DateTime.Now);
                    history.Add(tempHistory);


                    //reset
                    type.Text = "Total";
                    number.Text = "";
                    total.Text = "";
                    DisplayAlert("Success", "The quantity is updated", "Close");

                }
            }






            //(e.SelectedItem as Item).price -=   ;
        }
        public void Clear_Clicked(object sender, EventArgs e)
        {
            

            type.Text = "Total";
            number.Text = "";
            total.Text = "";

        }

        private void selectItem(object sender, EventArgs e)
        {
            DisplayAlert("1", "2", "3");
        }

        public void Total(object sender, EventArgs e)
        {
            num1 = (Convert.ToInt32(number.Text))* selected_price;

            total.Text = num1.ToString();
            
        }

        //button click -> manager page
        async void to_Manager(System.Object sender, System.EventArgs e)
        {
            

            await Navigation.PushModalAsync(new ManagerPage(list_items,history));
            ///
            ///

        }
    }
}