using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rohan_Lab2
{
    internal class PrimeOrNot
    {
        public static void Main(string[] args) {
            Console.WriteLine("Enter any number ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine("The given number is not prime");
                    Console.ReadKey();
                    return;
                }
            }
            Console.WriteLine("The given number is prime");
            Console.ReadKey();  
        }
    }
}
