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

            City[] cities = csvReader.ReadFirstNCities(7);

            foreach (var city in cities)
            {
                Console.WriteLine($"{city.TotalPopulation:### ### ###} : {city.CityCode} : {city.CityName}");
            }
           
        }
    }
}
