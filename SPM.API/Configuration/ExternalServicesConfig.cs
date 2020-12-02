using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPM.API.Configuration
{
    public class ExternalServicesConfig
    {
        public const string WeatherApi = "WeatherApi";
        public const string ProductApi = "ProductApi";

        public string Url { get; set; }
        public int MinsToCache { get; set; }
    }
}
