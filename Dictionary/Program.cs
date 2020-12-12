using CSharpCollection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            City slaskie = new City("Slaskie", "SLA", "Polska", 4524091, 2180662, 2343429);
            City malopolskie = new City("Malopolskie", "MLP", "Polska", 3404863, 1652663, 1752200);
            //List<City> cities = new List<City>();
            
            var cities = new Dictionary<string, City>();
            cities.Add(slaskie.CityCode, slaskie);
            cities.Add(malopolskie.CityCode, malopolskie);

            var searchedCity = cities.TryGetValue("WLK", out City city);
            if (searchedCity)
               Console.WriteLine(city.CityName);
            else
                Console.WriteLine("There is no city with this code");

            cities.Remove(malopolskie.CityCode);

            cities[slaskie.CityCode] = malopolskie;
            bool exist = cities.ContainsKey(slaskie.CityCode);
            Console.WriteLine(exist);

            foreach (var city2 in cities.Values)
            {
                Console.WriteLine(city2.CityName);
            }

        }
    }
}
