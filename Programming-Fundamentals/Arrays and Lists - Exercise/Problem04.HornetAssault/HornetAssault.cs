namespace _03HornetAssault
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class HornetAssault
    {
        public static void Main()
        {
            var listBees = Console.ReadLine().
                                Split(new char[] { ' ' }
                                , StringSplitOptions
                                .RemoveEmptyEntries)
                                .Select(long.Parse)
                                .ToList();

            var listHornets = Console.ReadLine().
                               Split(new char[] { ' ' }
                               , StringSplitOptions
                               .RemoveEmptyEntries)
                               .Select(long.Parse)
                               .ToList();

            long sumHornets = listHornets.Sum();

            for (int i = 0; i < listBees.Count; i++)
            {
                if (listBees[i] >= sumHornets)
                {
                    listBees[i] -= sumHornets;
                    listHornets.RemoveAt(0);
                }
                else
                {
                    listBees[i] = 0;
                }

                if (listHornets.Count == 0)
                {
                    break;
                }

                sumHornets = listHornets.Sum();
            }

            if (listBees.Any(e => e > 0))
            {
                for (int i = 0; i < listBees.Count; i++)
                {
                    if (listBees[i] > 0)
                    {
                        Console.Write(listBees[i] + " ");
                    }
                }
                Console.WriteLine();
            }
            else
            {
                foreach (var hornet in listHornets)
                {
                    Console.Write(hornet + " ");
                }
            }
        }
    }
}