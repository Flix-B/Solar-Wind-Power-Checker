using Microsoft.Extensions.Logging;
using Syncfusion.Maui.Core.Hosting;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Dynamic;
using System.Globalization;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Collections;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;
using Microsoft.Maui;
using Newtonsoft.Json;
using System.Data.SqlTypes;

namespace PowerGenerationLocationChecker.LocationsViewModel
{
  
    public class ViewModel : INotifyPropertyChanged
    {
        #region Fields

        private dynamic? itemsSource;
        public event PropertyChangedEventHandler? PropertyChanged;

        #endregion

        #region Properties
        public dynamic? ItemsSource
        {
            get
            {
                return itemsSource;
            }

            set
            {
                itemsSource = value;
                RaisepropertyChanged("ItemsSource");
            }
        }

        private void RaisepropertyChanged(string v)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(v));
        }
        #endregion

        #region Constructor
        public ViewModel()
        {
            
            var assembly = typeof(MainPage).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream("PowerGenerationLocationChecker.Resources.JSON.SavedLocations.json")!;
            using (StreamReader sr = new StreamReader(stream))
           {
               var jsonText = sr.ReadToEnd();
                ItemsSource = JsonConvert.DeserializeObject(jsonText);
            }

        }
        #endregion

    }
}
