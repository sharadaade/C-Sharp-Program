using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Program
{
    internal class LeapYear
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Year : ");
            int year = int.Parse(Console.ReadLine());

            if(year % 4 == 0)
            {
                Console.WriteLine("{0} is leap year", year);
            }
            else
            {
                Console.WriteLine("{0} is NOT leap year",year);
            }
        }
    }
}
