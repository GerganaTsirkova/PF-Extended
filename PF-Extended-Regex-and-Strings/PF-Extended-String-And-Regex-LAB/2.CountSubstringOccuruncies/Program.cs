using System;
using System.Text.RegularExpressions;

namespace _2.CountSubstringOccuruncies
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            string part = Console.ReadLine().ToLower();
            Console.WriteLine(Regex.Matches(text, part).Count);
        }
    }
}
