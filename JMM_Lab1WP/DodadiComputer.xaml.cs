using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace JMM_Lab1WP
{
    public partial class DodadiComputer : PhoneApplicationPage
    {
        public DodadiComputer()
        {
            InitializeComponent();
        }

        private void Button_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            string ime = Ime.Text;
            string opis = Opis.Text;
            string imeslika = ImeSlika.Text;
            App.ViewModel.AddComputer(new ViewModels.ComputersViewModels() {Name=ime,Description=opis});
            
        }
    }
}