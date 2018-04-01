using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.Trainlands
{
    class Program
    {
        static void Main(string[] args)
        {
            var trains = new Dictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();
            while (input != "It's Training Men!")
            {
                string[] token = input.Split().ToArray();
                int len = token.Length;
                if (len == 3)
                {
                    string trainName = token[0];
                    string otherTrainName = token[2];
                    if (token[1] == "->")
                    {
                        if (trains.ContainsKey(trainName))
                        {
                            foreach (var pair in trains[otherTrainName])
                            {
                                trains[trainName].Add(pair.Key, pair.Value);
                            }
                            trains.Remove(otherTrainName);
                        }
                        else
                        {
                            var inner = new Dictionary<string, int>();
                            trains.Add(trainName, inner);
                            foreach (var pair in trains[otherTrainName])
                            {
                                trains[trainName].Add(pair.Key, pair.Value);
                            }
                            trains.Remove(otherTrainName);
                        }
                    }
                    else if (token[1] == "=")
                    {
                        if (trains.ContainsKey(trainName))
                        {
                            trains.Remove(trainName);
                            var inner = new Dictionary<string, int>();
                            trains.Add(trainName, inner);
                            foreach (var pair in trains[otherTrainName])
                            {
                                trains[trainName].Add(pair.Key, pair.Value);
                            }
                        }
                        else
                        {
                            var inner = new Dictionary<string, int>();
                            trains.Add(trainName, inner);
                            foreach (var pair in trains[otherTrainName])
                            {
                                trains[trainName].Add(pair.Key, pair.Value);
                            }
                        }
                    }
                }
                else if (len == 5)
                {
                    string trainName = token[0];
                    string wagonName = token[2];
                    int wagonPower = int.Parse(token[4]);
                    if (!trains.ContainsKey(trainName))
                    {
                        var inner = new Dictionary<string, int>();
                        inner.Add(wagonName, wagonPower);
                        trains.Add(trainName, inner);
                    }
                    else
                    {
                        trains[trainName].Add(wagonName, wagonPower);
                    }
                }
                input = Console.ReadLine();

            }
            foreach (var train in trains.OrderByDescending(x => trains[x.Key].Values.Sum()).ThenBy(x => trains[x.Key].Count))
            {
                Console.WriteLine($"Train: {train.Key}");
                foreach (var wagon in train.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"###{wagon.Key} - {wagon.Value}");
                }
            }
        }
    }
}
