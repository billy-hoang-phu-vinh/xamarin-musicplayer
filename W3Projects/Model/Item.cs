using System;
using System.ComponentModel;

namespace W3Projects
{
    public class Item : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private int _quantity; //backing field. _quantity

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

        public Item() { }
        public Item(string name, int price, int quantity)
        {
            this.name = name;
            this.quantity = quantity;
            this.price = price;
        }
        
    }
}
