using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _6.MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"\+359(-|\s)2\1\d{3}\1\d{4}\b";
            List<string> validNumbers = new List<string>();
            var reg = new Regex(pattern);
            var matches = reg.Matches(text);
            foreach (var match in matches)
            {
                validNumbers.Add(match.ToString());

            }
            string separator = ", ";
            Console.WriteLine(string.Join(separator,validNumbers));
        }
    }
}
