using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01.CountWorkingDays
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            DateTime startDate = DateTime
                .ParseExact(input1, "dd-MM-yyyy", System.Globalization
                .CultureInfo
                .InvariantCulture);
            DateTime endDate = DateTime
                .ParseExact(input2, "dd-MM-yyyy", System.Globalization
                .CultureInfo
                .InvariantCulture);

            DateTime[] officialHolidays =
            {
                DateTime
                .ParseExact("01-01-1970", "dd-MM-yyyy", System.Globalization
                .CultureInfo
                .InvariantCulture),
                DateTime
                .ParseExact("03-03-1970", "dd-MM-yyyy", System.Globalization
                .CultureInfo
                .InvariantCulture),
                DateTime
                .ParseExact("01-05-1970", "dd-MM-yyyy", System.Globalization
                .CultureInfo
                .InvariantCulture),
                DateTime
                .ParseExact("06-05-1970", "dd-MM-yyyy", System.Globalization
                .CultureInfo
                .InvariantCulture),
                DateTime
                .ParseExact("24-05-1970", "dd-MM-yyyy", System.Globalization
                .CultureInfo
                .InvariantCulture),
                DateTime
                .ParseExact("06-09-1970", "dd-MM-yyyy", System.Globalization
                .CultureInfo
                .InvariantCulture),
                DateTime
                .ParseExact("22-09-1970", "dd-MM-yyyy", System.Globalization
                .CultureInfo
                .InvariantCulture),
                DateTime
                .ParseExact("01-11-1970", "dd-MM-yyyy", System.Globalization
                .CultureInfo
                .InvariantCulture),
                DateTime
                .ParseExact("24-12-1970", "dd-MM-yyyy", System.Globalization
                .CultureInfo
                .InvariantCulture),
                DateTime
                .ParseExact("25-12-1970", "dd-MM-yyyy", System.Globalization
                .CultureInfo
                .InvariantCulture),
                DateTime
                .ParseExact("26-12-1970", "dd-MM-yyyy", System.Globalization
                .CultureInfo
                .InvariantCulture), 
        };

            int countOfWorkingDays = 0;

            for (DateTime currentDate = startDate; currentDate <= endDate; currentDate=currentDate.AddDays(1))
            {
                if ((currentDate.DayOfWeek != DayOfWeek.Saturday) && (currentDate.DayOfWeek != DayOfWeek.Sunday))
                {
                    bool isHoliday = false;

                    foreach (var day in officialHolidays)
                    {
                        if (day.Day == currentDate.Day && day.Month == currentDate.Month)
                        {
                            isHoliday = true;
                            break;
                        }
                    }
                    if (!isHoliday)
                    {
                        countOfWorkingDays++;
                    }
                }
            }
            Console.WriteLine(countOfWorkingDays);
        }
    }
}
