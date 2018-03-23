using System;
using System.Collections.Generic;
using System.Linq;

namespace _8.Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = Console.ReadLine().Split().Select(int.Parse).ToList();
            double average = arr.Average();
            List<int> result = new List<int>();
            int counter = 0;
            foreach (var item in arr)
            {
                if(item>average)
                {
                    result.Add(item);
                }
            }
            result.Sort();
            if(result.Count==0)
            {
                Console.WriteLine("No");
            }
            else
            {
                for (int i = result.Count - 1; i >= 0; i--)
                {
                    if (counter == 5)
                    {
                        break;
                    }
                    Console.Write(result[i] + " ");
                    counter++;
                }
            }
            Console.WriteLine();
        }
    }
}
