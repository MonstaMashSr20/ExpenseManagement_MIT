using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using ExpenseManagementPhoneApp_MVVM.Resources;

namespace ExpenseManagementPhoneApp_MVVM
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();      
        }

        private void dtpExpense_DoubleTap(object sender, System.Windows.Input.GestureEventArgs e)
        {

        }

        private void btnGeneralExpense_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/generalExpenses.xaml", UriKind.Relative));
        }
    }
}