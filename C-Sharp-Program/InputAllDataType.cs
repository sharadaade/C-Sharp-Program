using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Program
{
    internal class InputAllDataType
    {
        static void Main(string[] args)
        {
            Console.Write("Enter int number : ");
            int intNum = int.Parse(Console.ReadLine());

            Console.Write("Enter float nnumber : ");
            float floatNum = float.Parse(Console.ReadLine());

            Console.Write("Enter double number : ");
            double doubleNumer = double.Parse(Console.ReadLine());

            Console.Write("Enter decimal number : ");
            decimal decimalNumber = decimal.Parse(Console.ReadLine());

            Console.Write("Enter your name : ");
            string yourName = Console.ReadLine();

            Console.Write("Enter your gender(M/F) : ");
            char gender = char.Parse(Console.ReadLine());

            Console.WriteLine(intNum);
            Console.WriteLine(floatNum);
            Console.WriteLine(doubleNumer);
            Console.WriteLine(decimalNumber);
            Console.WriteLine(yourName);
            Console.WriteLine(gender);


        }
    }
}
