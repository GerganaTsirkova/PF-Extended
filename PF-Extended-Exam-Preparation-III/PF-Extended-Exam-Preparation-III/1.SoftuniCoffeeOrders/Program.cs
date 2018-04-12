using System;
using System.Collections.Generic;
using System.Globalization;

namespace _1.SoftuniCoffeeOrders
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal totalPrice = 0;
            List<string> result = new List<string>();
            for (int i = 0; i < n; i++)
            {
                decimal priseCapsule = decimal.Parse(Console.ReadLine());
                string s = Console.ReadLine();
                DateTime orderDate = DateTime.ParseExact(s, "d/M/yyyy", CultureInfo.InvariantCulture);
                decimal days = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);
                decimal capsuleCount = decimal.Parse(Console.ReadLine());
                decimal currentPrice = (priseCapsule * (days * capsuleCount));
                result.Add($"The price for the coffee is: ${currentPrice:f2}");
                totalPrice += currentPrice;
            }
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}
