using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Program
{
    internal class CelsiusToFahrenheit
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the temprature in celsius : ");
            int celsius = int.Parse(Console.ReadLine());
            
            int fahrenheit = (celsius * 9) / 5 + 32;

            Console.WriteLine("Temprature in Fahrenheit: {0}", fahrenheit);

        }
    }
}
