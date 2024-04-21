using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Program
{
    internal class FahrenheitToCelsius
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the temprature in Fahrenheit : ");
            int fehrenheit = int.Parse(Console.ReadLine());

            int celsius = (fehrenheit - 32) * 5 / 9;

            Console.WriteLine("Temprature Fehrenheit to Celsius is {0} F",celsius);
        }
    }
}
