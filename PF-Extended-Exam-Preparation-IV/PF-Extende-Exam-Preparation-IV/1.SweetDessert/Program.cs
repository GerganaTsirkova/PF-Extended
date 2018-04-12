using System;

namespace _1.SweetDessert
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal cash = decimal.Parse(Console.ReadLine());
            int numberGuest = int.Parse(Console.ReadLine());
            decimal portionNeeded = numberGuest % 6;
            if(portionNeeded==0)
            {
                portionNeeded = numberGuest / 6;
            }
            else
            {
                portionNeeded = numberGuest / 6 + 1;
            }
            decimal priceBanana = decimal.Parse(Console.ReadLine());
            decimal priceEggs = decimal.Parse(Console.ReadLine());
            decimal priceBerries = decimal.Parse(Console.ReadLine());
            decimal neededMoney = (2*priceBanana+4*priceEggs+0.2M*priceBerries)*portionNeeded;
            if(cash>=neededMoney)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {neededMoney:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {neededMoney-cash:f2}lv more.");
            }
        }
    }
}
