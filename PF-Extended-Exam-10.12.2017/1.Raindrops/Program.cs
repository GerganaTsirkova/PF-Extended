using System;
using System.Linq;

namespace _1.Raindrops
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal density = decimal.Parse(Console.ReadLine());
            decimal sum = 0;
            decimal finalResult = 0;
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] tokens = input.Split().ToArray();
                decimal raindrops = decimal.Parse(tokens[0]);
                decimal sqMeters = 0;
                if (tokens.Length == 2)
                {
                    sqMeters += decimal.Parse(tokens[1]);
                }
                if (sqMeters > 0)
                {
                    decimal result = raindrops / (decimal)sqMeters;
                    sum += result;
                }

            }
            if(density != 0)
            {
                finalResult += sum / density;
                Console.WriteLine($"{finalResult:f3}");
            }
            else
            {
                Console.WriteLine($"{sum:f3}");
            }
        }
    }
}
