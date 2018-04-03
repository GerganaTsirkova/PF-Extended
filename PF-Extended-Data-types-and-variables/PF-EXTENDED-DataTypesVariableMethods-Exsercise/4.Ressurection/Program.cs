using System;

namespace _4.Ressurection
{
    class Program
    {
        static void Main(string[] args)
        {
            int numFeni = int.Parse(Console.ReadLine());
            for (int i = 0; i < numFeni; i++)
            {
                long bodyLen = long.Parse(Console.ReadLine());
                decimal bodyWidth = decimal.Parse(Console.ReadLine());
                int wingLen = int.Parse(Console.ReadLine());
                decimal yearsToReincarnate = (decimal)(Math.Pow(bodyLen, 2))*(wingLen*2+bodyWidth);
                Console.WriteLine(yearsToReincarnate);
            }
        }
    }
}
