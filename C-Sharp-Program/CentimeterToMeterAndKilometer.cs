using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Program
{
    internal class CentimeterToMeterAndKilometer
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length in centimeter : ");
            float centimeter = float.Parse(Console.ReadLine());

            float inMeter = centimeter / 100;
            float inKilometer = inMeter / 100000;

            Console.WriteLine("In meter = {0} meter",inMeter);
            Console.WriteLine("In kilometer = {0} kilometer",inKilometer);

        }
    }
}
