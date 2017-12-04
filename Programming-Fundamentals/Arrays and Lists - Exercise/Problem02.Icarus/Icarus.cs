using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class Program
{
    static void Main()
    {
        var sequence =
            Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();
        var index = int.Parse(Console.ReadLine());
        var commands =
            Console.ReadLine()
            .Split()
            .ToList();
        var damage = 0;
        while (commands[0] != "Supernova")
        {
            var turn = commands[0];
            if (turn == "left")
            {
                var steps = int.Parse(commands[1]);
                for (int i = 0; i < steps; i++)
                {
                    index--;
                    if (index == -1)
                    {
                        index = sequence.Count - 1;
                        damage++;
                    }
                    sequence[index] -= 1 + damage;
                }
            }
            else if (turn == "right")
            {
                var steps = int.Parse(commands[1]);
                for (int i = 0; i < steps; i++)
                {
                    index++;
                    if (index > sequence.Count - 1)
                    {
                        index = 0;
                        damage++;
                    }
                    sequence[index] -= 1 + damage;
                }
            }

            commands = Console.ReadLine().Split().ToList();
        }

        Console.WriteLine(string.Join(" ", sequence));
    }
}