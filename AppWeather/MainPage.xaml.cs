using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using AppWeather.Resources;
using AppWeather.Model;
using Newtonsoft.Json;
using TaGiang.OneDay;
using System.Windows.Media.Imaging;

namespace AppWeather
{
    public partial class MainPage : PhoneApplicationPage
    {
        private static string qKey = null;
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            lsCountry.ItemsSource = null;
            lsCountry.ItemsSource = Country.LoadData();
        }
        private void lsCountry_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = lsCountry.SelectedIndex;
            Country name = lsCountry.SelectedItem as Country;
            qKey = name.Key;
            WebClient webCleint = new WebClient();
            webCleint.DownloadStringCompleted += webCleint_DownloadStringCompleted;
            webCleint.DownloadStringAsync(new Uri("http://api.openweathermap.org/data/2.5/weather?q=" + qKey, UriKind.RelativeOrAbsolute));
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            //NavigationService.Navigate(new Uri("/SlideView.xaml", UriKind.RelativeOrAbsolute));
            WebClient webCleint = new WebClient();
            webCleint.DownloadStringCompleted += webCleint_DownloadStringCompleted;
            webCleint.DownloadStringAsync(new Uri("http://api.openweathermap.org/data/2.5/weather?q=" + txtCountry.Text, UriKind.RelativeOrAbsolute));
        }
        void webCleint_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(e.Result))
                {
                    OneDay root = JsonConvert.DeserializeObject<OneDay>(e.Result);
                    UpdateView(root);
                }
                else
                {
                    MessageBox.Show("Not data");
                }
            }
            catch
            {
                MessageBox.Show("Server not availble");
            }
        }
        private void UpdateView(OneDay data)
        {
            BitmapImage bmp = new BitmapImage();
            bmp.UriSource = new Uri("http://openweathermap.org/img/w/"+data.Weather[0].Icon+".png", UriKind.RelativeOrAbsolute);
            imgSky.Width = 80;
            imgSky.Height = 80;
            imgSky.Source = bmp;
            lblCloudiness.Text = "Cloudiness: " + data.Weather[0].Main;
            lblHumidity.Text = "Humidity: " + data.Main.Humidity + " % ";
            lblMaxTemp.Text = "Max Temp: " + ChageKToC(data.Main.TempMax) + " *C ";
            lblMinTemp.Text = "Min Temp: " + ChageKToC(data.Main.TempMin) + " *C ";
            lblPressure.Text = "Pressure: " + data.Main.Pressure + " hPa ";
            lblSunrise.Text = "Sunrise: " + data.Sys.Sunrise + " AM ";
            lblTemp.Text = "Temp: " + ChageKToC(data.Main.Temp) + " *C ";
            lblWind.Text = "Wind: "+data.Wind.Speed+ " m/s ";
            lblCountry.Text = "Tỉnh/Thành phố: " + data.Name;
        }
        private double ChageKToC(double K)
        {
            return (K - 273);
        }
    }
}