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
    public partial class History : ContentPage
    {
        private ObservableCollection<ItemHistory> history_list;
        private ItemHistory temp_item;


        public History(ObservableCollection<ItemHistory> history)
        {
            InitializeComponent();

            history_list = history;
            mylist.ItemsSource = history_list;
        }
        void mylist_ItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            temp_item = e.SelectedItem as ItemHistory;
            Navigation.PushModalAsync(new DetailHistory(temp_item));

        }
    }
}