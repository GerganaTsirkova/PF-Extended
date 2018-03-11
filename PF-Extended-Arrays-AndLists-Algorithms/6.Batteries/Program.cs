using System;
using System.Linq;

namespace _6.Batteries
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] batteryCapacity = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double[] usagePerHour = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            int hoursTest = int.Parse(Console.ReadLine());
            for (int i = 0; i < batteryCapacity.Length; i++)
            {
                double restBattery = batteryCapacity[i] - usagePerHour[i] * hoursTest;
                double hoursLast = Math.Ceiling(batteryCapacity[i]/usagePerHour[i]);
                double percentBatteryLeft = (restBattery / batteryCapacity[i]) * 100;
                if (restBattery<=0)
                {
                    Console.WriteLine($"Battery {i+1}: dead (lasted {hoursLast} hours)");
                }
                else
                {
                    Console.WriteLine($"Battery {i+1}: {restBattery:f2} mAh ({percentBatteryLeft:f2})%");
                }
            }
        }
    }
}
