using ServiceRepo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Configuration;
using Newtonsoft.Json;
namespace Core.CovidDataLayer
{
    public static class GetCovidData
    {
        static readonly HttpClient client = new HttpClient();
        static readonly string covidDataUrl = "https://api.covid19api.com/summary";//TODO:will have to get this from appsettings
       public static async Task<CovidSummary> GetData()
        {
            CovidSummary covidSummary = new CovidSummary();
            // Call asynchronous network methods in a try/catch block to handle exceptions.
            try
            {
                HttpResponseMessage response = await client.GetAsync(covidDataUrl);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                covidSummary = Newtonsoft.Json.JsonConvert.DeserializeObject<CovidSummary>(responseBody);
                // Above three lines can be replaced with new helper method below
                // string responseBody = await client.GetStringAsync(uri);

                Console.WriteLine(responseBody);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
            return covidSummary;
        }
    }
}
