using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string[] input = Console.ReadLine().Split(' ').ToArray();
            while(input[0] != "end")
            {
                if(input[0]=="exchange")
                {
                    if((int.Parse(input[1])<0)||(int.Parse(input[1])>arr.Count-1))
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        int index = int.Parse(input[1]);
                        List<int> inner = new List<int>();
                        for (int i = 0; i < arr.Count; i++)
                        {
                            if (i >= index + 1)
                            {
                                inner.Add(arr[i]);
                            }
                        }
                        for (int i = 0; i <= index; i++)
                        {
                            inner.Add(arr[i]);
                        }
                        arr = inner;
                    }
                    
                }
                else if(input[0]=="max")
                {
                    if(input[1]=="even")
                    {
                        int index = -1;
                        int maxEven = int.MinValue;
                        for (int i = 0; i < arr.Count; i++)
                        {
                            if((arr[i]>=maxEven)&&(arr[i] % 2==0))
                            {
                                maxEven = arr[i];
                                index = i;
                            }
                        }
                        if(index==-1)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            Console.WriteLine(index);
                        }
                    }
                    else if(input[1]=="odd")
                    {
                        int maxOdd = int.MinValue;
                        int index = -1;
                        for (int i = 0; i < arr.Count; i++)
                        {
                            if ((arr[i] >= maxOdd) && (arr[i] % 2 != 0))
                            {
                                maxOdd = arr[i];
                                index = i;
                            }
                        }
                        if(index==-1)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            Console.WriteLine(index);
                        }
                    }
                }
                else if(input[0]=="min")
                {
                    if(input[1]=="even")
                    {
                        int minEven = int.MaxValue;
                        int index = -1;
                        for (int i = 0; i < arr.Count; i++)
                        {
                            if((minEven >= arr[i])&&(arr[i] % 2 == 0))
                            {
                                minEven = arr[i];
                                index = i;
                            }
                        }
                        if(index==-1)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            Console.WriteLine(index);
                        }
                    }
                    else if(input[1]=="odd")
                    {
                        int minOdd = int.MaxValue;
                        int index = -1;
                        for (int i = 0; i < arr.Count; i++)
                        {
                            if((minOdd>=arr[i])&&(arr[i] % 2 != 0))
                            {
                                minOdd = arr[i];
                                index = i;
                            }
                        }
                        if(index==-1)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            Console.WriteLine(index);
                        }
                    }

                }
                else if(input[0]=="first")
                {
                    if(input[2]=="even")
                    {
                        int count = int.Parse(input[1]);
                        int counter = 0;
                        List<int> myarray = new List<int>();
                        if(count > arr.Count)
                        {
                            Console.WriteLine("Invalid count");
                        }
                        else if(count==0)
                        {
                            Console.WriteLine("[]");
                        }
                        else
                        {
                            for (int i = 0; i < arr.Count; i++)
                            {
                                if (arr[i] % 2 == 0)
                                {
                                    myarray.Add(arr[i]);
                                    counter++;
                                    if (counter == count)
                                    {
                                        break;
                                    }
                                }
                            }
                            if(counter==0)
                            {
                                Console.WriteLine("[]");
                            }
                            else
                            {
                                Console.Write("[");
                                Console.Write(string.Join(", ", myarray));
                                Console.WriteLine("]");
                            }
                        }
                    }
                    else if(input[2]=="odd")
                    {
                        int count = int.Parse(input[1]);
                        int counter = 0;
                        List<int> myarray = new List<int>();
                        if (count > arr.Count)
                        {
                            Console.WriteLine("Invalid count");
                        }
                        else if (count == 0)
                        {
                            Console.WriteLine("[]");
                        }
                        else
                        {
                            for (int i = 0; i < arr.Count; i++)
                            {
                                if (arr[i] % 2 != 0)
                                {
                                    myarray.Add(arr[i]);
                                    counter++;
                                    if (counter == count)
                                    {
                                        break;
                                    }
                                }
                            }
                            if (counter == 0)
                            {
                                Console.WriteLine("[]");
                            }
                            else
                            {
                                Console.Write("[");
                                Console.Write(string.Join(", ", myarray));
                                Console.WriteLine("]");
                            }
                        }
                    }
                }
                else if(input[0]=="last")
                {
                    if (input[2] == "even")
                    {
                        int count = int.Parse(input[1]);
                        int counter = 0;
                        List<int> myarray = new List<int>();
                        if (count > arr.Count)
                        {
                            Console.WriteLine("Invalid count");
                        }
                        else if (count == 0)
                        {
                            Console.WriteLine("[]");
                        }
                        else
                        {
                            for (int i = arr.Count-1; i >= 0; i--)
                            {
                                if (arr[i] % 2 == 0)
                                {
                                    myarray.Add(arr[i]);
                                    counter++;
                                    if (counter == count)
                                    {
                                        break;
                                    }
                                }
                            }
                            myarray.Reverse();
                            if (counter == 0)
                            {
                                Console.WriteLine("[]");
                            }
                            else
                            {
                                Console.Write("[");
                                Console.Write(string.Join(", ", myarray));
                                Console.WriteLine("]");
                            }
                        }
                    }
                    else if (input[2] == "odd")
                    {
                        int count = int.Parse(input[1]);
                        int counter = 0;
                        List<int> myarray = new List<int>();
                        if (count > arr.Count)
                        {
                            Console.WriteLine("Invalid count");
                        }
                        else if (count == 0)
                        {
                            Console.WriteLine("[]");
                        }
                        else
                        {
                            for (int i = arr.Count-1; i >= 0; i--)
                            {
                                if (arr[i] % 2 != 0)
                                {
                                    myarray.Add(arr[i]);
                                    counter++;
                                    if (counter == count)
                                    {
                                        break;
                                    }
                                }
                            }
                            myarray.Reverse();
                            if (counter == 0)
                            {
                                Console.WriteLine("[]");
                            }
                            else
                            {
                                Console.Write("[");
                                Console.Write(string.Join(", ", myarray));
                                Console.WriteLine("]");
                            }
                        }
                    }
                }
                input = Console.ReadLine().Split(' ').ToArray();
            }
            Console.Write("[");
            Console.Write(string.Join(", ",arr));
            Console.WriteLine("]");
        }
    }
}
