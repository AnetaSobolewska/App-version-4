using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ADDED BY DAN

using TourismV3.Common;
using TourismV3.Models;
using TourismV3.DAL;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Windows.UI.Popups;

namespace TourismV3.ViewModels
{
    public class RestViewModel:INotifyPropertyChanged
    {
        private SQLiteService _data;
        private ObservableCollection<RestModel> _restaurants;
        private RestModel _newRestaurant;
        private RestModel _selectedRestaurant;

        public RelayCommand AddRestCommand { get; set; }
        public RelayCommand DelRestCommand { get; set; }
        public RestModel SelectedRestaurant
        {
            get { return this._selectedRestaurant; }
            set { this._selectedRestaurant = value; NotifyPropertyChanged("SelectedRestaurant");}
        }

        public RestModel NewRestaurant
        {
            get { return this._newRestaurant;}
            set { this._newRestaurant = value; NotifyPropertyChanged("NewRestaurant");}
        }

        public ObservableCollection<RestModel> Restaurants
        {
            get { return this._restaurants; }
            set { this._restaurants = value; NotifyPropertyChanged("Restaurants");}
        }

        public RestViewModel()
        {
            this._data = new SQLiteAccessService();
            this.SelectedRestaurant = new RestModel();
            this.NewRestaurant = new RestModel();
            this.AddRestCommand = new RelayCommand(insertRestaurant);
            this.Restaurants = _data.GetRestaurants();
            this.DelRestCommand = new RelayCommand(deleteRestaurant);
        }

        public void insertRestaurant(Object obj)
        {
            bool success = _data.addRestaurant(NewRestaurant);
            if (success)
            {
                this.Restaurants = _data.GetRestaurants();
            }
            else
            {
                ;
            }
        }

        public void deleteRestaurant(Object obj)
        {
            bool success = _data.delRestaurant(SelectedRestaurant);
            if (success)
            {
                this.Restaurants = _data.GetRestaurants();
            }
            else
            {
                ;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void NotifyPropertyChanged(string propertyName)
        {
            var handler = this.PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
