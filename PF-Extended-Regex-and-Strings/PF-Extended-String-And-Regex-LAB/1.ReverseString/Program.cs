using System;

namespace _1.ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] arr = input.ToCharArray();
            Array.Reverse(arr);
            string result = new string(arr);
            Console.WriteLine(string.Join("",result));
        }
    }
}
