using System;
using System.Linq;
using System.Numerics;

namespace _1.SinoTheWalker
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime timeLeaves = DateTime.Parse(Console.ReadLine());//reading a given hour from the console
            int numberSteps = int.Parse(Console.ReadLine())%86400;//one day contains 86400 seconds
            int timeForEachStep = int.Parse(Console.ReadLine())%86400;//we take the days in case we are given big integers
            double timeNeeded = numberSteps * timeForEachStep;
            DateTime result = timeLeaves.AddSeconds(timeNeeded);//Adding to given hour the seconds we count and making the new hour
            Console.WriteLine("Time Arrival: {0:HH:mm:ss}", result);
        }
    }
}
