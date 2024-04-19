using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Program
{
    internal class AdditionOfTwoNumber
    {
        static void Main(string[] args)
        {
            int firstNumber, secondNumber, result;

            Console.Write("Enter the first number : ");
            firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number : ");
            secondNumber = int.Parse(Console.ReadLine());

            result = firstNumber + secondNumber;

            Console.WriteLine("Addition of {0} and {1} is : {2}",firstNumber,secondNumber,result);
        }
    }
}
