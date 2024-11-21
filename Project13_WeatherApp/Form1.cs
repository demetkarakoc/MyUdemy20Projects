using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project13_WeatherApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
          
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://open-weather13.p.rapidapi.com/city/İzmir/EN"),
                Headers =
    {
        { "x-rapidapi-key", "86bed023a1msha96b65a046a178bp1189f2jsnb705daedc9ab" },
        { "x-rapidapi-host", "open-weather13.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                response.EnsureSuccessStatusCode();
                var json = JObject.Parse(body);
                var fahrenheit = json["main"]["feels_like"].ToString();
                var windSpeed = json["wind"]["speed"].ToString();
                var humidity = json["main"]["humidity"].ToString();
                lblFahrenheit.Text=fahrenheit;
                lblHumidity.Text=humidity;
                lblWindSpeed.Text=windSpeed;
                decimal celsius = (decimal.Parse(fahrenheit) - 32) / (9 / 5);
                lblCelsius.Text = celsius.ToString();              

            }
        }
    }
}
