using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Program
{
    internal class DayToYearWeekDay
    {
        static void Main(string[] args)
        {
            Console.Write("Enter day : ");
            int nday = int.Parse(Console.ReadLine());

            int year = nday / 365;
            int week = (nday % 365) / 7;
            int day = (nday % 365) / 30;

            Console.WriteLine(year);
            Console.WriteLine(week);
            Console.WriteLine(day);
        }
    }
}
