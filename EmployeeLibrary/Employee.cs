//PROG 1224 - Lab 3
//Natalie Hyojung Yu
//Date: July 15, 2022

using System;

namespace EmployeeLibrary
{
    public abstract class Employee : IDeduction
    {
        // Fields
        private readonly string sin;    // read-only
        private string first;
        private string last;
        private DateTime hire;
        private DateTime birth;
        private string email;
        private string phone;
        private Address address;
        private bool status;
        public const string COMPANY = "PROG1124 LAB3 CO.INS.";
        private string desc;

        // Properties
        public string Desc
        {
            get => desc;
            set => ToString();
        }
        public string Sin
        {
            get => sin;
        }

        public string FirstName
        {
            get => first;
            set => first = (value != "") ? value : "Unknown";
        }

        public string LastName
        {
            get => last;
            set => last = (value != "") ? value : "Unknown";
        }

        public DateTime HireDate
        {
            get => hire;
            set
            {
                if ((value.Year < DateTime.Now.Year)    // hire date can not be in the future from now
                  || ((value.Year == DateTime.Now.Year) && (value.Month < DateTime.Now.Month))
                  || ((value.Year == DateTime.Now.Year) && (value.Month == DateTime.Now.Month) && (value.Date <= DateTime.Now.Date)))
                       hire = value;
                else
                    hire = DateTime.Now;
            }
        }
        public string HireDateString { get => hire.ToShortDateString(); }

        public DateTime BirthDate
        {
            get => birth;
            set
            {
                int minimumAge = 14; //Ontario minumum working age - 14
                if (DateTime.Now.Year - value.Year >= minimumAge)  
                    birth = value;
                else 
                    birth = DateTime.MinValue;
            }
        }

        public string BirthDateString { get => birth.ToShortDateString(); }

        public string Email
        {
            get => email;
            set
            {
                email = value;
            }
        }

        public string Phone
        {
            get => phone;
            set => phone = (value.Length == 10) ? value : "1111111111";
            
        }

        public Address Address
        {
            get => address;
            set
            {
                address = value;
            }
        }

        public bool Active
        {
            get => status;
            set
            {
                if (value == true || value == false)
                    status = value;
                else
                    status = false;
            }
        }
        //public bool Active { get; set; }
        

        // Constructor
        public Employee(string sinNum)
        {
            sin = (sinNum.Length == 9 && int.TryParse(sinNum, out _)) ? sinNum : "000000000";
            FirstName = "Unknown";
            LastName = "Unknown";
            Active = true;
        }

        public Employee(string sinNum, string first, string last)
        {
            sin = (sinNum.Length == 9 && int.TryParse(sinNum, out _)) ? sinNum : "000000000";
            FirstName = first;
            LastName = last;
            Active = true;
        }

        // ToString
        public override string ToString()
        {
            string phoneNum = (Phone == null || Phone == "1111111111" || Phone == "") ? "Not provided" : Phone.Insert(6, "-").Insert(3, "-");
            return $"SIN: {Sin}, Employee Full Name: {FirstName} {LastName}, Phone: {phoneNum}\nPay: ${Calculate()}, Bonus: ${Bonus()}, Deductions(Income Tax biweekly): {IncomeTax() / 26}\n";
        }

        //Methods
        public virtual decimal Bonus()
        {
            decimal bonus = 0m;
            return bonus;
        }

        //abstract method to ensure all derived classes implement a Calculate method
        public abstract decimal Calculate();

        public virtual decimal IncomeTax()
        {
            decimal pay = this.Calculate();
            decimal yearAmount = pay * 26;

            if (yearAmount <= 49000)
                return Math.Round(pay * 0.15m, 2);
            else if (yearAmount <= 98000)
                return Math.Round(pay * 0.2m, 2);
            else if (yearAmount <= 151000)
                return Math.Round(pay * 0.26m, 2);
            else if (yearAmount <= 215000)
                return Math.Round(pay * 0.29m, 2);
            else
                return Math.Round(pay * 0.33m, 2);
        }

        public decimal Pension()
        {
            decimal pension = 0m;
            return pension;
        }

        public decimal UnionDues()
        {
            decimal unionDues = 0m;
            return unionDues;
        }

        public decimal Insurance()
        {
            decimal insurance = 0m;
            return insurance;
        }
    }
}
