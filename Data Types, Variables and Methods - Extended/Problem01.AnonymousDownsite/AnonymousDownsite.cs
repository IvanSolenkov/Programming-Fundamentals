using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Problem01.AnonymousDownsite
{
    class AnonymousDownsite
    {
        static void Main(string[] args)
        {
            int numberOfWebsites = int.Parse(Console.ReadLine());
            int securityKey = int.Parse(Console.ReadLine());
            decimal totalLoss = 0;
            List<string> website = new List<string>();
            for (int i = 0; i < numberOfWebsites; i++)
            {
                string[] websites = Console.ReadLine().Split().ToArray();
                string siteName = websites[0];
                long siteVisits = long.Parse(websites[1]);
                decimal siteCommercialPricePerVisit = decimal.Parse(websites[2]);

                decimal siteLoss = siteVisits * siteCommercialPricePerVisit;
                totalLoss += siteLoss;
                website.Add(websites[0]);
            }
            Console.WriteLine(String.Join("\n", website));
            Console.WriteLine($"Total Loss: {totalLoss:F20}");
            Console.WriteLine($"Security Token: {BigInteger.Pow(securityKey,numberOfWebsites)}");
        }
    }
}
