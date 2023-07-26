using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;
using System.Threading; // Add this namespace for Thread.Sleep()
using System.Runtime.Versioning;

namespace Weather_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string APIKey = "c37b7803d0ad8f484fabea797707bf9c";
        double lon;
        double lat;

        private void btn_search_Click(object sender, EventArgs e)
        {
            getWeather();
            getForecast();
        }

        void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", TBCity.Text, APIKey);
                var json = web.DownloadString(url);
                WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);
                pic_icon.ImageLocation = "https://openweathermap.org/img/wn/" + Info.weather[0].icon + ".png";
                lab_condtion.Text = Info.weather[0].main;
                lab_detail.Text = Info.weather[0].description;
                lab_sunset.Text = convertDateTime(Info.sys.sunset).ToString();
                lab_sunrise.Text = convertDateTime(Info.sys.sunrise).ToString();
                lab_windspeed.Text = Info.wind.speed.ToString();
                lab_pressure.Text = Info.main.pressure.ToString();

                double temperatureCelsius = ConvertKelvinToCelsius(Info.main.temp);
                labTemperature.Text = $"{temperatureCelsius}°C";

                // Determine the activity suggestion based on temperature
                string activitySuggestion = temperatureCelsius > 20 ? "Outdoor activity sounds great!" : "Better to plan indoor activities today!";
                labActivity.Text = activitySuggestion;


                lon = Info.coord.lon;
                lat = Info.coord.lat;

            }

            void getForecast()
            {
                using (WebClient web = new WebClient())
                {
                    string url = string.Format("https://api.openweathermap.org/data/2.5/onecall?lat={0}&lon={1}&exclude=current,hourly,alerts&appid={2}", lat, lon, APIKey);
                    var json = web.DownloadString(url);
                    WeatherForecast.ForecastInfo ForecastInfo = JsonConvert.DeserializeObject<WeatherForecast.ForecastInfo>(json);

                    ForecastUC FUC;
                    for (int i = 0; i < 8; i++)
                    {
                        FUC = new ForecastUC();
                        FUC.picWeatherIcon.ImageLocation = "http://openweathermap.org/img/w/" + ForecastInfo.daily[i].weather[0].icon + ".png";
                        FUC.labMainWeather.Text = ForecastInfo.daily[i].weather[0].main;
                        FUC.labWeatherDescription.Text = ForecastInfo.daily[i].weather[0].decription;
                        FUC.labDT.Text = convertDateTime(ForecastInfo.daily[i].dt).DayOfWeek.ToString();

                        FLP.Controls.Add(FUC);
                    }
                }
            }

            double ConvertKelvinToCelsius(double kelvin)
            {
                return kelvin - 273.15;
            }

            DateTime convertDateTime(long sec)
            {
                DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
                day = day.AddSeconds(sec).ToLocalTime();

                return day;
            }



        }
       
        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
               


        private void FLP_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}