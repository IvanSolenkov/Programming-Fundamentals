using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixEmails
{
    class FixEmails
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var mailBook = new Dictionary<string, string>();
            while (name != "stop")
            {
                var mail = Console.ReadLine();
                var domain = mail.ToCharArray();
                domain = domain.Reverse().Take(2).ToArray();
                
                string finalDomain = new string(domain);

                if (finalDomain == "su" || finalDomain == "ku")
                {
                    mailBook.Remove(name);
                }
                else
                {
                    mailBook[name] = mail;
                }
                name = Console.ReadLine();
            }
            foreach (var line in mailBook.Keys)
            {
                Console.WriteLine(string.Join(" -> ", line, mailBook[line]));
            }
        }
    }
}