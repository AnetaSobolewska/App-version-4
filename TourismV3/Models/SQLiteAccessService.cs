using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ADDED BY DAN

using TourismV3.Models;
using TourismV3.ViewModels;
using System.Collections.ObjectModel;
using Windows.UI.Popups;

namespace TourismV3.DAL
{
    class SQLiteAccessService:SQLiteService
    {
        public ObservableCollection<RestModel> GetRestaurants()
        {
            ObservableCollection<RestModel> restaurantList = new ObservableCollection<RestModel>();
            using (var db = new SQLite.SQLiteConnection(App.DBPath))
            {
                var myRestaurants = db.Table<RestTable>().OrderBy(s => s.RestName);
                foreach (var aRestaurant in myRestaurants)
                {
                    var restaurant = new RestModel()
                    {
                        ID = aRestaurant.Id,
                        RestName = aRestaurant.RestName,
                        RestAddress = aRestaurant.RestAddress,
                        RestPhone = aRestaurant.RestPhone,
                        RestFood = aRestaurant.RestFood,
                        RestDescription = aRestaurant.RestDescription,
                        RestPicture1 = aRestaurant.RestPicture1,
                        RestPicture2 = aRestaurant.RestPicture2
                    };
                    restaurantList.Add(restaurant);
                }
            }
            return restaurantList;
        }

        public bool addRestaurant(RestModel NewRestaurant)
        {
            using (var db = new SQLite.SQLiteConnection(App.DBPath))
            {
                try
                {
                    var existingRestaurant = (db.Table<RestTable>().Where(s => s.RestAddress == NewRestaurant.RestAddress)).SingleOrDefault();
                    MessageDialog md;
                    if (!string.IsNullOrEmpty(NewRestaurant.RestAddress) && existingRestaurant == null)
                    {
                        int success = db.Insert(new RestTable()
                        {
                            Id = NewRestaurant.ID,
                            RestName = NewRestaurant.RestName,
                            RestAddress = NewRestaurant.RestAddress,
                            RestPhone = NewRestaurant.RestPhone,
                            RestFood = NewRestaurant.RestFood,
                            RestDescription = NewRestaurant.RestDescription,
                            RestPicture1 = NewRestaurant.RestPicture1,
                            RestPicture2 = NewRestaurant.RestPicture2
                        });
                        return true;
                    }
                    else
                          md = new MessageDialog("Place at this address already exist.");
                    md.ShowAsync();
                        return false;
                    
                }
                catch (Exception ex)
                {
                    
                  
                    throw ex;

                }
            }
        }

        public bool delRestaurant(RestModel SelectedRestaurant)
        {
            using (var db = new SQLite.SQLiteConnection(App.DBPath))
            {
                try
                {
                    int success = db.Delete(new RestTable()
                    {
                        Id = SelectedRestaurant.ID,
                        RestName = SelectedRestaurant.RestName,
                        RestAddress = SelectedRestaurant.RestAddress,
                        RestPhone = SelectedRestaurant.RestPhone,
                        RestFood = SelectedRestaurant.RestFood,
                        RestDescription = SelectedRestaurant.RestDescription,
                        RestPicture1 = SelectedRestaurant.RestPicture1,
                        RestPicture2 = SelectedRestaurant.RestPicture2
                    });
                    return true;
                
                }
                catch (Exception ex)
                {
                    throw ex;
                    
                }
            }
        }

    }
}
