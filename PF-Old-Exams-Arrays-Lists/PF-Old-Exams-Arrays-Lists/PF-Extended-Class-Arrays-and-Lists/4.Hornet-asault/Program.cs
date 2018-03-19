using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _4.Hornet_asault
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BigInteger> bees = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToList();
            List<BigInteger> hornets = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToList();
            BigInteger sum = 0;
            for (int i = 0; i < hornets.Count; i++)
            {
                sum += hornets[i];
            }
            for (int i = 0; i < bees.Count; i++)
            {
                if((hornets.Count==0)||(bees.Count==0))
                {
                    break;
                }
                if (bees[i] < sum)
                {
                    bees.RemoveAt(i);
                    i--;
                }
                else
                {
                    bees[i] -= sum;
                    sum -= hornets[0];
                    hornets.RemoveAt(0);
                    if(bees[i]==0)
                    {
                        bees.RemoveAt(i);
                        i--;
                    }
                }

            }
            if(bees.Count>0)
            {
                Console.WriteLine(string.Join(" ",bees));
            }
            else
            {
                Console.WriteLine(string.Join(" ",hornets));
            }
        }
    }
}
