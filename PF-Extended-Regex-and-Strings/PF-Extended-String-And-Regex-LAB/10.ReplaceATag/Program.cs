using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _10.ReplaceATag
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            List<string> result = new List<string>();
            while(text != "end")
            {
                string pattern = @"<a.*?href.*?=(.*)>(.*?)<\/a>";
                string rep = @"[URL href=$1]$2[/URL]";
                string replaced = Regex.Replace(text, pattern, rep);
                result.Add(replaced);
                text = Console.ReadLine();
            }
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
