﻿#pragma checksum "C:\Users\Brendon\Documents\Visual Studio 2013\Projects\ExpenseManagement\ExpenseManagementPhoneApp_MVVM\ExpenseManagementPhoneApp_MVVM\confirmExpensePhoto.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9BB99DC147EC1C94C850E2C05AF6F3A7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34011
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace ExpenseManagementPhoneApp_MVVM {
    
    
    public partial class confirmExpensePhoto : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBox txtAmount;
        
        internal System.Windows.Controls.TextBox txtDescription;
        
        internal Microsoft.Phone.Controls.DatePicker datePicker;
        
        internal System.Windows.Controls.Image imgPhotoTaken;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/ExpenseManagementPhoneApp_MVVM;component/confirmExpensePhoto.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.txtAmount = ((System.Windows.Controls.TextBox)(this.FindName("txtAmount")));
            this.txtDescription = ((System.Windows.Controls.TextBox)(this.FindName("txtDescription")));
            this.datePicker = ((Microsoft.Phone.Controls.DatePicker)(this.FindName("datePicker")));
            this.imgPhotoTaken = ((System.Windows.Controls.Image)(this.FindName("imgPhotoTaken")));
        }
    }
}

