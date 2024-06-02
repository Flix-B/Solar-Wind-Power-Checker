using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Collections.ObjectModel;
using PowerGenerationLocationChecker;
using System.Resources;


namespace PowerGenerationLocationChecker.LocationsViewModel
{
    public class LocationViewModel
    {
        #region Properties

        public string filePath { get; set; } = "C:\\Users\\felix\\source\\repos\\SolarWindPowerChecker\\Resources\\JSON\\SavedLocations.json";


        #endregion

        //public ObservableCollection<object>? LocationCollection { get; set; }
        //public LocationViewModel()
        //{
        //    LocationCollection = new ObservableCollection<object>((List<object>)Getlocation(filePath));
                


        //}

        //public static object Getlocation(string filePath)
        //{
        //    try
        //    {

        //        string jsonString = File.ReadAllText(filePath);

        //        dynamic jsonData = JsonConvert.DeserializeObject(jsonString)!;

        //        if (jsonData is JArray jsonArray)
        //        {
        //            JArray firstEntry = (JArray)jsonArray[0];


        //            object firstValue = firstEntry[0];
        //            object lastValue = firstEntry[firstEntry.Count - 1];

        //            return (firstValue, lastValue);
        //        }
        //        else
        //        {
        //            throw new InvalidDataException("JSON data is not an array");
        //        }
        //    }
        //    catch (FileNotFoundException)
        //    {
        //        throw new FileNotFoundException($"JSON file not found: {filePath}");
        //    }
        //    catch (JsonException ex)
        //    {
        //        throw new JsonException($"Error parsing JSON: {ex.Message}");
        //    }
        //}
    }   
}
