using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rohan_Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number");

            int num=int.Parse(Console.ReadLine());
            
            if (num % 2 == 0)
            {
                Console.WriteLine("the number is even");
            }
            else
            {
                Console.WriteLine("the number is odd");
            }

            Console.ReadKey();

        }
    }
}
