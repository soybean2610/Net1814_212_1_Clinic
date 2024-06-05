﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Clinic.WpfApp.UI.DetailWindow
{
    /// <summary>
    /// Interaction logic for WRecordDetailWindow.xaml
    /// </summary>
    public partial class WRecordDetailWindow : Window
    {
        public WRecordDetailWindow(Data.Models.RecordDetail selectedRecordDetail)
        {
            InitializeComponent();
            this.DataContext = selectedRecordDetail;
        }
    }
}
