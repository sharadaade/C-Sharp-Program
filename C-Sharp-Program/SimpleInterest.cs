using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Program
{
    internal class SimpleInterest
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the principle : ");
            int principle = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the rate of interest in % (per anum) : ");
            int interest = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the time : ");
            int time = Convert.ToInt32(Console.ReadLine());

            int simpleInterest = (principle * interest * time);

            Console.WriteLine("Simple interest is : {0}",simpleInterest);
                                                                         
        }
    }
}
