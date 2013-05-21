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
            

            NavigationService.Navigate(new Uri("/ComputerDetails.xaml?selectedItem=" +(LongListSelector1.SelectedItem as ComputersViewModels ).ID, UriKind.Relative));

            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/DodadiComputer.xaml", UriKind.Relative));
        }
    }
}