using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();
            while(command != "end")
            {
                string[] tokens = command.Split().ToArray();
                switch(tokens[0])
                {
                    case "exchange":
                        int index = int.Parse(tokens[1]);
                        if((index < 0)||(index > arr.Count-1))
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }
                        List<int> inner = new List<int>();
                        for (int i = index+1; i < arr.Count; i++)
                        {
                            inner.Add(arr[i]);
                        }
                        for (int i = 0; i <= index; i++)
                        {
                            inner.Add(arr[i]);
                        }
                        arr = inner;
                        break;
                    case "max":
                        string sec = tokens[1];
                        int indexMax = -1;
                        if (sec=="even")
                        {
                            int maxEven = int.MinValue;
                            for (int i = 0; i < arr.Count; i++)
                            {
                                if (arr[i]%2==0)
                                {
                                    if(arr[i]>=maxEven)
                                    {
                                        maxEven = arr[i];
                                        indexMax = i;
                                    }
                                }

                            }
                            if(indexMax==-1)
                            {
                                Console.WriteLine("No matches");
                            }
                            else
                            {
                                Console.WriteLine(indexMax);
                            }
                        }
                        else
                        {
                            int maxOdd = int.MinValue;
                            for (int i = 0; i < arr.Count; i++)
                            {
                                if (arr[i] % 2 != 0)
                                {
                                    if (arr[i] >= maxOdd)
                                    {
                                        maxOdd = arr[i];
                                        indexMax = i;
                                    }
                                }

                            }
                            if (indexMax==-1)
                            {
                                Console.WriteLine("No matches");
                            }
                            else
                            {
                                Console.WriteLine(indexMax);
                            }
                        }
                        break;
                    case "min":
                        string second = tokens[1];
                        int indexMin = -1;
                        if (second == "even")
                        {
                            int minEven = int.MaxValue;
                            for (int i = 0; i < arr.Count; i++)
                            {
                                if (arr[i] % 2 == 0)
                                {
                                    if (arr[i] <= minEven)
                                    {
                                        minEven = arr[i];
                                        indexMin = i;
                                    }
                                }

                            }
                            if (indexMin==-1)
                            {
                                Console.WriteLine("No matches");
                            }
                            else
                            {
                                Console.WriteLine(indexMin);
                            }
                        }
                        else
                        {
                            int minOdd = int.MaxValue;
                            for (int i = 0; i < arr.Count; i++)
                            {
                                if (arr[i] % 2 != 0)
                                {
                                    if (arr[i] <= minOdd)
                                    {
                                        minOdd = arr[i];
                                        indexMin = i;
                                    }
                                }

                            }
                            if (indexMin==-1)
                            {
                                Console.WriteLine("No matches");
                            }
                            else
                            {
                                Console.WriteLine(indexMin);
                            }
                        }
                        break;
                    case "first":
                        int count = int.Parse(tokens[1]);
                        if(count>arr.Count)
                        {
                            Console.WriteLine("Invalid count");
                            break;
                        }
                        List<int> myList = new List<int>();
                        if(tokens[2]=="even")
                        {
                            for (int i = 0; i < arr.Count; i++)
                            {
                                if(arr[i]%2==0)
                                {
                                    myList.Add(arr[i]);
                                    if(myList.Count==count)
                                    {
                                        break;
                                    }
                                }
                            }
                            if(myList.Count==0)
                            {
                                Console.WriteLine("[]");
                            }
                            else
                            {
                                Console.WriteLine("[" + string.Join(", ", myList) + "]");
                            }
                        }
                        else if(tokens[2]=="odd")
                        {
                            for (int i = 0; i < arr.Count; i++)
                            {
                                if (arr[i] % 2 != 0)
                                {
                                    myList.Add(arr[i]);
                                    if (myList.Count == count)
                                    {
                                        break;
                                    }
                                }
                            }
                            if (myList.Count == 0)
                            {
                                Console.WriteLine("[]");
                            }
                            else
                            {
                                Console.WriteLine("[" + string.Join(", ", myList) + "]");
                            }
                        }
                        break;
                    case "last":
                        int countElement = int.Parse(tokens[1]);
                        if (countElement > arr.Count)
                        {
                            Console.WriteLine("Invalid count");
                            break;
                        }
                        List<int> mylist = new List<int>();
                        if (tokens[2] == "even")
                        {
                            for (int i = arr.Count-1; i >=0; i--)
                            {
                                if (arr[i] % 2 == 0)
                                {
                                    mylist.Add(arr[i]);
                                    if (mylist.Count == countElement)
                                    {
                                        break;
                                    }
                                }
                            }
                            mylist.Reverse();
                            if (mylist.Count == 0)
                            {
                                Console.WriteLine("[]");
                            }
                            else
                            {
                                Console.WriteLine("[" + string.Join(", ", mylist) + "]");
                            }
                        }
                        else if (tokens[2] == "odd")
                        {
                            for (int i = arr.Count-1; i>=0; i--)
                            {
                                if (arr[i] % 2 != 0)
                                {
                                    mylist.Add(arr[i]);
                                    if (mylist.Count == countElement)
                                    {
                                        break;
                                    }
                                }
                            }
                            mylist.Reverse();
                            if (mylist.Count == 0)
                            {
                                Console.WriteLine("[]");
                            }
                            else
                            {
                                Console.WriteLine("[" + string.Join(", ", mylist) + "]");
                            }
                        }
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine("["+string.Join(", ",arr)+"]");
        }
    }
}
