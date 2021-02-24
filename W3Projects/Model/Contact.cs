using System;
using System.ComponentModel;

namespace W3Projects
{
    public class Contact : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        //C# backing field 
        private string _name; //backing field. Temporary variable
        public string name
        {
            get { return _name; }
            set
            {
                if (_name == value) 
                    return;
                _name = value; //save to value
                if (PropertyChanged != null)
                {

                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(name))); //set real name = _name = value
                }
            }
        }

        private string _number;
        public string number
        {
            get { return _number; }
            set
            {
                if (_number == value)
                    return;
                _number = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(number)));
                }
            }
        }


        public string image { get; set; }


        public Contact() { }
        public Contact(string name, string num)
        {
            this.name = name;
            this.number = num;

        }

    }
}
