using System;
using System.Linq;

namespace _3.TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] banned = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string text = Console.ReadLine();
            foreach (var word in banned)
            {
                int numAsterix = word.Length;
                text = text.Replace(word, new string('*', numAsterix));
            }
            Console.WriteLine(text);
        }
    }
}
