using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RohanLab3
{
    internal class Params
    {
        static int add(int x, params int[] num)
        {
            Console.WriteLine("x = " + x);
            int sum = x;
            foreach (int i in num)
            {
                sum += i;
            }
            return sum;

        }
        static int mul(params int[] num)
        {

            int mul = 1;
            foreach (int i in num)
            {
                mul *= i;
            }
            return mul;

        }
        public static void Main(string[] args)
        {
            int res1 = add(1, 2, 3, 5, 6, 4, 7, 8, 9, 10);
            Console.WriteLine("With int x, params int[] num: " + res1);
            int res2 = mul(1, 2, 3, 5);
            Console.WriteLine("With params int[] num: " + res2);

            Console.ReadKey();
        }
    }
}
