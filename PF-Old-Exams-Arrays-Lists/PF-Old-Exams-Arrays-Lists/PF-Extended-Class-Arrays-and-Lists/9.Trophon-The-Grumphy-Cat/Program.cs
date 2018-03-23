using System;
using System.Collections.Generic;
using System.Linq;

namespace _9.Trophon_The_Grumphy_Cat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> arr = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            int index = int.Parse(Console.ReadLine());
            string itemValue = Console.ReadLine();
            string priceRating = Console.ReadLine();
            long damageLeft = 0;
            long damageRight = 0;
            long sum = 0;
            string position = "";
            if(itemValue=="cheap")
            {

            }
            else
            {

            }
            if(priceRating=="positive")
            {
                for (int i = 0; i < index; i++)
                {
                    if(arr[i]>=0)
                    {
                        damageLeft += arr[i];
                    }
                }
            }
            else if(priceRating=="negative")
            {
                for (int i = 0; i < index; i++)
                {
                    if (arr[i] < 0)
                    {
                        damageLeft += arr[i];
                    }
                }
            }
            else if(priceRating == "all")
            {

            }
            Console.WriteLine($"{position} – {sum}");
        }
    }
}
