//PROG 1224 - Lab 3
//Natalie Hyojung Yu
//Date: July 15, 2022

using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace EmployeeLibrary
{
    public sealed class Hourly : Employee, INotifyPropertyChanged
    {
        // Fields
        private decimal rate = 0.0M;
        private decimal hours = 0.0M;

        // Properties
        public decimal Rate
        {
            get => rate;
            // minimum wage in Ontario - $15.50 
            set => rate = (value >= 15.50m) ? value: 15.5m;
        }

        public decimal Hours
        {
            get => hours;
            // ontario maximum working - 48 hours/week
            set => hours = (value > 0m && value <= 48m) ? value : 0m;
        }

        // Constructors
        public Hourly(string sinNum) : base(sinNum) { }
        public Hourly(string sinNum, string first, string last) : base(sinNum, first, last) { }
        public Hourly(string sinNum, string first, string last, decimal rate, decimal hours) : base(sinNum, first, last)
        {
            Rate = rate;
            Hours = hours;
        }

        public override string ToString()
        {
            return "Hourly: " + base.ToString();
        }

        public override decimal Calculate()
        {
            return (decimal) Hours * Rate * 2;
        }

        //IDeduction interface
        //Hourly pays 10.00 per pay period for unio fees
        private decimal fee = 10M;

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public decimal UnionFee
        {
            get => fee;
            set => fee = (value > 0M) ? value : 10M;
        }

        public new decimal UnionDues() => UnionFee;
    }
}
