using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.CitiesByContinentAndCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            var data = new Dictionary<string, Dictionary<string,List<string>>>();
            for (int i = 0; i < lines; i++)
            {
                string[] tokens = Console.ReadLine().Split().ToArray();
                string continent = tokens[0];
                string country = tokens[1];
                string city = tokens[2];
                if (!data.ContainsKey(continent))
                {
                    var listCities = new List<string>();
                    listCities.Add(city);
                    var innerDict = new Dictionary<string, List<string>>();
                    innerDict.Add(country, listCities);
                    data.Add(continent, innerDict);
                }
                else
                {
                    if(!data[continent].ContainsKey(country))
                    {
                        var listCities = new List<string>();
                        listCities.Add(city);
                        data[continent].Add(country, listCities);
                    }
                    else
                    {
                        data[continent][country].Add(city);
                    }
                }
            }
            foreach (var item in data)
            {
                Console.WriteLine($"{item.Key}:");
                foreach (var cont in item.Value)
                {
                    Console.WriteLine($" {cont.Key} -> {string.Join(", ", cont.Value)}");
                }
            }
        }
    }
}
