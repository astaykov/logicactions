using LegacyProxy.Models;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Web.Http;

namespace LegacyProxy.Controllers
{
    public class WeatherParseController : ApiController
    {

        private string serviceData = @"

    {""d"":
        {""results"":
            [
                    {""__metadata"":
                        {""id"":""https://ta/v1/DailyForecast(1L)"",""uri"":""https://apiecast(1L)"",""type"":""DataGovUK.MetOfficeWeatherOpenData.DailyForecast""},
                        ""ID"":""1"",""SiteName"":""SOUTHAMPTON AIRPORT (3)"",""Country"":""ENGLAND"",""Continent"":""EUROPE"",""Date"":""\/Date(1322524800000)\/"",""TimeStep"":0,""WindDirectionDay"":9,""WindSpeedDay"":22,""ScreenTemperatureDay"":13,""ScreenTemperatureNight"":6,""RelativeHumidityDay"":84,""RelativeHumidityNight"":80,""VisibilityCodeDay"":""MO"",""VisibilityCodeNight"":""EX"",""FeelsLikeTemperatureDay"":9,""FeelsLikeTemperatureNight"":4},
                    {""__metadata"":{""id"":""https://api.datamarket.azure.com/Data.ashx/DataGovUK/MetOfficeWeatherOpenData/v1/DailyForecast(2L)"",""uri"":""https://api.datamarket.azure.com/Data.ashx/DataGovUK/MetOfficeWeatherOpenData/v1/DailyForecast(2L)"",""type"":""DataGovUK.MetOfficeWeatherOpenData.DailyForecast""},""ID"":""2"",""SiteName"":""SOUTHAMPTON AIRPORT (3)"",""Country"":""ENGLAND"",""Continent"":""EUROPE"",""Date"":""\/Date(1322524800000)\/"",""TimeStep"":24,""WindDirectionDay"":9,""WindSpeedDay"":11,""ScreenTemperatureDay"":12,""ScreenTemperatureNight"":9,""RelativeHumidityDay"":74,""RelativeHumidityNight"":87,""VisibilityCodeDay"":""GO"",""VisibilityCodeNight"":""MO"",""FeelsLikeTemperatureDay"":10,""FeelsLikeTemperatureNight"":7}
            ]
        }
    }    
";
 
        public IEnumerable<WeatherData> Post([FromBody] string weatherData)
        {
            JObject jo = JObject.Parse(weatherData);
            WeatherData[] wData = jo.SelectToken("d.results", false).ToObject<WeatherData[]>();
            return wData;
        }
    }
}
