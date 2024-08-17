using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rohan_Lab2
{
    internal class FibonacciSeries
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter term to find fibonacci series");
            int num = int.Parse(Console.ReadLine());
            int first = 0  , second = 1 ;
            int fibo = 0;
            if(num == 1)
            {
                fibo = first;
           }else if (num == 2)
            {
                fibo = second;
            }
            else
            {

            for(int i = 3; i <= num; i++)
            {
                fibo = first + second;
                first = second;
                second = fibo;
            }   
            }
            Console.WriteLine("Fibonacci series at " + num + " term is " +fibo);
            Console.ReadKey();
        }
    }
}
