using CSharpCollection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithList
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\skyli\source\repos\CSharpCollection\CSharpCollection\rezydenci_2019.csv";

            CSVReader csvReader = new CSVReader(filePath);

            List<City> cities = csvReader.ReadAllCities();
            csvReader.RemoveTestCities(cities);
            Console.WriteLine("Enter how many cities you want to display: ");
            bool inputIsInt = int.TryParse(Console.ReadLine(), out int userInput);
            if (!inputIsInt || userInput <= 0)
            {
                Console.WriteLine("You must enter a positive integer!");
                return;
            }
            int maxToDisplay = userInput;
            for (int i = 0; i < cities.Count; i++)
            {
               // int displayIndex = cities.Count - 1 - i;
                if (i > 0 &&(i % maxToDisplay == 0))
                {
                    Console.WriteLine("Hit return to continue, anything else to quite: ");
                    if (Console.ReadLine() != "")
                        break;                    
                }
                City city = cities[i];
                Console.WriteLine($"{i + 1} - {city.TotalPopulation:### ### ###} : {city.CityCode} : {city.CityName}");
            }
        }
    }
}
