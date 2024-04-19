using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Program
{
    internal class CicleCalculation
    {
        static void Main(string[] args)
        {
            const float PI = 3.14f;

            Console.Write("Enter the radius of circle : ");
            float radius = float.Parse(Console.ReadLine());

            float diameter = 2 * radius;
            float circumference = 2 * PI * radius;
            float area = PI * radius * radius;

            Console.WriteLine("Diameter of circle is : {0}",diameter);
            Console.WriteLine("Circumference of circle is : {0}",circumference);
            Console.WriteLine("Area of circle is : {0}",area);

        }
    }
}
