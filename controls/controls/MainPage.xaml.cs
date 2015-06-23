using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using controls.Resources;
using System.Windows.Media;
using System.Windows.Documents;
using System.Windows.Threading;
namespace controls
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            var flatList = new List<MyObject>() {
                new MyObject() { Category = "A", Data = "some data 1" },
                new MyObject() { Category = "A", Data = "some data 2" },
                new MyObject() { Category = "B", Data = "some data 3" },
                new MyObject() { Category = "C", Data = "some data 4" },
                new MyObject() { Category = "C", Data = "some data 5" },
                new MyObject() { Category = "C", Data = "some data 6" }};
            txtCountry.ItemsSource = flatList;
            longlist.ItemsSource = flatList;

        }

        private void txtCountry_TextChanged(object sender, RoutedEventArgs e)
        {

        }

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            MessageBoxResult res = MessageBox.Show("Bạn đã thay đổi Value: " + slider.Value, "Thông báo", MessageBoxButton.OKCancel);
            if (res == MessageBoxResult.OK)
            {
                MessageBox.Show("Bạn đã thay đổi");
            }
            else
            {
            }
        }

        private void btnDisplay_Click(object sender, RoutedEventArgs e)
        {

            var flatList = new List<MyObject>() {
                new MyObject() { Category = "A", Data = "some data 1" },
                new MyObject() { Category = "A", Data = "some data 2" },
                new MyObject() { Category = "B", Data = "some data 3" },
                new MyObject() { Category = "C", Data = "some data 4" },
                new MyObject() { Category = "C", Data = "some data 5" },
                new MyObject() { Category = "C", Data = "some data 6" }};
            longlist.ItemsSource = flatList;
        }
    }
}