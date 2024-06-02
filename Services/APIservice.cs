using System.Text.Json;

namespace PowerGenerationLocationChecker.Services
{

    public class ApiService
        {
            private readonly HttpClient _httpClient;

            public ApiService(HttpClient httpClient)
            {
                _httpClient = httpClient;
            }

            public async Task<T> GetApiData<T>(string url)
            {
                HttpResponseMessage response = await _httpClient.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string jsonString = await response.Content.ReadAsStringAsync();
                    return JsonSerializer.Deserialize<T>(jsonString)!;
                }
                else
                {
                    throw new Exception($"API call failed. Status code: {response.StatusCode}");
                }
            }

            public async Task<SolarData[]> GetSolarData(string latval, string longval)
            {
                string solarApiUrl = ($"https://ukpowernetworks.opendatasoft.com/api/explore/v2.1/catalog/datasets/ukpn-solar-irenes/records?limit=1&refine=geo_point_2d%3A{latval}%2C%20{longval}");
                return await GetApiData<SolarData[]>(solarApiUrl);
            }

            public async Task<WindData[]> GetWindData(string latval, string longval)
            {
                string windApiUrl = ($"https://ukpowernetworks.opendatasoft.com/api/explore/v2.1/catalog/datasets/ukpn-wind-irenes/records?limit=1&refine=geo_point_2d%3A{latval}%2C20{longval}");
                return await GetApiData<WindData[]>(windApiUrl);
            }
        }

        public class SolarData
        {
            
        }

        public class WindData
        {
            
        }
    }


