using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace ExpenseManagementPhoneApp_MVVM
{
    public partial class addGeneralExpense : PhoneApplicationPage
    {

        public addGeneralExpense()
        {
            InitializeComponent();
        }

        private void newExpense_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/newGeneralExpense.xaml", UriKind.Relative));
        }
    }
}