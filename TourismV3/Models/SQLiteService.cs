using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ADDED BY DAN

using TourismV3.Models;
using System.Collections.ObjectModel;

namespace TourismV3
{
    public interface SQLiteService
    {
        ObservableCollection<RestModel> GetRestaurants();
        bool addRestaurant(RestModel NewOne);
        bool delRestaurant(RestModel NewOne);
        bool updateRestaurant(RestModel NewOne);
    }
}
