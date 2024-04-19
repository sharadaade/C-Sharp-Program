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
            double celsius = double.Parse(Console.ReadLine());
            
            double fahrenheit = (double)(celsius * 9) / 5 + 32;

            //double result = (int)fahrenheit;
            Console.WriteLine("Temprature in Fahrenheit: {0}", fahrenheit);
        }
    }
}
