using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _2.AnonymousVox
{
    class Program
    {
        static void Main(string[] args)
        {
            string placeholders = Console.ReadLine();
            string placeholderPattern = @"([A-Za-z]+)(.+)(\1)";
            string values = Console.ReadLine();
            string valuePattern = @"({)([\W\w]+?)(})";
            MatchCollection placeholderCollection = Regex.Matches(placeholders, placeholderPattern);
            MatchCollection valueCollection = Regex.Matches(values, valuePattern);
            for (int i = 0; i < Math.Min(placeholderCollection.Count,valueCollection.Count); i++)
            {
                string toPut = valueCollection[i].Groups[2].Value;
                string toReplace = placeholderCollection[i].Groups[2].Value;
                int index = placeholders.IndexOf(toReplace);
                placeholders = placeholders.Remove(index, toReplace.Length);
                placeholders = placeholders.Insert(index, toPut);
            }
            Console.WriteLine(placeholders);
        }
    }
}
