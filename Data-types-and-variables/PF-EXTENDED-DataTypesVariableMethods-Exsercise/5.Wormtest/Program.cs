using System;

namespace _5.Wormtest
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenMeters = int.Parse(Console.ReadLine());
            double widthCentimeters = double.Parse(Console.ReadLine());
            int lenCentimeters = lenMeters * 100;
            double remainder = lenCentimeters % widthCentimeters;
            if((remainder==0)||(widthCentimeters<=0))
            {
                Console.WriteLine("{0:f2}",lenCentimeters*widthCentimeters);
            }
            else
            {
                if((lenCentimeters==0)||(lenMeters==0))
                {
                    Console.WriteLine("0%");
                }
                else
                {
                    Console.WriteLine("{0:f2}%", (lenCentimeters / widthCentimeters) * 100);
                }
                
            }
        }
    }
}
