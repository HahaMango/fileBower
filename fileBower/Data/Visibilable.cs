using System.ComponentModel;

namespace fileBower.Data
{
    public class Visibilable : INotifyPropertyChanged
    {
        private string vi = "Hidden";
        private string stackState = "True";
        private string color = "white";

        public string Vi
        {
            get
            {
                return vi;
            }
            set
            {
                vi = value;
                if (this.PropertyChanged != null)
                    this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Vi"));
            }
        }

        public string StackState
        {
            get
            {
                return stackState;
            }
            set
            {
                stackState = value;
                if (this.PropertyChanged != null)
                    this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs("StackState"));
            }
        }

        public string ItemColor
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
                if (this.PropertyChanged != null)
                    this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs("ItemColor"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
