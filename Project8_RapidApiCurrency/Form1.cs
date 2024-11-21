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

namespace Project8_RapidApiCurrency
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        decimal dolar = 0;
        decimal euro = 0;
        decimal sterlin = 0;


        private async void Form1_Load(object sender, EventArgs e)
        {

            #region Dolar

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://currency-conversion-and-exchange-rates.p.rapidapi.com/convert?from=USD&to=TRY&amount=1"),
                Headers =
    {
        { "x-rapidapi-key", "86bed023a1msha96b65a046a178bp1189f2jsnb705daedc9ab" },
        { "x-rapidapi-host", "currency-conversion-and-exchange-rates.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var json = JObject.Parse(body);
                var value = json["result"].ToString();
                lblDolar.Text = value;
                dolar = decimal.Parse(value);
                //Console.WriteLine(body);
            }

            #endregion


            #region Euro

            var client2 = new HttpClient();
            var request2 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://currency-conversion-and-exchange-rates.p.rapidapi.com/convert?from=EUR&to=TRY&amount=1"),
                Headers =
    {
        { "x-rapidapi-key", "86bed023a1msha96b65a046a178bp1189f2jsnb705daedc9ab" },
        { "x-rapidapi-host", "currency-conversion-and-exchange-rates.p.rapidapi.com" },
    },
            };
            using (var response2 = await client2.SendAsync(request2))
            {
                response2.EnsureSuccessStatusCode();
                var body2 = await response2.Content.ReadAsStringAsync();
                var json2 = JObject.Parse(body2);
                var value = json2["result"].ToString();
                lblEuro.Text = value;
                euro = decimal.Parse(value);
                //Console.WriteLine(body);
            }


            #endregion


            #region  Sterlin

            var client3 = new HttpClient();
            var request3 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://currency-conversion-and-exchange-rates.p.rapidapi.com/convert?from=GBP&to=TRY&amount=1"),
                Headers =
    {
        { "x-rapidapi-key", "86bed023a1msha96b65a046a178bp1189f2jsnb705daedc9ab" },
        { "x-rapidapi-host", "currency-conversion-and-exchange-rates.p.rapidapi.com" },
    },
            };
            using (var response3 = await client3.SendAsync(request3))
            {
                response3.EnsureSuccessStatusCode();
                var body3 = await response3.Content.ReadAsStringAsync();
                var json3 = JObject.Parse(body3);
                var value = json3["result"].ToString();
                lblSterlin.Text = value;
                sterlin = decimal.Parse(value);
                //Console.WriteLine(body);
            }

            #endregion

            txtTotalPrice.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal unitPrice=decimal.Parse(txtUnitPrice.Text);
            decimal totalPrice = 0;


            if (rdbDolar.Checked)
            {
                totalPrice = unitPrice * dolar;
            }
            if(rdbEuro.Checked)
            {
                totalPrice = unitPrice * dolar;
            }
            if (rdbSterlin.Checked)
            {
                totalPrice = unitPrice * sterlin;
            }

            txtTotalPrice.Text = totalPrice.ToString();
        }
    }
}
