using System;
using System.Text.RegularExpressions;

namespace _7.HexadecimalNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"(\b|0x)?[0-9A-F]+\b";
            Regex reg = new Regex(pattern);
            MatchCollection matches = reg.Matches(text);
            foreach (var match in matches)
            {
                Console.Write(match+" ");
            }
        }
    }
}
