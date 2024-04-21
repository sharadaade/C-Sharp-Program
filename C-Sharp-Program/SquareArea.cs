using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Program
{
    internal class SquareArea
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the side of square : ");
            int side = int.Parse(Console.ReadLine());

            int area = side * side;

            Console.WriteLine("The area of square is : {0}",area);
        }
    }
}
