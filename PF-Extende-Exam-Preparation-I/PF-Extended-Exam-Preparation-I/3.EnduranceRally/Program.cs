using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.EnduranceRally
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] racers = Console.ReadLine().Split().ToArray();
            decimal[] layouts = Console.ReadLine().Split().Select(decimal.Parse).ToArray();
            int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var myList = new List<string>();
            foreach (var racer in racers)
            {
                decimal fuel = (int)racer[0];
                string message = "";
                for (int i = 0; i < layouts.Length; i++)
                {
                    if(indexes.Contains(i))
                    {
                        fuel += layouts[i];
                    }
                    else
                    {
                        fuel -= layouts[i];
                    }
                    if(fuel<=0)
                    {
                        message = $"{racer} - reached {i}";
                        break;
                    }
                    if((fuel>0)&&(i==layouts.Length-1))
                    {
                        message = $"{racer} - fuel left {fuel:f2}";
                    }
                }
                myList.Add(message);
            }
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
