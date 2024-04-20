using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Program
{
    internal class ArithmeticOperation
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number : ");
            double firstNumber = double.Parse(Console.ReadLine());

            Console.Write("Enter the seccond number : ");
            double seccondNumber = double.Parse(Console.ReadLine());

            double addition = firstNumber + seccondNumber;
            double substraction = firstNumber - seccondNumber;
            double multiplication = firstNumber * seccondNumber;
            double division = firstNumber / seccondNumber;
            double remainder = firstNumber % seccondNumber;

            Console.WriteLine("Addition is : " + addition);
            Console.WriteLine("Substraction is : " + substraction);
            Console.WriteLine("Multiplication is : " + multiplication);
            Console.WriteLine("Division is : " + division);
            Console.WriteLine("Remainder is : " + remainder);

        }
    }
}
