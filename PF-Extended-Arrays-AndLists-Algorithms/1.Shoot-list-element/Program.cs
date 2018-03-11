using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.Shoot_list_element
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>();
            int lastRemovedElement = 0;
            int endCounter = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if(input=="stop")
                {
                    endCounter++;
                    break;
                }
                if(input == "bang")
                {
                    if(nums.Count==0)
                    {
                        Console.WriteLine($"nobody left to shoot! last one was {lastRemovedElement}");
                        break;
                    }
                    else if(nums.Count==1)
                    {
                        lastRemovedElement = nums[0];
                        nums.RemoveAt(0);
                        Console.WriteLine($"shot {lastRemovedElement}");
                    }
                    else
                    {
                        int sum = 0;
                        for (int i = 0; i < nums.Count; i++)
                        {
                            sum += nums[i];
                        }
                        double average = sum /(double)nums.Count;
                        for (int i = 0; i < nums.Count; i++)
                        {
                            if(nums[i]<average)
                            {
                                lastRemovedElement = nums[i];
                                nums.RemoveAt(i);
                                Console.WriteLine($"shot {lastRemovedElement}");
                                for (int j = 0; j < nums.Count; j++)
                                {
                                    nums[j] -= 1;
                                }
                                break;
                            }
                        }
                    }
                }
                else
                {
                    int n = int.Parse(input);
                    nums.Insert(0,n);
                }
            }
            if((nums.Count==0)&&(endCounter>0))
            {
                Console.WriteLine($"you shot them all. last one was {lastRemovedElement}");
            }
            else if(endCounter>0)
            {
                Console.Write("survivors: ");
                Console.WriteLine(string.Join(" ",nums));
            }
        }
    }
}
