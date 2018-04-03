using System;

namespace _1.SplinterTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal distance = decimal.Parse(Console.ReadLine());
            decimal tankCapacity = decimal.Parse(Console.ReadLine());
            decimal milesHeavyWinds = decimal.Parse(Console.ReadLine());
            decimal milesInNonHeavyWinds = distance - milesHeavyWinds;
            decimal totalNeededFuel = (milesInNonHeavyWinds * 25 + milesHeavyWinds * (decimal)37.5) + (milesInNonHeavyWinds * 25 + milesHeavyWinds * (decimal)37.5) * (decimal)0.05;
            Console.WriteLine($"Fuel needed: {totalNeededFuel:f2}L");
            if(tankCapacity-totalNeededFuel>=0)
            {
                Console.WriteLine($"Enough with {(tankCapacity-totalNeededFuel):f2}L to spare!");
            }
            else
            {
                Console.WriteLine($"We need {Math.Abs(tankCapacity - totalNeededFuel):f2}L more fuel.");
            }
            
        }
    }
}
