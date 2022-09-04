//PROG 1224 - Lab 3
//Natalie Hyojung Yu
//Date: July 15, 2022

using System;

namespace EmployeeLibrary
{
    public sealed class Manager : Salary
    {
        //private string title;

        public int YearsOfService
        {
            get => DateTime.Now.Year - HireDate.Year;
        }

        //public string Title
        //{
        //    get => title;
        //    set => title = (value != "") ? value : "Manager";
        //}

        public Manager(string sinNum) : base(sinNum) { }
        public Manager(string sinNum, string first, string last) : base(sinNum, first, last) { }
        public Manager(string sinNum, string first, string last, decimal salaryAmount) : base(sinNum, first, last, salaryAmount){}
        //public Manager(string sinNum, string first, string last, decimal salaryAmount, string title) : base(sinNum, first, last, salaryAmount)
        //{
        //    Title = title;
        //}

        public override decimal Bonus()
        {
            //years of service is less than 1 years will have no bonus.
            if (YearsOfService == 0)        
                return 0m;
            //years of service is over 1 year to 5 years will recieve 10% of bonus from the bi-weekly salary amount
            else if (YearsOfService <= 5)
                return Math.Round((Amount / 26) * 0.10m, 2);
            //years of service is over 6 years to 10 years will recieve 15% of bonus from the bi-weekly salary amount
            else if (YearsOfService <= 10)
                return Math.Round((Amount / 26) * 0.15m, 2);
            //years of service is over 11 years to 15 years will recieve 20% of bonus from the bi-weekly salary amount
            else if (YearsOfService <= 15)
                return Math.Round((Amount / 26) * 0.20m, 2);
            //years of service is over 16 years to 20 years will recieve 22% of bonus from the bi-weekly salary amount
            else if (YearsOfService <= 20)
                return Math.Round((Amount / 26) * 0.22m, 2);
            //years of service is over 21 years will recieve 25% of bonus from the bi-weekly salary amount
            else
                return Math.Round((Amount / 26) * 0.25m, 2);
        }

        //public override decimal Calculate()
        //{
        //    decimal pay = 0m;

        //    // 1 year = 52 weeks, bi-weekly paied
        //    pay = Amount / 52 * 2;

        //    decimal deduction = (IncomeTax(Amount) / 52 * 2) + Pension() + UnionDues() + Insurance();
        //    pay = pay - deduction + Bonus();

        //    return Math.Round(pay, 2);
        //}

        //public string formatYear(int num)
        //{
        //    string output = "";
        //    output = (num > 1) ?  "years" : "year";
        //    return output;
        //}

        public override string ToString()
        {
            return "Manager: " + base.ToString();
        }
    }
}