using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Windows.Media.Imaging;


namespace ExpenseManagementPhoneApp_MVVM.Model
{
    [Table]
    public class GeneralExpense : INotifyPropertyChanged, INotifyPropertyChanging
    {
        //General Expnese constructor
        public GeneralExpense(DateTime expenseDate, decimal expenseAmount)
        {
            this.expenseDate = expenseDate;
            this.expenseAmount = expenseAmount;
        }

        #region DatabaseTableProperties

        private int _expenseId;
        [Column(IsPrimaryKey = true, IsDbGenerated = true, DbType = "INT NOT NULL Identity", CanBeNull = false, AutoSync = AutoSync.OnInsert)]
        public int expenseId
        {
            get
            {
                return _expenseId;
            }
            set
            {
                NotifyPropertyChanging("expenseItemId");
                _expenseId = value;
                NotifyPropertyChanged("expenseItemId");
            }
        }

        private DateTime _expenseDate;
        [Column]
        public DateTime expenseDate
        {
            get
            {
                return _expenseDate;
            }
            set
            {
                if (_expenseDate != value)
                {
                    NotifyPropertyChanging("expenseItemDate");
                    _expenseDate = value;
                    NotifyPropertyChanged("expenseItemDate");
                }
            }
        }

        private decimal _expenseAmount;
        public decimal expenseAmount 
        {
            get 
            {
                return _expenseAmount;
            }
            set 
            {
                if (_expenseAmount != value)
                { 
                    NotifyPropertyChanging("expenseAmount");
                    _expenseAmount = value;
                    NotifyPropertyChanged("expenseAmount");
                }
            }
        }

        private string _expenseDescription;
        [Column]
        public string expenseDescription
        {
            get
            {
                return _expenseDescription;
            }
            set
            {
                if (_expenseDescription != value)
                {
                    NotifyPropertyChanging("description");
                    _expenseDescription = value;
                    NotifyPropertyChanged("description");
                }
            }
        }

        private string _expenseImageURL;
        [Column]
        public string expenseImageURL
        {
            get
            {
                return _expenseImageURL;
            }
            set
            {
                if (_expenseImageURL != value)
                {
                    NotifyPropertyChanging("pictureURL");
                    _expenseImageURL = value;
                    NotifyPropertyChanged("pictureURL");
                }
            }
        }

        private BitmapImage _expenseImage;
        public BitmapImage expenseImage
        {
            get
            {
                return _expenseImage;
            }
            set 
            {
                if (_expenseImage != value)
                {
                    _expenseImage = value;
                }
            }
        }



        [Column(IsVersion = true)]
        private Binary _version;

        #endregion

        #region INotifyPropertyChangedMembers

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion

        #region INotifyPropertyChangingMembers

        public event PropertyChangingEventHandler PropertyChanging;
        private void NotifyPropertyChanging(string propertyName)
        {
            if (PropertyChanging != null)
            {
                PropertyChanging(this, new PropertyChangingEventArgs(propertyName));
            }

        }

        #endregion
    }

    class GeneralExpenseDataContext :  DataContext
    {
        //constructor
        public GeneralExpenseDataContext(string conncetionString)
            : base(conncetionString)
        {
        }

        public Table<GeneralExpense> GeneralExpenses;
    }
}
