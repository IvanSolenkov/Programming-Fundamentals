using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.ArrayManipulator
{
    class ArrayManipulator
    {
        static void Main(string[] args)
        {
            var inputTokens = Console.ReadLine().Split().Select(int.Parse).ToList();
            var input = Console.ReadLine();

            while (input != "print")
            {
                var command = input.Split().ToList();

                if (command[0] == "add")
                {
                    var index = int.Parse(command[1]);
                    var element = int.Parse(command[2]);
                    inputTokens.Insert(index, element);
                }
                else if (command[0] == "addMany")
                {
                    var index = int.Parse(command[1]);
                    var numbersToAdd = command.Skip(2).Select(int.Parse).ToList();
                    inputTokens.InsertRange(index, numbersToAdd);
                }
                else if (command[0] == "contains")
                {
                    var element = int.Parse(command[1]);
                    if (inputTokens.Contains(element))
                    {
                        Console.WriteLine(inputTokens.IndexOf(element));
                    }
                    else
                    {
                        Console.WriteLine("-1");
                    }
                }
                else if (command[0] == "remove")
                {
                    var index = int.Parse(command[1]);
                    inputTokens.RemoveAt(index);
                }
                else if (command[0] == "shift")
                {
                    //var rotations = int.Parse(command[1]);
                    //for (int i = 0; i < rotations; i++)
                    //{
                    //    RotateList(inputTokens);
                    //}
                    int number = int.Parse(command[1]);
                    var rem = inputTokens.Take(number).ToList();
                    inputTokens.RemoveRange(0, number);
                    inputTokens.AddRange(rem);
                }
                else if (command[0] == "sumPairs")
                {
                    inputTokens = SumPairs(inputTokens);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ", inputTokens)}]");

        }
        static List<int> RotateList(List<int> list)
        {
            var lastElement = list[0];

            for (int i = 0; i < list.Count - 1; i++)
            {
                list[i] = list[i + 1];
            }
            list[list.Count - 1] = lastElement;

            return list;
        }

        static List<int> SumPairs(List<int> list)
        {
            var result = new List<int>();

            if (list.Count % 2 == 0)
            {
                for (int i = 0; i < list.Count - 1; i += 2)
                {
                    result.Add(list[i] + list[i + 1]);
                }
            }
            else
            {
                for (int i = 0; i < list.Count - 1; i += 2)
                {
                    result.Add(list[i] + list[i + 1]);
                }
                result.Add(list[list.Count - 1]);
            }

            return result;
        }
    }
}