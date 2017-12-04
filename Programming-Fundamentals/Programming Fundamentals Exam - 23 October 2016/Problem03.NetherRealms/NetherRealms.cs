using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public class NetherRealms
{
    public static void Main()
    {
        var demonsNames = Console.ReadLine()
            .Split(',')
            .Select(x => x.Trim())
            .ToArray();

        var resutl = new StringBuilder();

        foreach (var name in demonsNames.OrderBy(x => x))
        {
            var health = Regex.Matches(name, @"[^\d\.\-\+\*\/]")
               .Cast<Match>().Select(match => match.Value)
               .Select(x => (int)char.Parse(x))
               .Sum();

            var damage = Regex
               .Matches(name, @"[-|+]*[0.0-9]+")
               .Cast<Match>().Select(match => match.Value)
               .Select(double.Parse)
               .Sum();

            var asterisks = name.Count(x => x.Equals('*'));
            var slashes = name.Count(x => x.Equals('/'));

            for (int i = 0; i < Math.Max(asterisks, slashes); i++)
            {
                damage = i < asterisks ? damage *= 2 : damage;
                damage = i < slashes ? damage /= 2.0 : damage;
            }

            resutl.AppendLine($"{name} - {health} health, {damage:f2} damage ");
        }

        Console.Write(resutl.ToString());
    }
}