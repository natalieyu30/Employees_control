//PROG 1224 - Lab 3
//Natalie Hyojung Yu
//Date: July 15, 2022

namespace EmployeeLibrary
{
    public interface IDeduction
    {
        decimal IncomeTax();
        decimal Pension();
        decimal UnionDues();
        decimal Insurance();
    }
}
