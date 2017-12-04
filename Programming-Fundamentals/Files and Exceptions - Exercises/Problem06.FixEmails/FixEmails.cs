using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Problem06.FixEmails
{
    class FixEmails
    {
        static void Main()
        {
            var lines = File.ReadAllLines("input.txt");
            File.Delete("output.txt");
            for (int i = 0; i < lines.Length; i+=2)
            {
                if (lines[i] == "stop" || lines[i + 1] == "stop")
                {
                    break;
                }

                var name = lines[i];
                var emails = lines[i + 1];
                if (emails.EndsWith(".uk") || emails.EndsWith(".us"))
                {
                    continue;
                }

                var output = $"{name} -> {emails}" + Environment.NewLine;

                File.AppendAllText("output.txt", output);
            }
        }
    }
}
