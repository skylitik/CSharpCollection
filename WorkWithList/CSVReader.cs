using System.Collections.Generic;
using System.IO;
namespace CSharpCollection
{
    public class CSVReader
    {
        private string _csvFilePath;

        public CSVReader(string csvFilePath)
        {
            _csvFilePath = csvFilePath;
        }

        public List<City> ReadAllCities()
        {
            List<City> cities = new List<City>();
            using (StreamReader streamReader = new StreamReader(_csvFilePath))
            {
                //read header line
                streamReader.ReadLine();
                string csvLine;
                while ((csvLine = streamReader.ReadLine()) != null)
                {
                    cities.Add(ReadCityFromCsvLine(csvLine));
                    
                }
            }
            return cities;
        }
        public City ReadCityFromCsvLine(string csvLine)
        {
            string[] parts = csvLine.Split(new char[] { ',' });

            string cityName = parts[0];
            string cityCode = parts[1];
            string country = parts[2];
            int totalPopulation = int.Parse(parts[3]);
            int menPopulation = int.Parse(parts[4]);
            int womenPopulation = int.Parse(parts[5]);
            return new City(cityName, cityCode, country, totalPopulation, menPopulation, womenPopulation);
        }

        public void RemoveTestCities(List<City> cities)
        {
            for (int i = cities.Count - 1; i >= 0; i--)
            {
                if (cities[i].CityName.Contains("Test"))
                    cities.RemoveAt(i);                
            }
        }
    }
}
