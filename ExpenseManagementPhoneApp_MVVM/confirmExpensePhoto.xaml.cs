using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Tasks;
using System.Windows.Media.Imaging;

namespace ExpenseManagementPhoneApp_MVVM
{
    public partial class confirmExpensePhoto : PhoneApplicationPage
    {
        public confirmExpensePhoto()
        {
            InitializeComponent();
            imgPhotoTaken.Source = App._expenseDAL.getExpenseImage();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            decimal amount = Convert.ToDecimal(txtAmount.Text);
            DateTime date =  Convert.ToDateTime( datePicker.Value);
            App._expenseDAL.createNewGeneralExpenseItem(amount, date, txtDescription.Text);
        }

        public void validateTextGotFocus(TextBox _textBox)
        {
            try
            {
                Decimal.Parse(_textBox.Text);
            }
            catch
            {
                _textBox.Text = "";
            }
        }

        public void validateTextLostFocus(TextBox _TextBox)
        {
            try
            {
                Decimal.Parse(_TextBox.Text);
            }
            catch
            {
                _TextBox.Text = "please enter number";
            }
        }

        private void txtAmount_GotFocus(object sender, RoutedEventArgs e)
        {

            TextBox _textBox = (TextBox)sender;
            validateTextGotFocus(_textBox);
            
        }

        private void txtAmount_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox _textBox = (TextBox)sender;
            validateTextLostFocus(_textBox);
        }

        private void txtDescription_LostFocus(object sender, RoutedEventArgs e)
        {

        }  
    }
}