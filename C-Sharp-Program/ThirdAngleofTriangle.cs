using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Program
{
    internal class ThirdAngleofTriangle
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first angle : ");
            int firstAngle = int.Parse(Console.ReadLine());

            Console.Write("Enter the first angle : ");
            int secondAngle = int.Parse(Console.ReadLine());

            int twoAngle = firstAngle + secondAngle;

            int thirdAngle = 180 - twoAngle;

            Console.WriteLine("Third angle of triangle is : {0}",thirdAngle);
        }
    }
}
