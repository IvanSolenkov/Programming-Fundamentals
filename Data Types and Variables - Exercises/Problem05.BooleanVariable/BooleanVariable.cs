using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem05.BooleanVariable
{
    class BooleanVariable
    {
        static void Main(string[] args)
        {
            string theWord = Console.ReadLine();

            if (theWord == "True")
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
