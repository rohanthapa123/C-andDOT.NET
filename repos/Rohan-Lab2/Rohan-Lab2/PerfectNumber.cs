using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rohan_Lab2
{
    internal class PerfectNumber
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter any number");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            for(int i = 1; i < num;  i++)
            {
                if(num % i == 0)
                {
                    sum += i;
                }
            }
            if(num == sum)
            {
                Console.WriteLine("The number is perfect");
            }
            else
            {
                Console.WriteLine("The number is not perfect");
            }
            Console.ReadKey();
        }
    }
}
