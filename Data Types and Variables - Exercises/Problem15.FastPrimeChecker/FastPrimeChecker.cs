using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem15.FastPrimeChecker
{
    class FastPrimeChecker
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 2; i <= n; i++)
            {
                bool theNumber = true;
                for (int m = 2; m <= Math.Sqrt(i); m++)
                {
                    if (i % m == 0)
                    {
                        theNumber = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {theNumber}");
            }
        }
    }
}
