using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPM.API.Configuration
{
    public class FeaturesConfig
    {
        public bool EnableGreeting { get; set; }
        public bool EnableWeatherForecast { get; set; }
        public string ForecastSectionTitle { get; set; }

    }
}
