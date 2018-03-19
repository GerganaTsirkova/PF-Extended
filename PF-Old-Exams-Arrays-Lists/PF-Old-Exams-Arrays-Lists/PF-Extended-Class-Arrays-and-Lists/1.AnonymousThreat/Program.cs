using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> arr = Console.ReadLine().Split(' ').ToList();
            string[] input = Console.ReadLine().Split(new char[] { ' '},StringSplitOptions.RemoveEmptyEntries).ToArray();
            while (input[0] != "3:1")
            {
                if (input[0] == "merge")
                {
                    int startIndex = int.Parse(input[1]);
                    int endIndex = int.Parse(input[2]);
                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    if (endIndex > arr.Count - 1)
                    {
                        endIndex = arr.Count - 1;
                    }
                    for (int i = startIndex; i < endIndex; i++)
                    {
                        arr[startIndex] += arr[startIndex + 1];
                        arr.RemoveAt(startIndex + 1);
                    }
                }
                else if (input[0] == "divide")
                {
                    string itemToDivide = arr[int.Parse(input[1])].ToString();
                    int partition = int.Parse(input[2]);
                    string newString = "";
                    List<string> divided = new List<string>();
                    for (int i = 0; i < itemToDivide.Length; i++)
                    {
                        if(partition==0)
                        {
                            break;
                        }
                        if (newString.Length == itemToDivide.Length / partition)
                        {
                            divided.Add(newString);
                            newString = "";
                            if (divided.Count == partition - 1)
                            {
                                for (int j = i; j < itemToDivide.Length; j++)
                                {
                                    newString += itemToDivide[j];
                                }
                                divided.Add(newString);
                                break;
                            }
                            else
                            {
                                newString += itemToDivide[i];
                            }
                        }
                        else
                        {
                            newString += itemToDivide[i];
                        }
                    }
                    if(partition>0)
                    {
                        arr.RemoveAt(int.Parse(input[1]));
                        arr.InsertRange(int.Parse(input[1]), divided);
                    }
                    
                }
                input = Console.ReadLine().Split(' ').ToArray();
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
