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

            Dictionary<string, City> cities = csvReader.ReadAllCities();
            Console.WriteLine("Which city code do you want to search for?");
            string userInput = Console.ReadLine();
            bool getCity = cities.TryGetValue(userInput, out City city);
            if (!getCity)
                Console.WriteLine($"There is no city with code, {userInput}");
            else
                Console.WriteLine($"{city.TotalPopulation:### ### ###} : {city.CityCode} : {city.CityName}");
        }
    }
}
