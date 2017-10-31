using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01.SinoTheWalkerr
{
    class SoftuniCoffeOrders
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            decimal price = 0;
            decimal totalPrice = 0;
            List<decimal> currentList = new List<decimal>();

            for (int i = 0; i < n; i++)
            {
                decimal pricePerCapluse = decimal.Parse(Console.ReadLine());
                DateTime date = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", null);
                int capsule = int.Parse(Console.ReadLine());
                price = readOrderAndCalculatePrice(pricePerCapluse,date,capsule);
                totalPrice += price;
                currentList.Add(price);
            }

            for (int i = 0; i < currentList.Count; i++)
            {
                Console.WriteLine($"The price for the coffee is: ${currentList[i]:F2}");
            }
            Console.WriteLine($"Total: ${totalPrice:F2}");
        }
        static decimal readOrderAndCalculatePrice(decimal price, DateTime date, int capsulesCount)
        {
            decimal daysInMonth = DateTime.DaysInMonth(date.Year, date.Month);
            decimal totalPrice = (daysInMonth * capsulesCount) * (decimal)price;
            return totalPrice;
        }

    }
}
