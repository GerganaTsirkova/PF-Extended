using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.SortArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ').ToArray();
            List<string> sorted = new List<string>(arr);
            sorted.Sort();
            Console.WriteLine(string.Join(" ",sorted));
        }
    }
}
