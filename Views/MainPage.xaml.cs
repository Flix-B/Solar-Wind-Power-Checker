using CommunityToolkit;
using System.Collections.ObjectModel;
using PowerGenerationLocationChecker.Models;
using PowerGenerationLocationChecker.LocationsViewModel;
using PowerGenerationLocationChecker.Converter;
using System.Globalization;
using Microsoft.Maui.Controls;
using Microsoft.Maui.ApplicationModel;





namespace PowerGenerationLocationChecker

{
     public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            LocationViewModel locationinstance = new();

            //BindingContext = locationinstance.Getlocation1(filePath: "Resources.JSON.SavedLocations.json");
            BindingContext = new LocationViewModel();

        }
        private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
        {

        }

        private async void InfoButton_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(Views.SuppliersPage));
        }

        private async void HomeButton_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(MainPage));
        }


        private async void TapGestureGenerate_Tapped(object sender, TappedEventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(Views.MapPage));
        }
    }

}
