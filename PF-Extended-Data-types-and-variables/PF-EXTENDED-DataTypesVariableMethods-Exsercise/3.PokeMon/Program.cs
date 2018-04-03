using System;

namespace _3.PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int initialPower = pokePower;
            int countPoke = 0;
 
            while (true)
            {
                
                if (pokePower < distance)
                {
                    break;
                }
                pokePower -= distance;
                countPoke++;
                if ((pokePower == initialPower/2.00)&&(exhaustionFactor != 0))
                {
                    pokePower /= exhaustionFactor;
                }
                
            }
            Console.WriteLine(pokePower);
            Console.WriteLine(countPoke);
        }
    }
}
