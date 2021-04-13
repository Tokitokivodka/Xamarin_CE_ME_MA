using System;
using Newtonsoft.Json;

namespace Projet_Xamarin_CEMEMA.Model
{
    public class City
    {
        [JsonProperty("nomCommune")]
        public string CityName { get; set; }
    }
}
