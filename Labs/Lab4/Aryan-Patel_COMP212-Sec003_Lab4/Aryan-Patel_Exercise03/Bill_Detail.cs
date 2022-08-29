using System.ComponentModel;

namespace Aryan_Patel_Exercise03
{
    public class Bill_Detail : INotifyPropertyChanged
    {
        private int quantity;
        public event PropertyChangedEventHandler PropertyChanged;

        public string Category { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                if (quantity != value)
                {
                    quantity = value;
                    OnPropertyChanged("Quantity");
                }
            }
        }

        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property)); //raise an event
            }
        }
    }
}
