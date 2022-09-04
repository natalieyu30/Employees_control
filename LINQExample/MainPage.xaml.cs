using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using EmployeeLibrary;
using UWBankLibrary;
using System.Collections;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace LINQExample
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private List<Employee> employees;
        private int[] nums = { 5, 45, 82, 2, 46, 31, 20, 7, 10, 99 };

        private List<BankAccount> accounts;
        

        public MainPage()
        {
            this.InitializeComponent();
            employees = Data.GetEmployees().ToList();
            accounts = Helper.GetBankAccounts().ToList();

            //foreach (Employee e in employees)
            //{
            //    lstAccounts.Items.Add(e.FirstName);
            //}

            //built in LINQ methods
            IEnumerable<Employee> results = employees.Select(n => n);

            //LINQ syntax
            IEnumerable<string> results2 = from emp in employees
                                           select emp.FirstName;

            // select employee whose hire date was 10 months ago and above
            var starts = from emp in employees
                         where emp.HireDate >= DateTime.Today.AddMonths(-10)  //dtpHire.Date.Datetime
                         orderby emp.LastName descending
                         select emp;

            //use 'var' to declare variant for flexibility
            var names = employees.Select(n => n.FirstName);

            int max = nums.Max(n => n);
            int total = nums.Sum(n => n);
            int count = nums.Count(n => n > 50);


            var savings = accounts.Where(s => s is SavingsAccount).Select(s => s);
            var chequings = accounts.Where(c => c is ChequingAccount).Select(c => c);

            var all = savings.Join(chequings, s => s.Number, c => c.Number, (s, c) => (s, c));
            foreach (var item in all)
            {
                lstAccounts.Items.Add(item.ToString());
            }
        }
    }
}
