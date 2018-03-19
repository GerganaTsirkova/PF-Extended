using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5.Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            //this is the best array:
            int[] final = new int[n];
            int finalIndex = 0;
            //this is the current array:
            int[] nums = new int[n];
            int index = 0;
            while (input != "Clone them!")
            {
                index++;
                nums = input.Split(new char[] { '!', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int[] parameters = GetInfo(nums);
                if(IsBetter(parameters,final))
                {
                    final = nums;
                    finalIndex = index;
                }
                if((finalIndex==0)&&(nums.Sum()==0))
                {
                    final = nums;
                    finalIndex = index;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Best DNA sample {finalIndex} with sum: {final.Sum()}.");
            Console.WriteLine(string.Join(" ",final));
        }

        static bool IsBetter(int[] parameters, int[] final)
        {
            int[] finalInfo = GetInfo(final);
            if(parameters[0]>finalInfo[0])
            {
                return true;
            }
            else if(parameters[0]==finalInfo[0])
            {
                if(parameters[1]<finalInfo[1])
                {
                    return true;
                }
                else if(parameters[2]>finalInfo[2])
                {
                    return true;
                }
            }
            return false;
        }

        static int[] GetInfo(int[] nums)
        {
            int sequence = 0;
            int position = 0;
            int sum = nums.Sum();
            int counter = 0;
            int counterMax = 0; 
            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[i]==1)
                {
                    counter++;
                    if(counterMax<counter)
                    {
                        counterMax=counter;
                        position = i - counter + 1;
                    }
                }
                else
                {
                    counter = 0;
                }
            }
            sequence = counterMax;
            return new int[] {sequence,position,sum};
        }
    }
}
