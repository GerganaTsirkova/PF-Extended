using System;
using System.Collections.Generic;
using System.Linq;

namespace _9.Code_Phoenix
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            var data = new Dictionary<string, List<string>>();
 
            while(true)
            {
                input = Console.ReadLine();
                if(input == "Blaze it!")
                {
                    break;
                }
                string[] tokens = input.Split(new string[]{ " -> " },StringSplitOptions.RemoveEmptyEntries).ToArray();
                string creature = tokens[0];
                string squadMate = tokens[1];
                if(creature==squadMate)
                {
                    continue;
                }
                if(!data.ContainsKey(creature))
                {
                    var inner = new List<string>();
                    inner.Add(squadMate);
                    data.Add(creature, inner);
                }
                else
                {
                    if(!data[creature].Contains(squadMate))
                    {
                        data[creature].Add(squadMate);
                    }
                }
            }
            if(data.Count>0)
            {
                foreach (var pair in data)
                {
                    for (int i = 0; i < pair.Value.Count ; i++)
                    {
                        if ((data.ContainsKey(pair.Value[i]) && (data[pair.Value[i]].Contains(pair.Key))))
                        {
                            data[pair.Value[i]].Remove(pair.Key);
                            data[pair.Key].Remove(pair.Value[i]);
                            i--;
                        }
                    }
                }
            }
            
            foreach (var item in data.OrderByDescending(x=>x.Value.Count()))
            {
                Console.WriteLine($"{item.Key} : {item.Value.Count}");
            }
        }
       
    }
}
