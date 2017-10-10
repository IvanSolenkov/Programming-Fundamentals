using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem19.TheaThePhotographer
{
    class TheaThePhotographer
    {
        static void Main(string[] args)
        {
            long pictures = long.Parse(Console.ReadLine());
            long secondsPerPicture = long.Parse(Console.ReadLine());
            long filterPercent = long.Parse(Console.ReadLine());
            long uploadTimePerPicture = long.Parse(Console.ReadLine());

            long filterSeconds = pictures * secondsPerPicture;
            double filterPics = (long)Math.Ceiling(filterPercent * pictures / 100.0);
            double uploadSeconds = (filterPics * uploadTimePerPicture);
            long totalSeconds = filterSeconds + (long)uploadSeconds;


            TimeSpan time = TimeSpan.FromSeconds(totalSeconds);
            string result = time.ToString(@"d\:hh\:mm\:ss");
            Console.WriteLine(result);  


        }
    }
}
