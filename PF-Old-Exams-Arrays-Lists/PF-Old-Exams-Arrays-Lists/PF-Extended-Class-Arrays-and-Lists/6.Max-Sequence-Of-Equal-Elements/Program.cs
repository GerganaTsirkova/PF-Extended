using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.Max_Sequence_Of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            
            int currentCounter = 1;
            int maxCounter = 1;
            int leftMostIndex = 0;
            int numberRepeated = 0;
            for (int i = 0; i < arr.Count-1; i++)
            {
                if(arr[i]==arr[i+1])
                {
                    currentCounter++;
                    if(currentCounter>maxCounter)
                    {
                        maxCounter = currentCounter;
                        numberRepeated = arr[i];
                        leftMostIndex = i - 1 - maxCounter;
                    }
                }
                else
                {
                    currentCounter = 1;
                }
            }
            for (int i = 0; i < maxCounter; i++)
            {
                Console.Write(numberRepeated+" ");
            }
            Console.WriteLine();
        }
    }
}
