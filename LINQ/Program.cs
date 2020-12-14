using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\skyli\source\repos\CSharpCollection\CSharpCollection\rezydenci_2019.csv";

            CSVReader csvReader = new CSVReader(filePath);

            List<City> cities = csvReader.ReadAllCities();
            
            foreach (var city in cities.Where(c => !c.CityName.Contains("Test")).Take(10))
            {
                Console.WriteLine($"{city.TotalPopulation:### ### ###} : {city.CityCode} : {city.CityName}");
            }
        }
    }
}
