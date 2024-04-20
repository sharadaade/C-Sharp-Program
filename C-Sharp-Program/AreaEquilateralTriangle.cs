using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Program
{
    internal class AreaEquilateralTriangle
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the side of triangle : ");
            double side = int.Parse(Console.ReadLine());

            double triangleArea = (Math.Sqrt(3) / 4) * (side * side);

            Console.WriteLine("Area of equilateral triangle is : {0}",triangleArea);
        }
    }
}
