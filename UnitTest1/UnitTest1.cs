using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework.AppContainer;
using TourismV3.Common;
using TourismV3.Models;
using TourismV3.ViewModels;
using Assert = Microsoft.VisualStudio.TestPlatform.UnitTestFramework.Assert;

namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        [UITestMethod]
        public void TestAddDeleteRestaurant()
        {
            
            var restaurants=new ObservableCollection<RestModel>();
            var r = new RestModel();
            r.ID = 12345;
            r.RestAddress = "test";
            r.RestDescription = "test";
            r.RestFood = "test";
            r.RestName = "test";
            r.RestPhone = 544654;
            r.RestPicture1 = "test";
            r.RestPicture2 = "test";
            restaurants.Add(r);
          Assert.IsNotNull(restaurants);
          
        }

        
    }
}
