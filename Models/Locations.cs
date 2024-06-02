using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PowerGenerationLocationChecker.Converter;
using PowerGenerationLocationChecker.LocationsViewModel;

namespace PowerGenerationLocationChecker.Models
{
    internal partial class LocationsView : ObservableObject
    {
        [ObservableProperty]
        public string? address;

        [ObservableProperty]
        public string? postcode;















        //public LocationsView(string address, string postcode)
        //{
        //    this.address = new address;
        //    this.Postcode = postcode;
        //}
    }
}


