using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.TrainLands
{
    class Program
    {
        static void Main(string[] args)
        {
            var trains = new Dictionary<string, Dictionary<string, int>>();
            while(true)
            {
                string input = Console.ReadLine();
                if(input == "It's Training Men!")
                {
                    break;
                }
                string[] tokens = input.Split().ToArray();
                if(tokens.Length==5)
                {
                    string trainName = tokens[0];
                    string wagonName = tokens[2];
                    int power = int.Parse(tokens[4]);
                    if(!trains.ContainsKey(trainName))
                    {
                        var inner = new Dictionary<string, int>();
                        inner.Add(wagonName, power);
                        trains.Add(trainName, inner);
                    }
                    else
                    {
                        if(!trains[trainName].ContainsKey(wagonName))
                        {
                            trains[trainName].Add(wagonName, power);
                        }
                    }
                }
                else if(tokens.Length==3)
                {
                    string trainName = tokens[0];
                    string otherTrainName = tokens[2];
                    if (tokens[1]=="->")
                    {
                        if(trains.ContainsKey(trainName))
                        {
                            foreach (var item in trains[otherTrainName])
                            {
                                trains[trainName].Add(item.Key, item.Value);
                            }
                            trains.Remove(otherTrainName);
                        }
                        else
                        {
                            var inner = new Dictionary<string, int>();
                            trains.Add(trainName, inner);
                            foreach (var item in trains[otherTrainName])
                            {
                                trains[trainName].Add(item.Key, item.Value);
                            }
                            trains.Remove(otherTrainName);
                        }

                    }
                    else if(tokens[1]=="=")
                    {
                        if (trains.ContainsKey(trainName))
                        {
                            trains.Remove(trainName);
                            var inner = new Dictionary<string, int>();
                            trains.Add(trainName, inner);
                            foreach (var item in trains[otherTrainName])
                            {
                                trains[trainName].Add(item.Key, item.Value);
                            }
                        }
                        else
                        {
                            var inner = new Dictionary<string, int>();
                            trains.Add(trainName, inner);
                            foreach (var item in trains[otherTrainName])
                            {
                                trains[trainName].Add(item.Key, item.Value);
                            }
                        }
                    }
                }
            }
            foreach (var train in trains.OrderByDescending(x=>trains[x.Key].Values.Sum()).ThenBy(y=>trains[y.Key].Values.Count))
            {
                Console.WriteLine($"Train: {train.Key}");
                foreach (var wagon in train.Value.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"###{wagon.Key} - {wagon.Value}");
                }
            }
        }
    }
}
