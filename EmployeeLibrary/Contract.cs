//PROG 1224 - Lab 3
//Natalie Hyojung Yu
//Date: July 15, 2022

namespace EmployeeLibrary
{
    public class Contract : Employee
    {
        private decimal amountPerWeek;
        private bool onContract;

        public decimal AmountPerWeek
        {
            get => amountPerWeek;
            set => amountPerWeek = (value >1000) ? value : 1000;   //minimum contract amount per week is $1000 
        }

        public bool OnContract
        {
            get => onContract;
            set => onContract = value;
        }


        public Contract(string sinNum) : base(sinNum) { }
        public Contract(string sinNum, string first, string last) : base(sinNum, first, last) { }
        public Contract(string sinNum, string first, string last, decimal amount) : base(sinNum, first, last)
        {
            AmountPerWeek = amount;
            OnContract = true;
        }

        public override decimal Calculate()
        {
            return AmountPerWeek + 2;
        }

        public override string ToString()
        {
            return "Contract: " + base.ToString();
        }

    }
}
