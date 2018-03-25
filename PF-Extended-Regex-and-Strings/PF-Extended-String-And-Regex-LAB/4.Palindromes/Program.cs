using System;
using System.Collections.Generic;

namespace _4.Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(new char[] { '.',',',' ','\t','?','!'},StringSplitOptions.RemoveEmptyEntries);
            List<string> palindromes = new List<string>();
            foreach (var word in text)
            {
                if ((IsPalindrome(word)==true)&&(!palindromes.Contains(word)))
                {
                    palindromes.Add(word);
                }
            }
            palindromes.Sort();
            string separator = ", ";
            Console.WriteLine(string.Join(separator,palindromes));
        }

        static bool IsPalindrome(string value)
        {
            int min = 0;
            int max = value.Length - 1;
            while (true)
            {
                if (min > max)
                {
                    return true;
                }
                char a = value[min];
                char b = value[max];
                if (a != b)
                {
                    return false;
                }
                min++;
                max--;
            }
        }
    }
}
