using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _5.MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"\b([A-Z])([a-z]+)\s([A-Z])([a-z]+)\b";
            List<string> result = new List<string>();
            Regex reg = new Regex(pattern);
            MatchCollection matches = reg.Matches(text);
            foreach (var match in matches)
            {
                result.Add(match.ToString());
            }
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
