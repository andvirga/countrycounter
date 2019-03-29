using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using System.Linq;
using System.Threading.Tasks;

namespace CountriesCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type part of the country's name");
            var country = Console.ReadLine();
            Console.WriteLine("Type desired population. We'll search countries with bigger population that the entered");
            var population = Int32.Parse(Console.ReadLine());

            var countries = GetCountries(country, population);

            Console.WriteLine($"Countries starting with: '{country}' with population bigger than: {population}");
            Console.WriteLine($"Total: {countries.Count}");
            countries.ForEach(x => Console.WriteLine($"Name: {x.name} - Capital: {x.capital} - Population: {x.population}"));
            Console.ReadKey();
        }

        /// <summary>
        /// Gets the list of Countries which name contains specific characters and population is bigger than entered
        /// </summary>
        /// <param name="s">Specific Characters contained in Country's name</param>
        /// <param name="p">Population</param>
        /// <returns></returns>
        public static List<Country> GetCountries(string s, int p)
        {
            string url = $"https://jsonmock.hackerrank.com/api/countries/search?name={s}";

            var countries = SendRequest(url).Result;

            var filteredCountries = countries.Where(x => x.population > p).ToList();

            return filteredCountries;
        }

        public static async Task<List<Country>> SendRequest(string url)
        {
            try
            {
                var countries = new List<Country>();

                using (HttpClient client = new HttpClient())
                {
                    var response = client.GetAsync(url).Result;
                    var result = await response.Content.ReadAsStringAsync();

                    var json = JsonConvert.DeserializeObject<Countries>(result);
                    return json.data.ToList();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
