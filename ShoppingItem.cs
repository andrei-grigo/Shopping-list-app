using Shopping_list_app;
using System.ComponentModel;

namespace Shopping_list_app
{
    public class ShoppingItem : INotifyPropertyChanged
    {
        private bool _select;
        private string _name;
        private int _quantity;
        private bool _isBought;

        public bool Select
        {
            get => _select;
            set
            {
                if (_select != value)
                {
                    _select = value;
                    OnPropertyChanged(nameof(Select));
                }
            }
        }

        public string Name
        {
            get => _name;
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }

        public int Quantity
        {
            get => _quantity;
            set
            {
                if (_quantity != value)
                {
                    _quantity = value;
                    OnPropertyChanged(nameof(Quantity));
                }
            }
        }

        public bool IsBought
        {
            get => _isBought;
            set
            {
                if (_isBought != value)
                {
                    _isBought = value;
                    OnPropertyChanged(nameof(IsBought));
                }
            }
        }

        public ShoppingItem(string name, int quantity)
        {
            Name = name;
            Quantity = quantity;
            IsBought = false;
            Select = false;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}