using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(new char[] { ' ','\t' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            string[] command = Console.ReadLine().Split(' ').ToArray();
            while (command[0] != "end")
            {

                if (command[0] == "reverse")
                {
                    int start = int.Parse(command[2]);
                    int count = int.Parse(command[4]);
                    if (IsValidCommand(input, start, count))
                    {
                        input.Reverse(start, count);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                }
                else if (command[0] == "sort")
                {
                    int start = int.Parse(command[2]);
                    int count = int.Parse(command[4]);
                    if (IsValidCommand(input, start, count))
                    {
                        input.Sort(start, count, StringComparer.InvariantCulture);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                }
                else if (command[0] == "rollLeft")
                {
                    int times = int.Parse(command[1]);
                    if (times < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                    else
                    {
                        for (int i = 0; i < times % input.Count; i++)
                        { 
                            string start = input[0];
                            for (int j = 0; j < input.Count-1; j++)
                            {
                                input[j] = input[j + 1];
                            }
                            input[input.Count - 1] = start;
                        }
                    }
                }
                else if (command[0] == "rollRight")
                {
                    int times = int.Parse(command[1]);
                    if (times < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                    else
                    {
                        for (int i = 0; i < times % input.Count; i++)
                        {
                            string last = input[input.Count - 1];
                            for (int j = input.Count - 1; j >= 1; j--)
                            {
                                input[j] = input[j - 1];
                            }
                            input[0] = last;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input parameters.");
                }
                command = Console.ReadLine().Split(' ').ToArray();
            }
            string separator = ", ";
            Console.WriteLine($"[{string.Join(separator, input)}]");
        }

        static bool IsValidCommand(List<string> input, int start, int count)
        {
            bool result = true;
            if ((start < 0) || (start > input.Count-1))
            {
                result = false;
            }
            if ((count < 0) || (count + start > input.Count))
            {
                result = false;
            }
            return result;
        }
    }
}
