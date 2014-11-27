using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ADDED BY DAN
using TourismV3.ViewModels;
using System.ComponentModel;

namespace TourismV3.Models
{
    public class RestModel:INotifyPropertyChanged
    {
        // ADDED BY DAN - setting up the event handler for changed properties
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void NotifyPropertyChanged(string propertyName)
        {
            var handler = this.PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        
        // ADDED BY DAN - setting up private fields
        int _Id;
        string _restName;
        string _restAddress;
        int _restPhone;
        string _restFood;
        string _restDescription;
        string _restPicture1;
        string _restPicture2;

        // ADDED BY DAN - setting up public fields
        public int ID 
        { 
            get{return _Id;}
            set { if (_Id != value) _Id = value; NotifyPropertyChanged("ID"); }
        }

        public string RestName
        {
            get { return _restName; }
            set { if (_restName != value) _restName = value; NotifyPropertyChanged("RestName"); }
        }

        public string RestAddress
        {
            get { return _restAddress; }
            set { if (_restAddress != value) _restAddress = value; NotifyPropertyChanged("RestAddress"); }
        }

        public int RestPhone
        {
            get { return _restPhone; }
            set { if (_restPhone != value) _restPhone = value; NotifyPropertyChanged("RestPhone"); }
        }

        public string RestFood
        {
            get { return _restFood; }
            set { if (_restFood != value) _restFood = value; NotifyPropertyChanged("RestFood"); }
        }

        public string RestDescription
        {
            get { return _restDescription; }
            set { if (_restDescription != value) _restDescription = value; NotifyPropertyChanged("RestDescription"); }
        }

        public string RestPicture1
        {
            get { return _restPicture1; }
            set { if (_restPicture1 != value) _restPicture1 = value; NotifyPropertyChanged("RestPicture1"); }
        }

        public string RestPicture2
        {
            get { return _restPicture2; }
            set { if (_restPicture2 != value) _restPicture2 = value; NotifyPropertyChanged("RestPicture2"); }
        }

    }
}
