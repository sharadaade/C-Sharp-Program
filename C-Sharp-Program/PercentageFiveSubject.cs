using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Program
{
    internal class PercentageFiveSubject
    {
        static void Main(string[] args)
        {
            int obtainedMarks = 0;
            int[] arr = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter subject mark : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\n--- Subject marks ---");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Subject marks : {0}",arr[i]);
                obtainedMarks = obtainedMarks + arr[i];
            }

            int average = obtainedMarks / 5;

            //double percentage = ((double)obtainedMarks / 500) * 100;

            int percentage = (obtainedMarks / 500) * 100;

            Console.WriteLine("Total marks is : {0}", obtainedMarks);
            Console.WriteLine("Average marks is : {0}",average);
            Console.WriteLine("Percentage is : {0}", percentage);
        }
    }
}
