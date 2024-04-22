using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Program
{
    internal class WhileOneToN
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the end number : ");
            int num = int.Parse(Console.ReadLine());

            int i = 1;
            while(i <= num )
            {
                Console.WriteLine(i);
                i++;
            }

        }
    }
}
