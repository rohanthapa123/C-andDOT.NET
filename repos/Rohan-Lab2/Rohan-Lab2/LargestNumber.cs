using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rohan_Lab2
{
    internal class LargestNumber
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter three number");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            if(num1 > num2)
            {
                if(num1 > num3)
                {
                    Console.WriteLine("The largest number is " + num1);
                }
                else
                {
                    Console.WriteLine("The largest number is " + num3);
                }
            }
            else
            {
                if (num2 > num3)
                {
                    Console.WriteLine("The largest number is " + num2);
                }
                else
                {
                    Console.WriteLine("The largest number is " + num3);
                }
            }
            Console.ReadKey();
        }
    }
}
