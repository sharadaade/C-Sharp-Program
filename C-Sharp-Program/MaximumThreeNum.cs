using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Program
{
    internal class MaximumThreeNum
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number : ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the number : ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Enter the number : ");
            int num3 = int.Parse(Console.ReadLine());
            
            // Logic
            if(num1 > num2 && num1 > num3) 
            {
                Console.WriteLine("Maximum number is : {0}",num1);
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("Maximum number is : {0}",num2);
            }
            else
            {
                Console.WriteLine("Maximum number is : {0}", num3);
            }
        }
    }
}
