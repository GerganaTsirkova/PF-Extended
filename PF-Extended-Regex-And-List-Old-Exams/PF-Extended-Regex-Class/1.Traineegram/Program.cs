using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _1.Traineegram
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            List<string> validTrains = new List<string>();
            while(text != "Traincode!")
            {
                string pattern = @"^\<\[([^A-Za-z0-9]+)*\]\.(\.\[([A-Za-z0-9]+)*\]\.)*$";
                Match match = Regex.Match(text, pattern);
                if(match.Success)
                {
                    validTrains.Add(text);
                }
                text = Console.ReadLine();
            }
            if(validTrains.Count==0)
            {
                Console.WriteLine();
            }
            else
            {
                foreach (var train in validTrains)
                {
                    Console.WriteLine(train);
                }
            }
            
        }
    }
}
