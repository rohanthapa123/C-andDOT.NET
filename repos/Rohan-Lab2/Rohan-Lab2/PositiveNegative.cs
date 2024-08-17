using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rohan_Lab2
{
    internal class PositiveNegative
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter any NUmber");
            int num = int.Parse(Console.ReadLine());

            if(num>0)
            {
                Console.WriteLine("The number is Positive");
            }
            else if(num<0)
            {
                Console.WriteLine("The number is negative");
            }
            else
            {
                Console.WriteLine("The number is zero");
            }
            Console.ReadKey();

       }
    }
}
