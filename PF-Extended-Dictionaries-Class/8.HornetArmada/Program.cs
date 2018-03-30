using System;
using System.Collections.Generic;
using System.Linq;

namespace _8.HornetArmada
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var data = new Dictionary<string, Dictionary<string, long>>();
            var dataNum = new Dictionary<string, long>();
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(new char[] { '=',':','-','>',' '},StringSplitOptions.RemoveEmptyEntries).ToArray();
                string legionName = tokens[1];
                long activity = long.Parse(tokens[0]);
                string soldierType = tokens[2];
                long soldierCount = long.Parse(tokens[3]);
                if(!data.ContainsKey(legionName))
                {
                    var inner = new Dictionary<string, long>();
                    inner.Add(soldierType, soldierCount);
                    data.Add(legionName, inner);
                    if(!dataNum.ContainsKey(legionName))
                    {
                        dataNum.Add(legionName, activity);
                    }
                    else
                    {
                        if(activity>dataNum[legionName])
                        {
                            dataNum[legionName] = activity;
                        }
                    }
                }
                else
                {
                    if(!data[legionName].ContainsKey(soldierType))
                    {
                        data[legionName].Add(soldierType, soldierCount);
                    }
                    else
                    {
                        data[legionName][soldierType] += soldierCount;
                    }
                    if (!dataNum.ContainsKey(legionName))
                    {
                        dataNum.Add(legionName, activity);
                    }
                    else
                    {
                        if (activity > dataNum[legionName])
                        {
                            dataNum[legionName] = activity;
                        }
                    }
                }
            }
            string[] command = Console.ReadLine().Split('\\').ToArray();
            if(command.Length==1)
            {
                string soldierType = command[0];
                foreach (var legion in dataNum.OrderByDescending(x=>x.Value))
                {
                    if(data[legion.Key].ContainsKey(soldierType))
                    {
                        Console.WriteLine($"{legion.Value} : {legion.Key}");
                    }
                }
            }
            else if(command.Length==2)
            {
                long activity = long.Parse(command[0]);
                string soldierType = command[1];
                foreach (var item in data.Where(x=>x.Value.ContainsKey(soldierType)).OrderByDescending(x => x.Value[soldierType]))
                {
                    if ((data[item.Key].ContainsKey(soldierType))&&(dataNum[item.Key]<activity))
                    {
                        Console.WriteLine($"{item.Key} -> {data[item.Key][soldierType]}");
                    }
                }
            }
        }
    }
}
