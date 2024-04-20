using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Program
{
    internal class PowerOfNumber
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the base number : ");
            int baseNum = int.Parse(Console.ReadLine());

            Console.Write("Enter the index number : ");
            int indexNum = int.Parse(Console.ReadLine());

            int result = (int)Math.Pow(baseNum, indexNum);

            Console.WriteLine(result);
        }
    }
}
