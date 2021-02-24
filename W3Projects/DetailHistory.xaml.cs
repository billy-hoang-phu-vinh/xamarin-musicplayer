using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace W3Projects
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailHistory : ContentPage
    {
        ItemHistory singleItem;
        String Name="default";
        public DetailHistory(ItemHistory item)
        {
           
            InitializeComponent();
            itemName.Text = item.name;
            itemQuantity.Text = item.quantity.ToString();
            itemPurchased.Text = item.PurchasedDate.ToString();
            int totalAm = item.quantity * item.price;
            totalAmount.Text = totalAm.ToString();

        }
    }
}