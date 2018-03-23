using System;
using System.Linq;

namespace _10.Lady_Bugs
{
    class Program
    {
        static void Main(string[] args)
        {
            long size = long.Parse(Console.ReadLine());
            long[] ones = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long[] field = new long[size];
            for (long i = 0; i < ones.Length; i++)
            {
                for (long j = 0; j < field.Length; j++)
                {
                    if(ones[i]==j)
                    {
                        field[j]++;
                    }
                }
            }
            while(true)
            {
                string[] command = Console.ReadLine().Split().ToArray();
                if(command[0]=="end")
                {
                    break;
                }
                long index = long.Parse(command[0]);
                string direction = command[1];
                long flyLen = long.Parse(command[2]);
                if((index >= 0)&&(index < field.Length)&&(field[index]==1) &&(flyLen>0))
                {
                    field[index]=0;
                    switch(direction)
                    {
                        case "right":
                            for (long i = index+flyLen; i < field.Length; i+= index+flyLen)
                            {
                                if(field[i]==1)
                                {
                                    if(i+flyLen > field.Length)
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                    
                                }
                                else if(field[i]==0)
                                {
                                    field[i]=1;
                                    break;
                                }
                            }
                            break;
                        case "left":
                            if(index-flyLen>=0)
                            {
                                for (long i = index - flyLen; i >= 0; i-= index-flyLen)
                                {
                                    if(field[i]==1)
                                    {
                                        if (i - flyLen < 0)
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            continue;
                                        }
                                    }
                                    else if(field[i]==0)
                                    {
                                        field[i]=1;
                                        break;
                                    }
                                }
                            }
                            break;
                    }
                }
            }
            Console.WriteLine(string.Join(" ",field));
        }
    }
}
