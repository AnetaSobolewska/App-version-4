using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

using TourismV3.ViewModels;
using TourismV3;
using TourismV3.Common;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace TourismV3.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Startpage : Page
    {
        public Startpage()
        {
            this.InitializeComponent();
        }

        private void AdminButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(RestAdmin));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            int index = 0;
            int itemCount = this.RestaList.Items.Count;
            if (itemCount == 0)
                return;
            if (index >= itemCount)
                index = itemCount - 1;

            this.RestaList.SelectedIndex = index;
            
        }


    }
}
