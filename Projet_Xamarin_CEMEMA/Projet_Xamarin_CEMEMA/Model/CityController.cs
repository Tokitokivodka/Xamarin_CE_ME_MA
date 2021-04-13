using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Projet_Xamarin_CEMEMA.Services;

namespace Projet_Xamarin_CEMEMA.Model
{
    public static class CityController
    { 
        public static async Task<string> GetCityFromPostalCode(string pc)
        {
            var client = HttpService.GetInstance();
            var result = await client.GetAsync($"https://apicarto.ign.fr/api/codes-postaux/communes/{pc}");
            var serializedResponse = await result.Content.ReadAsStringAsync();
            var cityResponse = JsonConvert.DeserializeObject<City>(serializedResponse);
            if (cityResponse != null)
            {
                return cityResponse.CityName;
            }
            return "";
        }
    }
}