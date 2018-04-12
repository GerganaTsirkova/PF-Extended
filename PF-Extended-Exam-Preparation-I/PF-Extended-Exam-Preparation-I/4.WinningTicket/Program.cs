using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _4.WinningTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            foreach (var item in input)
            {
                if (item.Length==20)
                {
                    if (WinJackop(item))
                    {
                        Console.WriteLine($"ticket \"{item}\" - 10{item[0]} Jackpot!");
                        continue;
                    }
                    else if(windDollar(item))
                    {
                        string first = item.Substring(0, 10);
                        string second = item.Substring(10);
                        if(first.Contains("$$$$$$$$$")&&(second.Contains("$$$$$$$$$")))
                        {
                            Console.WriteLine($"ticket \"{item}\" - 9$");
                            continue;
                        }
                        else if (first.Contains("$$$$$$$$") && (second.Contains("$$$$$$$$")))
                        {
                            Console.WriteLine($"ticket \"{item}\" - 8$");
                            continue;
                        }
                        else if (first.Contains("$$$$$$$") && (second.Contains("$$$$$$$")))
                        {
                            Console.WriteLine($"ticket \"{item}\" - 7$");
                            continue;
                        }
                        else if (first.Contains("$$$$$$") && (second.Contains("$$$$$$")))
                        {
                            Console.WriteLine($"ticket \"{item}\" - 6$");
                            continue;
                        }
                    }
                    else if(WinChavka(item))
                    {
                        string first = item.Substring(0, 10);
                        string second = item.Substring(10);
                        if (first.Contains("^^^^^^^^^") && (second.Contains("^^^^^^^^^")))
                        {
                            Console.WriteLine($"ticket \"{item}\" - 9^");
                            continue;
                        }
                        else if (first.Contains("^^^^^^^^") && (second.Contains("^^^^^^^^")))
                        {
                            Console.WriteLine($"ticket \"{item}\" - 8^");
                            continue;
                        }
                        else if (first.Contains("^^^^^^^") && (second.Contains("^^^^^^^")))
                        {
                            Console.WriteLine($"ticket \"{item}\" - 7^");
                            continue;
                        }
                        else if (first.Contains("^^^^^^") && (second.Contains("^^^^^^")))
                        {
                            Console.WriteLine($"ticket \"{item}\" - 6^");
                            continue;
                        }
                    }
                    else if(WinHashTag(item))
                    {
                        string first = item.Substring(0, 10);
                        string second = item.Substring(10);
                        if (first.Contains("#########") && (second.Contains("#########")))
                        {
                            Console.WriteLine($"ticket \"{item}\" - 9#");
                            continue;
                        }
                        else if (first.Contains("########") && (second.Contains("########")))
                        {
                            Console.WriteLine($"ticket \"{item}\" - 8#");
                            continue;
                        }
                        else if (first.Contains("#######") && (second.Contains("#######")))
                        {
                            Console.WriteLine($"ticket \"{item}\" - 7#");
                            continue;
                        }
                        else if (first.Contains("######") && (second.Contains("######")))
                        {
                            Console.WriteLine($"ticket \"{item}\" - 6#");
                            continue;
                        }
                    }
                    else if(WinMonkey(item))
                    {
                        string first = item.Substring(0, 10);
                        string second = item.Substring(10);
                        if (first.Contains("@@@@@@@@@") && (second.Contains("@@@@@@@@@")))
                        {
                            Console.WriteLine($"ticket \"{item}\" - 9@");
                            continue;
                        }
                        else if (first.Contains("@@@@@@@@") && (second.Contains("@@@@@@@@")))
                        {
                            Console.WriteLine($"ticket \"{item}\" - 8@");
                            continue;
                        }
                        else if (first.Contains("@@@@@@@") && (second.Contains("@@@@@@@")))
                        {
                            Console.WriteLine($"ticket \"{item}\" - 7@");
                            continue;
                        }
                        else if (first.Contains("@@@@@@") && (second.Contains("@@@@@@")))
                        {
                            Console.WriteLine($"ticket \"{item}\" - 6@");
                            continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{item}\" - no match");
                    }
                }
                else
                {
                    Console.WriteLine("invalid ticket");
                }
            }
        }

        private static bool WinMonkey(string item)
        {
            string first = item.Substring(0, 10);
            string second = item.Substring(10);
            if (first.Contains("@@@@@@") && (second.Contains("@@@@@@")))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool WinHashTag(string item)
        {
            string first = item.Substring(0, 10);
            string second = item.Substring(10);
            if (first.Contains("######") && (second.Contains("######")))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool WinChavka(string item)
        {
            string first = item.Substring(0, 10);
            string second = item.Substring(10);
            if (first.Contains("^^^^^^") && (second.Contains("^^^^^^")))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool windDollar(string item)
        {
            string first = item.Substring(0, 10);
            string second = item.Substring(10);
            if(first.Contains("$$$$$$")&&(second.Contains("$$$$$$")))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool WinJackop(string item)
        {
            if (item.Contains("@@@@@@@@@@@@@@@@@@@@"))
            {
                return true;
            }
            else if (item.Contains("####################"))
            {
                 return true;
            }
            else if (item.Contains("$$$$$$$$$$$$$$$$$$$$"))
            {
                return true;
            }
            else if (item.Contains("^^^^^^^^^^^^^^^^^^^^"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
