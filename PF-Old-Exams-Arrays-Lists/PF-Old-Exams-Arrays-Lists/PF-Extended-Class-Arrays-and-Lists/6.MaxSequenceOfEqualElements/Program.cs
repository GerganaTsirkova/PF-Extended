using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            //18:28
            List<int> arr = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> bestArr = new List<int>();
            int bestIndex = 0;
            List<int> currentArray = new List<int>();
            int currentIndex = 0;

            for (int i = 0; i < arr.Count-1; i++)
            {
                if (arr[i]==arr[i+1])
                {
                    List<int> paramenters = GetInfo(arr,arr[i]);
                    if(IsBetter(paramenters,bestArr,arr[i]))
                    {
                        bestArr = currentArray;
                        bestIndex = currentIndex;
                    }
                }
            }
            for (int i = 0; i < bestArr.Count; i++)
            {
                Console.Write(bestArr[0]+" ");
            }
        }

        static bool IsBetter(List<int> paramenters, List<int> bestArr,int num)
        {
            List<int> final = GetInfo(bestArr,num);
            if(paramenters[0]>bestArr[0])
            {
                return true;
            }
            if(paramenters[1]<bestArr[1])
            {
                return true;
            }
            return false;
        }

        static List<int> GetInfo(List<int> arr,int num)
        {
            int index = 0;
            int currLen = 0;
            int maxLen = 0;
            for (int i = 0; i < arr.Count-1; i++)
            {
                if(arr[i] == arr[i+1])
                {
                    currLen++;
                    if(currLen>maxLen)
                    {
                        maxLen = currLen;
                        index = i - maxLen;
                    }
                }
                else
                {
                    currLen = 0;
                }
            }

            return new List<int> {maxLen,index,num};
        }
        
    }
}
