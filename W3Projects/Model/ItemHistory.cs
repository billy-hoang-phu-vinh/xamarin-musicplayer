using System;
using System.ComponentModel;

namespace W3Projects
{
    public class ItemHistory : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private int _quantity; //backing field. _quantity
        public DateTime PurchasedDate { get; }
        public string name { get; set; }
        public int quantity {
            get { return _quantity; }
            set
            {
                if (_quantity == value)
                    return;
                _quantity = value; //save to value
                if (PropertyChanged != null)
                {

                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(quantity))); //set real name = _name = value
                }
            }
        }
        public int price { get; set; }

        public ItemHistory() { }
        public ItemHistory(string name, int price, int quantity, DateTime PurchasedDate)
        {
            this.name = name;
            this.quantity = quantity;
            this.price = price;
            this.PurchasedDate = PurchasedDate;
        }

    }
}
