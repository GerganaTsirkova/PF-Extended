using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.OddOccuruncies
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] elements = Console.ReadLine().ToLower().Split().ToArray();
            var dict = new Dictionary<string, int>();
            foreach (var item in elements)
            {
                if(!dict.ContainsKey(item))
                {
                    dict.Add(item, 1);
                }
                else
                {
                    dict[item]++;
                }
            }
            var result = new List<string>();
            foreach (var item in dict)
            {
                if(item.Value % 2 != 0 )
                {
                    result.Add(item.Key);
                }
            }
            Console.WriteLine(string.Join(", ",result));
        }
    }
}
