using System;
using System.Collections.Generic;
using System.Linq;

namespace _8.SnowMan
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> lost = new List<int>();
            while (arr.Count > 1)
            {
                for (int i = 0; i < arr.Count; i++)
                {
                    if((arr.Count-lost.Count==1)||(lost.Contains(i)))
                    {
                        continue;
                    }
                    int attacker = i;
                    int target = 0;
                    if (arr[i]<=arr.Count-1)
                    {
                        target = arr[i];
                    }
                    else
                    {
                        target = arr[i] % arr.Count;
                        if(target>arr.Count-1)
                        {
                            target = target % arr.Count;
                        }
                    }
                    int difference = Math.Abs(attacker - target);
                    if((difference%2==0)&&(difference !=0))
                    {
                        Console.WriteLine($"{attacker} x {target} -> {attacker} wins");
                        lost.Add(target);
                        lost = lost.Distinct().ToList();
                    }
                    else if(difference % 2 !=0)
                    {
                        Console.WriteLine($"{attacker} x {target} -> {target} wins");
                        lost.Add(attacker);
                        lost = lost.Distinct().ToList();
                    }
                    else if(difference==0)
                    {
                        Console.WriteLine($"{attacker} performed harakiri");
                        lost.Add(attacker);
                        lost = lost.Distinct().ToList();
                    }
                   
                }
                for (int i = arr.Count - 1; i >= 0; i--)
                {
                    if (lost.Contains(i))
                    {
                        arr.RemoveAt(i);
                    }
                }
                lost.Clear();
            }
        }
    }
}
