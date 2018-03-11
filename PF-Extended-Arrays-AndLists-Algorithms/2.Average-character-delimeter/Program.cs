using System;
using System.Linq;

namespace _2.Average_character_delimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ').ToArray();
            double average = 0;
            int sum = 0;
            int countLetters = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                char[] single = arr[i].ToCharArray();
                foreach (var letter in single)
                {
                    sum += (int)letter;
                    countLetters++;
                }
            }
            average = sum / (double)countLetters;
            int ave = (int)Math.Floor(average);
            char let = Char.ToUpper((char)ave);
            Console.WriteLine(string.Join($"{let}",arr));
        }
        

    }
}
