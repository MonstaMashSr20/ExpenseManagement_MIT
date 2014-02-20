using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using ExpenseManagementPhoneApp_MVVM.Model;
using System.Windows.Media.Imaging;
using ExpenseManagementPhoneApp_MVVM.Resources;
using System.IO.IsolatedStorage;

namespace ExpenseManagementPhoneApp_MVVM.ViewModel
{
    public class GeneralExpenseViewModel : INotifyPropertyChanged, IDisposable
    {
        private GeneralExpenseDataContext expenseDB;
        public GeneralExpenseViewModel(string connectionString) 
        {
            expenseDB = new GeneralExpenseDataContext(connectionString);
        }

        #region GeneralExpenseViewModelOperations

        //Create a new GeneralExpense
        public void addNewGeneralExpense(GeneralExpense _gerneralExpense) 
        {
            expenseDB.GeneralExpenses.InsertOnSubmit(_gerneralExpense);
            expenseDB.SubmitChanges();
        }

        #region FailedFileStorageCode

        #endregion

        #endregion

        #region INofityPropertyChangedMembers
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion

        public void Dispose()
        {
            this.Dispose();
        }
    }   
}
