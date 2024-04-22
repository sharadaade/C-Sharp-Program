using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Program
{
    internal class WhileSumOddNum
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the end num : ");
            int num = Convert.ToInt32(Console.ReadLine());

            int i = 1;
            int sum = 0;
            while(i <= num)
            {
                if(i % 2 != 0)
                {
                    sum = sum + i;
                }
                i++;
            }

            Console.WriteLine("The sum of odd number is : {0}",sum);
        }
    }
}
