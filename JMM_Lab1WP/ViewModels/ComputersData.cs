using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace JMM_Lab1WP.ViewModels
{
    public class ComputersData : INotifyPropertyChanged
    {
        public ComputersData()
        {
            this.computers = new  ObservableCollection<ComputersViewModels>();
        }
        public ObservableCollection<ComputersViewModels> computers { get; private set; }

        public bool IsDataLoaded
        {
            get;
            private set;
        }

        public ObservableCollection<ComputersViewModels> Computers
        {
            get { return computers; }
            
        }

        public void LoadData()
        {
            this.Computers.Add(new ComputersViewModels() { ID="0", Name="Dell"  ,Description="dsadsdfafdg"});
            this.Computers.Add(new ComputersViewModels() { ID = "1", Name = "Assus", Description = "dsadsdfafdg" });
            this.Computers.Add(new ComputersViewModels() { ID = "2", Name = "Acer", Description = "adsfaff" });
            
            this.IsDataLoaded = true;
        }


         public void AddComputer(ComputersViewModels cvm)
            {
                Computers.Add(cvm);
                NotifyPropertyChanged("Computers");
            }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String p)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(p));
            }
        }
    }
}
