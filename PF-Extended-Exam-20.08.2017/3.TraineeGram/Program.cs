using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _3.TraineeGram
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var trains = new List<string>();
            while(input != "Traincode!")
            {
                string pattern = @"^(\<\[([^A-Za-z0-9]+)*\]\.)(\.\[([A-Za-z0-9]+)*\]\.)*" + "$";
                var match = Regex.Match(input, pattern);
                if(match.Success)
                {
                    trains.Add(input);
                }
                input = Console.ReadLine();
            }
            if(trains.Count==0)
            {
                Console.WriteLine();
            }
            for (int i = 0; i < trains.Count; i++)
            {
                Console.WriteLine(trains[i]);
            }
        }
    }
}
