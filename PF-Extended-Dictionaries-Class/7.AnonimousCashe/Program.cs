using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.AnonimousCashe
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Dictionary <string, Dictionary<string, long>>();
            var cache = new Dictionary<string, Dictionary<string, long>>();
            string input = Console.ReadLine();
            while(input != "thetinggoesskrra")
            {
                string[] tokens = input.Split(new string[] { " -> "," | "}, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if(tokens.Length==1)
                {
                    string dataSet = tokens[0];
                    if (!data.ContainsKey(tokens[0]))
                    {
                        var inner = new Dictionary<string, long>();
                        data.Add(dataSet, inner);
                        if (cache.ContainsKey(dataSet))
                        {

                            foreach (var item in cache[dataSet])
                            {
                                string str = item.Key;
                                long n = item.Value;
                                data[dataSet].Add(str, n);
                            }
                        }
                    }
                }
                else
                {
                    string dataSet = tokens[2];
                    string dataKey = tokens[0];
                    long num = long.Parse(tokens[1]);
                    if(!data.ContainsKey(dataSet))
                    {
                        if(!cache.ContainsKey(dataSet))
                        {
                            var inner = new Dictionary<string, long>();
                            inner.Add(dataKey, num);
                            cache.Add(dataSet, inner);
                        }
                        else
                        {
                            cache[dataSet].Add(dataKey,num);
                        }
                        
                    }
                    else
                    {
                        data[dataSet].Add(dataKey, num);
                    }
                }
                input = Console.ReadLine();
            }
            if(data.Count>0)
            {
                foreach (var item in data.OrderByDescending(x => x.Value.Sum(y => y.Value)))
                {
                    Console.WriteLine($"Data Set: {item.Key}, Total Size: {item.Value.Sum(x => x.Value)}");
                    foreach (var i in item.Value)
                    {
                        Console.WriteLine($"$.{i.Key}");
                    }
                    break;
                }
            }
        }
    }
}
