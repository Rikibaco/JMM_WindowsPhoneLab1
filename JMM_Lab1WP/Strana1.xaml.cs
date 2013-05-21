using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using JMM_Lab1WP.ViewModels;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace JMM_Lab1WP
{
    public partial class PivotPage1 : PhoneApplicationPage
    {
        public PivotPage1()
        {
            InitializeComponent();
            DataContext = App.ViewModel;
        }

        private void LongListSelector1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
          
        }
    }
}