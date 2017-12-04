using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem07.ExchangeVariableValues
{
    class ExchangeVariableValues
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber;
            Console.WriteLine("Before:");
            Console.WriteLine("a = {0}",firstNumber);
            Console.WriteLine("b = {0}",secondNumber);

            thirdNumber = firstNumber;
            firstNumber = secondNumber;
            secondNumber = firstNumber;
            
            Console.WriteLine("After:");
            Console.WriteLine("a = {0}", firstNumber);
            Console.WriteLine("b = {0}", thirdNumber);
        }
    }
}
