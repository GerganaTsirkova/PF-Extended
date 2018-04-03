using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numParticipants = int.Parse(Console.ReadLine());
            var dict = new Dictionary<string, decimal>();
            for (int i = 0; i < numParticipants; i++)
            {
                decimal distanceInMiles = decimal.Parse(Console.ReadLine());
                decimal distanceInMeters = distanceInMiles * 1600;
                decimal tonsCarg = decimal.Parse(Console.ReadLine());
                decimal kilogramsCargo = tonsCarg * 1000;
                string team = Console.ReadLine();
                decimal fuelConsumption = (decimal)0.7 * distanceInMeters * (decimal)2.5;
                decimal cargoIncome = kilogramsCargo * (decimal)1.5;
                decimal moneyEarned = cargoIncome-fuelConsumption;
                if(!dict.ContainsKey(team))
                {
                    if((distanceInMeters==0)||(kilogramsCargo==0))
                    {
                        dict.Add(team, 0M);
                    }
                    else
                    {
                        dict.Add(team, moneyEarned);
                    }
                }
                else
                {
                    dict[team] += moneyEarned;
                }
            }
            if((dict.Count>0)||(numParticipants>0))
            {
                foreach (var item in dict.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"The {item.Key} Trainers win with ${item.Value:f3}.");
                    break;
                }
            }
        }
    }
}
