using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rohan_Lab2
{
    internal class SumOfIntergets
    {
        public static void Main(string[] args)
        {
            int sum = 0;
            while (true)
            {   

                Console.WriteLine("Enter number to  sum");
                int num = int.Parse(Console.ReadLine());    
                if(num < 0)
                {
                    Console.WriteLine("OOps negative number");
                    Console.ReadKey();
                    break;
                }
                sum += num;
                Console.WriteLine("The sum is " + sum);
            }
        }
    }
}
