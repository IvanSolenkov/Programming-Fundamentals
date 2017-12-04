using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04.NumbersInReversed
{
    class NumbersInReversedOrder
    {
        static void Main(string[] args)
        {
            double d = double.Parse(Console.ReadLine());
            ReversedOrder(d);
        }
        static void ReversedOrder(double d)
        {
            {
                Console.WriteLine("{0}", ReverseNumber(d));
            }

            double ReverseNumber(double number)
            {
                return double.Parse(ReverseString(number.ToString()));
            }

            string ReverseString(string s)
            {
                char[] charArray = s.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            }
        }
    }
}
