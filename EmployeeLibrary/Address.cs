//PROG 1224 - Lab 3
//Natalie Hyojung Yu
//Date: July 15, 2022

using System.Text.RegularExpressions;

namespace EmployeeLibrary
{
    public struct Address
    {
        private string street;
        private string city;
        private string province;
        private string postalCode;


        // Properties
        public string Street 
        { 
            get => street;
            set => street = (value != "") ? value : "Unknown";
        }
        public string City 
        {
            get => city;
            set => city = (value != "") ? value : "Unknown";
        }
        public string Province 
        {
            get => province;
            set => province = (value != "") ? value : "Unknown";
        }
        public string PostalCode 
        {
            get => postalCode;
            set
            {
                Regex rg = new Regex(@"^([A-Z]\d[A-Z]( )?\d[A-Z]\d)$"); //Canada postal code - "A1A 1A1"
                if (rg.IsMatch(value.Trim()))
                    postalCode = value;
                else
                    postalCode = "X0X0X0";
             }
        }

        // Constructor
        public Address(string streetName, string cityName, string provinceAbb, string pcode) :this()
        {
            Street = streetName;
            City = cityName;
            Province = provinceAbb;
            PostalCode = pcode;
        }

        // ToString
        public override string ToString()
        {
            return $"{Street} {City}, {Province} {PostalCode}";
        }

    }
}
