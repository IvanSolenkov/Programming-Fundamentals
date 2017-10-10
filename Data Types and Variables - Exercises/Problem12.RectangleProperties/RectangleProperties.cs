    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Problem12.RectangleProperties
    {
        class RectangleProperties
        {
            static void Main(string[] args)
            { 
                char symbol = char.Parse(Console.ReadLine());

                if (symbol.Equals('a') || symbol.Equals('e') || symbol.Equals('i') || symbol.Equals('o') ||
                    symbol.Equals('u') || symbol.Equals('y'))
                {
                    Console.WriteLine("vowel");
                }
                else if (symbol.Equals('0') || symbol.Equals('1') || symbol.Equals('2') || symbol.Equals('3') ||
                    symbol.Equals('4') || symbol.Equals('5') || symbol.Equals('6') || symbol.Equals('7') ||
                        symbol.Equals('8') || symbol.Equals('9'))
                {
                    Console.WriteLine("digit");
                }
                else
                {
                    Console.WriteLine("other");
                }
            }
        }
    }
