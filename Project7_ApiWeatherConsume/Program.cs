#region Menü_Başlangıcı



using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;
using System.Text.Json.Nodes;
using static System.Net.WebRequestMethods;

Console.WriteLine("Api Consume İşlemine Hoş Geldiniz");
Console.WriteLine();
Console.WriteLine("### Yapmak İstediğiniz İşlemi Seçin ###");
Console.WriteLine();
Console.WriteLine("1-Şehir Listesini Getirin");
Console.WriteLine("2-Şehir ve Hava Durumu Listesini Getirin");
Console.WriteLine("3-Yeni Şehir Ekleme");
Console.WriteLine("4-Şehir Silme İşlemi");
Console.WriteLine("5-Şehir Güncelleme İşlemi");
Console.WriteLine("6-ID'ye Göre Şehir Getirme");
Console.WriteLine();

#endregion


string number;

Console.Write("Tercihiniz: ");
number = Console.ReadLine();
Console.WriteLine();

if (number == "1")
{
    string url = "https://localhost:7232/api/Weathers";
    using (HttpClient client = new HttpClient())
    {
        HttpResponseMessage response = await client.GetAsync(url);
        string responseBody = await response.Content.ReadAsStringAsync();
        JArray jArray = JArray.Parse(responseBody);
        foreach(var item in jArray)
        {
            string cityName = item["cityName"].ToString();
            Console.WriteLine($"Şehir: {cityName}");
        }
    }
}

if(number == "2")
{
    string url = "https://localhost:7232/api/Weathers";
    using (HttpClient client = new HttpClient())
    {
        HttpResponseMessage response= await client.GetAsync(url);
        string responseBody = await response.Content.ReadAsStringAsync();
        JArray jArray= JArray.Parse(responseBody);
        foreach (var item in jArray)
        {
            string cityName = item["cityName"].ToString();
            string temp = item["temp"].ToString();
            string country = item["country"].ToString();
            Console.WriteLine(cityName + "-" + country + "-->"+ temp + "Derece");
            Console.WriteLine("---------------------------------------------------"); 
        }

    } 
    
}

if(number == "3")
{
    Console.WriteLine("#### Yeni Veri Girişi #####");
    Console.WriteLine();
    string cityName, country, detail; 
    decimal temp;

    Console.Write("Şehir Adı: ");
    cityName=Console.ReadLine();

    Console.Write("Ülke Adı: ");
    country=Console.ReadLine();

    Console.Write("Hava durumu detayı: ");
    detail=Console.ReadLine();

    Console.Write("Sıxaklık: ");
    temp = decimal.Parse(Console.ReadLine());


    string url = " https://localhost:7232/api/Weathers";
    var newWeatherCity = new
    {
        CityName = cityName,
        Country = country,
        Detail = detail,
        Temp = temp
    };
    using(HttpClient client = new HttpClient())
    {
        string json = JsonConvert.SerializeObject(newWeatherCity);
        StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
        HttpResponseMessage response= await client.PostAsync(url, content);
        response.EnsureSuccessStatusCode();
       
    }

}

if(number == "4")
{
    string url = " https://localhost:7232/api/Weathers";

    Console.WriteLine("Silmek istediğiniz Id değeri: ");
    int id = int.Parse(Console.ReadLine());

    using(HttpClient client = new HttpClient())
    {
        HttpResponseMessage response= await client.DeleteAsync(url + id);
        response.EnsureSuccessStatusCode();
    }

}

if(number == "5")
{
    string url = " https://localhost:7232/api/Weathers";

    Console.WriteLine("#### Veri Güncelleme #####");
    Console.WriteLine();
    string cityName, country, detail;
    decimal temp;
    int cityId;

    Console.Write("Şehir Adı: ");
    cityName = Console.ReadLine();

    Console.Write("Ülke Adı: ");
    country = Console.ReadLine();

    Console.Write("Hava durumu detayı: ");
    detail = Console.ReadLine();

    Console.Write("Sıxaklık: ");
    temp = decimal.Parse(Console.ReadLine());

    Console.Write("Şehir Id: ");
    cityId=int.Parse(Console.ReadLine());

    var updatetedWeatherValues = new
    {
        CityId = cityId,
        CityName = cityName,
        Country = country,
        Detail = detail,
        Temp = temp
    };

    using (HttpClient client = new HttpClient())
    {
        string json = JsonConvert.SerializeObject(updatetedWeatherValues);
        StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
        HttpResponseMessage response = await client.PutAsync(url, content);
        response.EnsureSuccessStatusCode();
    }




}

if(number == "6")
{
    string url = " https://localhost:7232/api/Weathers";
    Console.WriteLine("Bilgilerini getirmek istediğiniz Id değeri: ");
    int id= int.Parse(Console.ReadLine());

    using (HttpClient client = new HttpClient())
    {
        HttpResponseMessage response = await client.GetAsync(url + id);
        response.EnsureSuccessStatusCode();
        string responseBody = await response.Content.ReadAsStringAsync();
        JObject weatherCityObject = JObject.Parse(responseBody);

        string cityName = weatherCityObject["cityName"].ToString();
        string detail = weatherCityObject["detail"].ToString();
        string country = weatherCityObject["country"].ToString();
        decimal temp = decimal.Parse(weatherCityObject["temp"].ToString());

        Console.WriteLine( "Girmiş olduğunuz Id değerine ait bilgiler");
        Console.WriteLine();
        Console.Write("Şehir: "+ cityName+ "Ülke: "+ country+ "Detay: "+ detail+ "Derece: "+ temp);
    }
}


Console.Read();
