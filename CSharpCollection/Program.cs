using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\skyli\source\repos\CSharpCollection\CSharpCollection\rezydenci_2019.csv";

            CSVReader csvReader = new CSVReader(filePath);

            List<City> cities = csvReader.ReadAllCities();
            City cityTest = new City("Sosnowiec", "SOS", "Polska", 3000000, 1600000, 1400000);
            int index = cities.FindIndex(city => city.TotalPopulation < 3000000);
            cities.Insert(index, cityTest);
            //cities.Remove(cityTest);

            foreach (var city in cities)
            {
                Console.WriteLine($"{city.TotalPopulation:### ### ###} : {city.CityCode} : {city.CityName}");
            }
            Console.WriteLine($"{cities.Count} cities");
        }
    }
}
