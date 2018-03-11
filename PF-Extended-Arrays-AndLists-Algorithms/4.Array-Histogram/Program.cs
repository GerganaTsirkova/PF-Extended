using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.Array_Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            Dictionary<string,Dictionary<int,double>> myDict = new Dictionary<string,Dictionary<int,double>>();
            for (int i = 0; i < input.Length; i++)
            {
                string current = input[i];
                int counter = 1;
                for (int j = i+1; j < input.Length; j++)
                {
                    if(current==input[j])
                    {
                        counter++;
                    }
                }
                double percent = (counter / (double)input.Length) * 100;
                if(!myDict.ContainsKey(current))
                {
                    Dictionary<int, double> inner = new Dictionary<int, double>();
                    myDict.Add(current, inner);
                    if(!myDict[current].ContainsKey(counter))
                    {
                        myDict[current].Add(counter, percent);
                    }
                }
                else
                {
                    continue;
                }
            }
            foreach (var str in myDict.OrderByDescending(x => x.Value.Keys.First()))
            {
                Console.Write($"{str.Key} -> ");
                foreach (var s in str.Value)
                {
                    Console.WriteLine($"{s.Key} times ({s.Value:f2}%)");
                }
            }
        }
    }
}
