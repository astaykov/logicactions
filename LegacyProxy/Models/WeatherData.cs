using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LegacyProxy.Models
{
    public class WeatherData
    {
        public int ID { get; set; }
        public string Country { get; set; }
        public string Continent { get; set; }
        public string SiteName { get; set; }
        public string VisibilityCodeDay { get; set; }
        public string VisibilityCodeNight { get; set; }
        public int RelativeHumidityDay { get; set; }
        public int RelativeHumidityNight { get; set; }
        public int ScreenTemperatureDay { get; set; }
        public int ScreenTemperatureNight { get; set; }
        public int FeelsLikeTemperatureDay { get; set; }
        public int FeelsLikeTemperatureNight { get; set; }
        public DateTime Date { get; set; }
        public int TimeStep { get; set; }
        public int WindSpeedDay { get; set; }
        public int WindDirectionDay { get; set; }
    }
}