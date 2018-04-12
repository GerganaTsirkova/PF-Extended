using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _3.NetherRealms
{
    class Program
    {
        static void Main(string[] args)
        {
            var deamons = new SortedDictionary<string, string>();
            string[] input = Console.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            for (int i = 0; i < input.Length; i++)
            {
                string deamonName = input[i];
                decimal health = 0;
                string healthPattern = @"[^\.0-9\*\/\+\-]";
                var matchesChars = Regex.Matches(deamonName, healthPattern);
                foreach (var item in matchesChars)
                {

                    var letter = item.ToString().ToCharArray();
                    health += (int)letter[0];
                }
                decimal damage = 0;
                string patternNumbers = @"(\+|\-)*[0-9]+(\.[0-9]+)*";
                var matchesNums = Regex.Matches(deamonName, patternNumbers);
                foreach (var item in matchesNums)
                {
                    damage += decimal.Parse(item.ToString());
                }
                foreach (var ch in deamonName)
                {
                    if(ch=='/')
                    {
                        damage /= 2;
                    }
                    else if(ch=='*')
                    {
                        damage *= 2;
                    }
                }
                string str = $"{health} health, {damage:f2} damage";
                deamons.Add(deamonName, str);
            }
            foreach (var deamon in deamons)
            {
                Console.WriteLine($"{deamon.Key} - {deamon.Value}");
            }
        }
    }
}
