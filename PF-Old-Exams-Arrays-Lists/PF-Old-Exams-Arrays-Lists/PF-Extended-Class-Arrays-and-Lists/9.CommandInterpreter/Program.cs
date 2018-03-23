using System;
using System.Collections.Generic;
using System.Linq;

namespace _9.CommandInterpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(new char[] { ' ','\t' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            string commandInitial = Console.ReadLine();
            while (commandInitial != "end")
            {
                string[] command = commandInitial.Split(' ');
                switch(command[0])
                {
                    case "reverse":
                        ExecuteReversing(input, command);
                        break;
                    case "sort":
                        ExecuteSorting(input, command);
                        break;
                    case "rollRight":
                        ExecureRollRight(input, command);
                        break;
                    case "rollLeft":
                        ExecuteRollLeft(input, command);
                        break;
                }
                commandInitial = Console.ReadLine();
            }
            string separator = ", ";
            Console.WriteLine($"[{string.Join(separator, input)}]");
        }

        static void ExecuteSorting(List<string> input, string[] command)
        {
            int start = int.Parse(command[2]);
            int count = int.Parse(command[4]);
            if (((start < 0) || (start >= input.Count)) || ((count + start > input.Count) || (count < 0)))
            {
                Console.WriteLine("Invalid input parameters.");
                return;
            }
            else
            {
                input.Sort(start, count, StringComparer.InvariantCulture);
            }
            return;
        }

        static void ExecuteReversing(List<string> input, string[] command)
        {
            int start = int.Parse(command[2]);
            int count = int.Parse(command[4]);
            if (((start < 0) || (start >= input.Count)) || ((count + start > input.Count)||(count<0)))
            {
                Console.WriteLine("Invalid input parameters.");
                return;
            }
            else
            {
                input.Reverse(start,count);
            }
            return;
        }

        static void ExecuteRollLeft(List<string> input, string[] command)
        {
            int count = int.Parse(command[1]);
            if (count < 0)
            {
                Console.WriteLine("Invalid input parameters.");
                return;
            }
            else
            {
                for (int i = 0; i < count % input.Count; i++)
                {
                    string temp = input[0];
                    for (int j = 0; j < input.Count-1; j++)
                    {
                        input[j] = input[j + 1];
                    }
                    input[input.Count - 1] = temp;
                }
                return;
            }
        }

        static void ExecureRollRight(List<string> input, string[] command)
        {
            int count = int.Parse(command[1]);
            if (count < 0)
            {
                Console.WriteLine("Invalid input parameters.");
                return;
            }
            else
            {
                for (int i = 0; i < count % input.Count; i++)
                {
                    string temp = input[input.Count-1];
                    for (int j = input.Count - 1; j >= 1; j--)
                    {
                        input[j] = input[j - 1];
                    }
                    input[0] = temp;
                }
                return;
            }
        }

    }
}
