using System;
using System.Collections.Generic;
using System.Linq;

namespace _12._Forcebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, List<int>>();
            string input = Console.ReadLine();

            while (input != "I believe I can fly!")
            {
                string[] tokens = input.Split().ToArray();
                if(tokens[1] != "=")
                {
                    string name = tokens[0];
                    var inner = new List<int>();
                    for (int i = 1; i < tokens.Length; i++)
                    {
                        inner.Add(int.Parse(tokens[i]));
                    }
                    if(!dict.ContainsKey(name))
                    {
                        dict.Add(name, inner);
                    }
                    else
                    {
                        foreach (var item in inner)
                        {
                            dict[name].Add(item);
                        }
                    }
                }
                else if(tokens[1] == "=")
                {
                    string firstCustomer = tokens[0];
                    string seconCustomer = tokens[2];
                    if (!dict.ContainsKey(firstCustomer))
                    {
                        var inner = new List<int>();
                        foreach (var flight in dict[seconCustomer])
                        {
                            inner.Add(flight);
                        }
                        dict.Add(firstCustomer, inner);
                    }
                    else
                    {
                        dict.Remove(firstCustomer);
                        var inner = new List<int>();
                        foreach (var flight in dict[seconCustomer])
                        {
                            inner.Add(flight);
                        }
                        dict.Add(firstCustomer, inner);
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var flight in dict.OrderByDescending(x=>x.Value.Count).ThenBy(y=>y.Key))
            {
                Console.Write($"#{flight.Key} ::: ");
                int counter = 0;
                foreach (var item in flight.Value.OrderBy(x=>x))
                {
                    if (counter == flight.Value.Count-1)
                    {
                        Console.WriteLine(item);
                    }
                    else
                    {
                        Console.Write(item + ", ");
                        counter++;
                    }
                }
            }
        }
    }
}
