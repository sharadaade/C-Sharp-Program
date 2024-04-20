using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Program
{
    internal class SquarRoot
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number : ");
            int number = int.Parse(Console.ReadLine());

            int result = (int)Math.Sqrt(number);

            Console.WriteLine("Square root of {0} is {1}",number,result);
        }
    }
}
