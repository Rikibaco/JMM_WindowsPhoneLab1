using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JMM_Lab1WP.ViewModels
{

    public class ComputersViewModels : INotifyPropertyChanged
    {
        private string _computerid;

        public string ID
        {
            get
            {
                return _computerid;
            }
            set
            {
                if (value != _computerid)
                {
                    _computerid = value;
                    NotifyPropertyChanged("ID");
                }
            }

        }

        private string _ComputerName;
        public string Name
        {
            get
            {
                return _ComputerName;
            }
            set
            {
                if (value != _ComputerName)
                {
                    _ComputerName = value;
                    NotifyPropertyChanged("Name");
                }
            }
        }

        private string _ComputerDescription;
            public string Description
            {
                get
                {
                    return _ComputerDescription;
                }
                set
                {
                    if(value != _ComputerDescription)
                    {
                        _ComputerDescription = value;
                        NotifyPropertyChanged("Description");
                    }
                }
            }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string p)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(p));
            }
            
        }

    }
}
