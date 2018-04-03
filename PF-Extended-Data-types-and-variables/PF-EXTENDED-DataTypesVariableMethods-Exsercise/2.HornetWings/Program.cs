using System;

namespace _1.Hornet_Wings
{
    class Program
    {
        static void Main(string[] args)
        {
            int wingFlaps = int.Parse(Console.ReadLine());
            double metersPerThousandFlaps = double.Parse(Console.ReadLine());
            int endurance = int.Parse(Console.ReadLine());
            double metersTraveled = wingFlaps / 1000 * metersPerThousandFlaps;
            int secondsPassed = (wingFlaps / endurance) * 5 + (wingFlaps / 100);
            Console.WriteLine($"{metersTraveled:f2} m.");
            Console.WriteLine($"{secondsPassed} s.");
        }
    }
}
