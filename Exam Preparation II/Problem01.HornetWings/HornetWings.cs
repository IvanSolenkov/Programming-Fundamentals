using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01.HornetWings
{
    class HornetWings
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            double distance = (n / 1000) * m;

            double hornetFlaps = n / 100;

            double result = (n / p) * 5;

            double finalResult = result + hornetFlaps;
            Console.WriteLine($"{distance:F2} m.");
            Console.WriteLine($"{finalResult} s.");

        }
    }
}
