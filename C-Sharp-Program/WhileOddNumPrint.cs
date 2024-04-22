using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Program
{
    internal class WhileOddNumPrint
    {
        static void Main(string[] args)
        {
            Console.Write("Enter end number : ");
            int num = int.Parse(Console.ReadLine());

            int i = 1;
            while(i <= num)
            {
                if(i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
        }
    }
}
