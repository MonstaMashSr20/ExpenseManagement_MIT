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
using ExpenseManagementPhoneApp_MVVM.ViewModel;
using ExpenseManagementPhoneApp_MVVM;

namespace ExpenseManagementPhoneApp_MVVM
{
    public partial class Page1 : PhoneApplicationPage 
    {
        CameraCaptureTask cct;
        PhotoChooserTask pct;

        public Page1()
        {
            InitializeComponent();
            cct = new CameraCaptureTask();
            cct.Completed += cct_Completed;

            pct = new PhotoChooserTask();
            pct.Completed += pct_Completed;
        }

        void cct_Completed(object sender, PhotoResult e)
        {
            if(e.TaskResult == TaskResult.OK)
            {
                BitmapImage BitmapImage = new BitmapImage();
                BitmapImage.SetSource(e.ChosenPhoto);
                App._expenseDAL.writeImage(BitmapImage);
            }

            NavigationService.Navigate(new Uri("/confirmExpensePhoto.xaml", UriKind.Relative));
        }

        void pct_Completed(object sender, PhotoResult e)
        {
            if (e.TaskResult == TaskResult.OK)
            {
                var BitmapImage = new BitmapImage();
                BitmapImage.SetSource(e.ChosenPhoto);
                App._expenseDAL.writeImage(BitmapImage);
            }

            NavigationService.Navigate(new Uri("/confirmExpensePhoto.xaml", UriKind.Relative));
        }

        private void btnTakePhoto_Clicked(object sender, EventArgs e)
        {
            cct.Show();
        }

        private void btnBrowseImages_Click(object sender, EventArgs e)
        {
            pct.Show();
        }
    }
}