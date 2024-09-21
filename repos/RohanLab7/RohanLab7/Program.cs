using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RohanLab7
{
    internal class Program
    {
        public static void add(int x, int y)
        {
            Console.WriteLine(x + "+" + y + "=" + (x + y));
        }
        public static void sub(int x, int y)
        {
            Console.WriteLine(x + "-" + y + "=" + (x - y));
        }
        public static void mul(int x, int y)
        {
            Console.WriteLine(x + "*" + y + "=" + (x * y));
        }
        public static void div(int x, int y)
        {
            if (y == 0)
                Console.WriteLine("Can not be divided by zero");
            else
                Console.WriteLine(x + "/" + y + "=" + (x / y));
        }
        public delegate void mathoperation(int x, int y);
        static void Main(string[] args)
        {
            mathoperation ma = new mathoperation(add);
            ma += sub;
            ma += mul;
            ma += div;
            ma.Invoke(4, 5);
            Console.ReadKey();
        }

    }
}
