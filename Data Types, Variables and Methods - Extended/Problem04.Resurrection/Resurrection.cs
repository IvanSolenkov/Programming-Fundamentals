using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04.Resurrection
{
    class Resurrection
    {
        static void Main(string[] args)
        {
            int amoutOfPhoenixes = int.Parse(Console.ReadLine());
            List<decimal> result = new List<decimal>();
            while (amoutOfPhoenixes --> 0)
            {
                long bodyLength = long.Parse(Console.ReadLine());
                decimal bodyWidth = decimal.Parse(Console.ReadLine());
                long lengthOfOneWing = long.Parse(Console.ReadLine());

                decimal totalYears = (bodyLength * bodyLength) * (bodyWidth + (2 * lengthOfOneWing));
                result.Add(totalYears);

            }
            Console.WriteLine(String.Join("\n",result));
        }
    }
}
