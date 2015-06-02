using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemOneApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Lower Limit : ");
            int lowerLimit = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Enter Upper Limit : ");
            int upperLimit = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("\n\nAll the Integer between Lower Limit and Uppper Limit : ");
            Console.Write("\n\t");
            for (int i = lowerLimit; i <= upperLimit; i++)
            {
                Console.Write(i+", ");
            }

            Console.ReadKey();
        }
    }
}
