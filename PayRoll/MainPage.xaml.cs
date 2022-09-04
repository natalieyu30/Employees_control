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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace PayRoll
{
    /// <summary>
    /// PROG 1224 - Lab 3
    /// Name: Natalie Hyojung Yu
    /// Date: July 15, 2022
    /// </summary>
    public sealed partial class MainPage : Page
    {
        //declare a base reference
        private Employee[] empList;

        public MainPage()
        {
            this.InitializeComponent();
            empList = Data.GetEmployees();

            //display to the user in combo box
            foreach (Employee emp in empList)
                cboEmployee.Items.Add(emp.FirstName + " " + emp.LastName);
        }

        private void cboEmployee_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Employee emp = empList[cboEmployee.SelectedIndex];
            txtOutput.Text = emp.ToString();
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text = $"{Employee.COMPANY} - Total {empList.Length} employees";

            txtOutput.Text += "\n\n*******All Employees*******";
            foreach (Employee emp in empList)
                txtOutput.Text += $"{emp}";
        }
    }
}
