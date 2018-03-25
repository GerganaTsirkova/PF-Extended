using System;
using System.Text.RegularExpressions;

namespace _9.MatchNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"(^|(?<=\s))(\-)?[0-9]+(\.[0-9]+)?($|(?=\s))";
            var matches = Regex.Matches(text, pattern);
            foreach (Match match in matches)
            {
                Console.Write(match.Value+" ");
            }
            Console.WriteLine();
        }
    }
}
