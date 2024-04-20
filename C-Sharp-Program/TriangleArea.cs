using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Program
{
    internal class TriangleArea
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the base of triangle : ");
            double baseAngle = double.Parse(Console.ReadLine());

            Console.Write("Enter the height of triangle : ");
            double heightAngle = double.Parse(Console.ReadLine());

            double areaAngle = (baseAngle *heightAngle) / 2;

            Console.WriteLine("Area of triangle is : {0}",areaAngle);


        }
    }
}
