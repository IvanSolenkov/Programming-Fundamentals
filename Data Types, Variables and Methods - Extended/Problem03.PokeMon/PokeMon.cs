using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03.PokeMon
{
    class PokeMon
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            decimal inHalf = n * 0.5m;

            int targetsPocked = 0;

            while (n >= m)
            {
                n -= m;
                targetsPocked++;
                if (inHalf == n && y > 0)
                {
                    n /= y;
                }
            }
            Console.WriteLine(n);
            Console.WriteLine(targetsPocked);
        }
    }
}
