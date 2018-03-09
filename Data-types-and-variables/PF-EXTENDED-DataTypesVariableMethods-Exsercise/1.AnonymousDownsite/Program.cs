using System;
using System.Linq;
using System.Numerics;

namespace _1.AnonymousDownsite
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberWebsites = int.Parse(Console.ReadLine());
            int numberSequrityKey = int.Parse(Console.ReadLine());
            decimal totalMoneyLost = 0;
            int countSite = 0;
            string[] sites = new string[numberWebsites];
            BigInteger securityToken = 0;
            for (int i = 0; i < numberWebsites; i++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                countSite++;
                string name = input[0];
                sites[i] = name;
                decimal siteVistits = decimal.Parse(input[1]);
                decimal pricePerVisit = decimal.Parse(input[2]);
                decimal siteLoss = siteVistits * pricePerVisit;
                totalMoneyLost += siteLoss;
            }
            if(sites.Length>0)
            {
                foreach (var item in sites)
            {
                Console.WriteLine(item);
            }
            }
            Console.WriteLine("Total Loss: {0:f20}",totalMoneyLost);
            securityToken = BigInteger.Pow(numberSequrityKey, countSite);
            Console.WriteLine("Security Token: {0}",securityToken);
        }
    }
}
