using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _4.NSA
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var dict = new Dictionary<string, Dictionary<string, int>>();
            while(input != "quit")
            {
                string[] token = input.Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                int days = int.Parse(token[2]);
                string patternCountry = @"[A-Za-z0-9]+";
                var match = Regex.Match(token[0], patternCountry);
                if(match.Success)
                {
                    string patternSpy = @"[A-Za-z0-9]+";
                    var mat = Regex.Match(token[1], patternSpy);
                    if(mat.Success)
                    {
                        string country = match.ToString();
                        string spy = mat.ToString();
                        if (!dict.ContainsKey(country))
                        {
                            var inner = new Dictionary<string, int>();
                            inner.Add(spy, days);
                            dict.Add(country, inner);
                        }
                        else if (dict.ContainsKey(country))
                        {
                            if(!dict[country].ContainsKey(spy))
                            {
                                dict[country].Add(spy, days);
                            }
                            else
                            {
                                dict[country][spy] = days;
                            }
                        }
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var country in dict.OrderByDescending(x=>x.Value.Count))
            {
                Console.WriteLine($"Country: {country.Key}");
                foreach (var sp in country.Value.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"**{sp.Key} : {sp.Value}");
                }
            }
        }
    }
}
