using System;
using System.Text.RegularExpressions;

namespace _8.Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"(?<day>\d{2})(\.|\/|\-)(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})";
            MatchCollection dates = Regex.Matches(text, pattern);

            foreach (Match date in dates)
            {
                string day = date.Groups["day"].Value;
                string month = date.Groups["month"].Value;
                string year = date.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
