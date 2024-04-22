using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Program
{
    internal class ForDigitCount
    {
        static void Main(string[] args)
        {
            int count = 0;

            Console.Write("Enter number : ");
            int num = int.Parse(Console.ReadLine());

            

           for(int i = 0;num != 0;i++)
           {
                count++;
                num = num / 10;
           }

           Console.WriteLine("Digit count is : {0}",count);

        }
    }
}
