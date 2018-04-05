using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.Rainer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] numbers = new int[nums.Count-1];
            for (int i = 0; i < nums.Count-1; i++)
            {
                numbers[i] = nums[i];
            }
            int index = nums[nums.Count - 1];
            int counter = 0;
            while(true)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i]--;
                }
                if(numbers[index]==0)
                {
                    break;
                }
                else
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        if((numbers[i]==0)&&(i != index))
                        {
                            numbers[i] = nums[i];
                        }
                    }
                    counter++;
                    index = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine(string.Join(" ",numbers));
            Console.WriteLine(counter);
        }
    }
}
