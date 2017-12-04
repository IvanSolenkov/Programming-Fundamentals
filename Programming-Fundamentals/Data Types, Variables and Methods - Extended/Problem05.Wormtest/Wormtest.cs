using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem05.Wormtest
{
    class Wormtest
    {
        static void Main(string[] args)
        {
            double lengthInMeters = double.Parse(Console.ReadLine());
            double widthInCentimetres = double.Parse(Console.ReadLine());

            double lengthInCentimetres = lengthInMeters * 100;
            double remainderOfTheDivision = lengthInCentimetres % widthInCentimetres;

            if (remainderOfTheDivision <= 0 || widthInCentimetres == 0)
            {
                double product = lengthInCentimetres * widthInCentimetres;
                Console.WriteLine($"{product:F2}");
            }
            else
            {
                double result = (lengthInCentimetres / widthInCentimetres) * 100;
                Console.WriteLine($"{result:F2}%");
            }
        }
    }
}
