using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.Spyfer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            for (int i = 0; i < nums.Count; i++)
            {
                if(nums.Count==1)
                {
                    break;
                }
                if ((i == 0) && (nums[i] == nums[i + 1]))
                {
                    nums.RemoveAt(i + 1);
                    i--;
                }
                else if ((i >= 1) && (i < nums.Count - 1) && (nums[i] == nums[i + 1] + nums[i - 1]))
                {
                    nums.RemoveAt(i + 1);
                    nums.RemoveAt(i - 1);
                    i = -1;
                }
                else if ((i == nums.Count - 1) && (nums[i] == nums[i - 1]))
                {
                    nums.RemoveAt(i - 1);
                    i = -1;
                }
            }
            Console.WriteLine(string.Join(" ",nums));
        }
    }
}
