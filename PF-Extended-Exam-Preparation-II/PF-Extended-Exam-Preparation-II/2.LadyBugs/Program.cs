using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            List<int> ladybugIndex = Console.ReadLine().Split().Select(int.Parse).ToList();
            if (fieldSize > 0)
            {
                long[] resulList = new long[fieldSize];
                int countOnes = 0;
                for (int i = 0; i < ladybugIndex.Count; i++)
                {
                    for (int j = 0; j < fieldSize; j++)
                    {
                        if ((ladybugIndex[i] == j) && (resulList[j] == 0))
                        {
                            resulList[j] = 1;
                            countOnes++;
                        }
                    }
                }
                if(countOnes!=0)
                {
                    string command = Console.ReadLine();
                    while (command != "end")
                    {
                        string[] tokens = command.Split().ToArray();
                        long initialIndex = long.Parse(tokens[0]);
                        if ((initialIndex >= 0) && (initialIndex <= resulList.Length-1))
                        {
                            long moves = long.Parse(tokens[2]);
                            if (tokens[1] == "right")
                            {
                                if (resulList[initialIndex] == 1)
                                {
                                    resulList[initialIndex] = 0;
                                    while (initialIndex + moves <= resulList.Length - 1)
                                    {
                                        if (resulList[initialIndex + moves] == 1)
                                        {
                                            moves += moves;
                                            continue;
                                        }
                                        else
                                        {
                                            resulList[initialIndex + moves] = 1;
                                            break;
                                        }
                                    }
                                }
                            }
                            else if (tokens[1] == "left")
                            {
                                if (resulList[initialIndex] == 1)
                                {
                                    resulList[initialIndex] = 0;
                                    while (initialIndex - moves >= 0)
                                    {
                                        if (resulList[initialIndex - moves] == 1)
                                        {
                                            moves += moves;
                                            continue;
                                        }
                                        else
                                        {
                                            resulList[initialIndex - moves] = 1;
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        command = Console.ReadLine();
                    }
                }

                Console.WriteLine(string.Join(" ", resulList));
            }
        }
    }
}
