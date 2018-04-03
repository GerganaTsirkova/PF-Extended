using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.Entertraining
{
    class Program
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            List<int> wagons = new List<int>();
            int totalWeight = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "All ofboard!")
                {
                    break;
                }
                int wagonWeight = int.Parse(input);
                totalWeight += wagonWeight;
                wagons.Add(wagonWeight);
                if(totalWeight>power)
                {
                    int average = wagons.Sum()/wagons.Count;
                    int closest = wagons.OrderBy(item => Math.Abs(average - item)).First();
                    wagons.Remove(closest);
                }
            }
            wagons.Reverse();
            wagons.Add(power);
            Console.WriteLine(string.Join(" ",wagons));
        }
    }
}
