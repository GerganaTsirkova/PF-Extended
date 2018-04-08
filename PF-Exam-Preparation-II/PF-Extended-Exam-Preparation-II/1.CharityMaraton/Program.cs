using System;
using System.Numerics;

namespace _3.RoliTheCoder
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenMaraton = int.Parse(Console.ReadLine());
            long numberRunners = long.Parse(Console.ReadLine());
            int numberLaps = int.Parse(Console.ReadLine());
            long lenTrack = long.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            decimal moneyPerKilometer = decimal.Parse(Console.ReadLine());
            if (capacity*lenMaraton < numberRunners)
            {
                numberRunners = capacity*lenMaraton;
            }
            BigInteger totalMeters = numberRunners * numberLaps * lenTrack;
            decimal totalKilometers = (decimal)(totalMeters/ 1000);
            decimal money = totalKilometers * moneyPerKilometer;
            Console.WriteLine($"Money raised: {money:f2}");
        }
    }
}
