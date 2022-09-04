//PROG 1224 - Lab 3
//Natalie Hyojung Yu
//Date: July 15, 2022

using System;

namespace EmployeeLibrary
{
    public class Salary : Employee
    {
        //event and delegate
        public delegate void CheckAmount();
        public event CheckAmount CheckAmountEvent;

        // Field
        private decimal amount;

        // Property
        public decimal Amount
        {
            get => amount;
            //salary starts from 40000 and above
            //set => amount = (value >= 40000m) ? value : 40000m;
            set
            {
                if ((value <= 0M || value >= 100000M) && CheckAmountEvent != null)
                    CheckAmountEvent();
                else 
                    amount = value;
            }
        }

        // Constructors
        public Salary(string sinNum) : base(sinNum) { }
        public Salary(string sinNum, string first, string last) : base(sinNum, first, last) { }
        public Salary(string sinNum, string first, string last, decimal amount) : base(sinNum, first, last)
        {
            Amount = amount;
            CheckAmountEvent = null;
            if (amount >= 100000M && CheckAmountEvent != null)
                CheckAmountEvent();
        }

        public override string ToString()
        {
            return "Salary: " + base.ToString();
        }

        public override decimal Calculate()
        {
            return (Amount > 0M) ? Math.Round((Amount / 26M), 2) : 0M;
        }

        //override incometax
        public override decimal IncomeTax()
        {
            decimal pay = this.Calculate();

            if (Amount <= 49000)
                return Math.Round(pay * 0.15m, 2);
            else if (Amount <= 98000)
                return Math.Round(pay * 0.2m, 2);
            else if (Amount <= 151000)
                return Math.Round(pay * 0.26m, 2);
            else if (Amount <= 215000)
                return Math.Round(pay * 0.29m, 2);
            else
                return Math.Round(pay * 0.33m, 2);
        }

        //IDeduction Interface
        private decimal pension = 0.03M;
        public decimal PensionRate
        {   get => pension; 
            set { this.pension = (value < 1M) ? value : 0.03M; } 
        }
        public new decimal Pension()
        {
            //salary pay 3% of pay contribution towards pension
            return Math.Round((Amount / 26) * pension, 2);
        }
    }
}
