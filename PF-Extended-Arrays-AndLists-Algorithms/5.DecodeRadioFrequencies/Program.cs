using System;
using System.Linq;

namespace _5.DecodeRadioFrequencies
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split(' ').ToArray();
            int countZeroes = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                string[] inner = nums[i].ToString().Split('.').ToArray();
                if(inner[0]=="0")
                {
                    countZeroes++;
                }
                if(inner[1]=="0")
                {
                    countZeroes++;
                }
            }
            string[] arr = new string[nums.Length*2-countZeroes];
            for (int i = 0; i < nums.Length; i++)
            {
                string[] inner = nums[i].ToString().Split('.').ToArray();
                string first = inner[0];
                string second = inner[1];
                if(first != "0")
                {
                    arr[i] = first;
                }
                if(second != "0")
                {
                    arr[arr.Length - 1 - i] = second;
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write((char)(int.Parse(arr[i])));
            }
            Console.WriteLine();
        }
    }
}
