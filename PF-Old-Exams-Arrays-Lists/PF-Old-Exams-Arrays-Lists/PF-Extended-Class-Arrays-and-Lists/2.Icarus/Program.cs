using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.Icarus
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = Console.ReadLine().Split().Select(int.Parse).ToList();
            int startPos = int.Parse(Console.ReadLine());
            string[] direction = Console.ReadLine().Split().ToArray();
            int damage = 1;
            while (direction[0] != "Supernova")
            {
                int steps = int.Parse(direction[1]);
                string dir = direction[0];
                if (dir=="right")
                {
                    for (int i = 0; i < steps; i++)
                    {
                        if (startPos == arr.Count - 1)
                        {
                            startPos = 0;
                            damage++;
                        }
                        else
                        {
                            startPos++;
                        }
                        arr[startPos] -= damage;
                    }
                }
                else if(dir=="left")
                {
                    for (int i = 0; i < steps; i++)
                    {
                        if (startPos == 0)
                        {
                            startPos = arr.Count - 1;
                            damage++;
                        }
                        else
                        {
                            startPos--;
                        }
                        arr[startPos] -= damage;
                    }
                }
                direction = Console.ReadLine().Split().ToArray();
            }
            Console.WriteLine(string.Join(" ",arr));
        }
    }
}
