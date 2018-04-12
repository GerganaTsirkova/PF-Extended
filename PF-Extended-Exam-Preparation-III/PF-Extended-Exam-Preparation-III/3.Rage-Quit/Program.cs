using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _3.Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var builder = new StringBuilder();
            string patten = @"([^0-9]+[0-9]+)";
            var matches = Regex.Matches(input, patten);
            foreach (var match in matches)
            {
                string strMatch = match.ToString();
                string patternText = @"([^0-9]+)";
                var regText = Regex.Match(strMatch, patternText);
                string text = regText.Groups[1].Value.ToString();
                text = text.ToUpper();
                string patternNumber = @"([0-9]+)";
                var regNumber = Regex.Match(strMatch, patternNumber);
                int number = int.Parse(regNumber.ToString());
                for (int i = 0; i < number; i++)
                {
                    builder.Append(text);
                }
            }
            string unique = new String(builder.ToString().Distinct().ToArray());
            Console.WriteLine($"Unique symbols used: {unique.Length}");
            Console.WriteLine($"{builder.ToString()}");
        }
    }
}
