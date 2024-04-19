using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Program
{
    internal class PerimeterOfRectangle
    {
        static void Main(string[] args)
        {
            // Write the perimeter of rectangle
            // formula => Perimeter = 2 * ( length + width )

            Console.Write("Enter the length : ");
            int length = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the width : ");
            int width = Convert.ToInt32(Console.ReadLine());

            int perimeter = 2 * (length + width);

            Console.Write("Perimeter of rectangle is : " + perimeter);

        }
    }
}
