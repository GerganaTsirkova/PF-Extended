using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _2.CommandInterpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> arr = Console.ReadLine().Split(new char[] { ' ','\t' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            while(true)
            {
                string input = Console.ReadLine();
                if(input=="end")
                {
                    break;
                }
                string[] tokens = input.Split().ToArray();
                switch(tokens[0])
                {
                    case "reverse":
                        int start = int.Parse(tokens[2]);
                        int count = int.Parse(tokens[4]);
                        if((start<0)||(start>=arr.Count)||(start+count>arr.Count)||(count<0))
                        {
                            Console.WriteLine("Invalid input parameters.");
                            break;
                        }
                        arr.Reverse(start, count);
                        break;
                    case "sort":
                        int startSort = int.Parse(tokens[2]);
                        int countSort = int.Parse(tokens[4]);
                        if ((startSort < 0) || (startSort >= arr.Count) || (startSort + countSort > arr.Count) || (countSort < 0))
                        {
                            Console.WriteLine("Invalid input parameters.");
                            break;
                        }
                        arr.Sort(startSort, countSort,StringComparer.InvariantCulture);
                        break;
                    case "rollLeft":
                        int countLeft = int.Parse(tokens[1]);
                        if (countLeft < 0)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            break;
                        }
                        for (int i = 0; i < countLeft % arr.Count; i++)
                        {
                            string firstElement = arr[0];
                            for (int j = 0; j < arr.Count-1; j++)
                            {
                                arr[j] = arr[j + 1];
                            }
                            arr[arr.Count - 1] = firstElement;
                        }
                        break;
                    case "rollRight":
                        int countRight = int.Parse(tokens[1]);
                        if(countRight<0)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            break;
                        }
                        for (int i = 0; i < countRight%arr.Count; i++)
                        {
                            string lastElement = arr[arr.Count - 1];
                            for (int j = arr.Count-1; j >= 1; j--)
                            {
                                arr[j] = arr[j - 1];
                            }
                            arr[0] = lastElement;
                        }
                        break;
                }
                
            }
            Console.WriteLine("["+string.Join(", ",arr)+"]");
        }
    }
}
