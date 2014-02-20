using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpenseManagementPhoneApp_MVVM.Model;
using ExpenseManagementPhoneApp_MVVM.ViewModel;
using System.IO.IsolatedStorage;
using System.IO;
using Windows.Foundation;
using Windows.Storage;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows;

namespace ExpenseManagementPhoneApp_MVVM
{
    public class expenseDAL
    {
        string connectionString = "Data Source=isostore:/ExpenseManagement.sdf";
        GeneralExpenseViewModel _viewModel;


        public static GeneralExpense genExpense;

        public expenseDAL()
        {
            //creates a database from our GeneralExpenseDataContext
            using (GeneralExpenseDataContext DB = new GeneralExpenseDataContext(connectionString))
            {
                if (DB.DatabaseExists() == false)
                {
                    DB.CreateDatabase();
                }
            }

            genExpense = new GeneralExpense(DateTime.Now, 0);
        }

        public BitmapImage getExpenseImage()
        {
            return genExpense.expenseImage;
        }
     
        public void addGeneralExpenes(DateTime expenseDate, Decimal expenseAmount, string expenseDescription, string expenseImageURL ) 
        {
            using (_viewModel = new GeneralExpenseViewModel(connectionString))
            {
                GeneralExpense expense = new GeneralExpense(expenseDate, expenseAmount);
                _viewModel.addNewGeneralExpense(expense);
            }
        }

        public async void writeImageToIsoStorage(Stream image, string _fileName)
        {

            Stream photoStream = image;
            StorageFolder directory = await ApplicationData.Current.LocalFolder.CreateFolderAsync("expenseImages", CreationCollisionOption.OpenIfExists);
            StorageFile file = await ApplicationData.Current.LocalFolder.CreateFileAsync(@"expenseImages\newImage.jpg", CreationCollisionOption.ReplaceExisting);

            using (Stream current = await file.OpenStreamForWriteAsync())
            {
                await photoStream.CopyToAsync(current);
            }

        }

        public async void writeImage(BitmapImage image)
        {
            genExpense.expenseImageURL = @"expenseImages\uniqueImageName.jpg";
            genExpense.expenseImage = image;

            var bmp = new WriteableBitmap(image);

            StorageFolder directory = await ApplicationData.Current.LocalFolder.CreateFolderAsync("expenseImages", CreationCollisionOption.OpenIfExists);

            using (IsolatedStorageFile isf = IsolatedStorageFile.GetUserStoreForApplication())
            {                
                using (IsolatedStorageFileStream rawStream = isf.CreateFile(@"expenseImages\uniqueImageName.jpg"))
                {
                    bmp.SaveJpeg(rawStream, 100, 300, 0, 100);
                    rawStream.Close();
                }
            }
        }

        public void createNewGeneralExpenseItem(decimal amount, DateTime date, string description) 
        {
            genExpense.expenseAmount = amount;
            genExpense.expenseDate = date;
            genExpense.expenseDescription = description;
            using(_viewModel = new GeneralExpenseViewModel(connectionString))
            {
                _viewModel.addNewGeneralExpense(genExpense);
            }             
        }
    }
}
