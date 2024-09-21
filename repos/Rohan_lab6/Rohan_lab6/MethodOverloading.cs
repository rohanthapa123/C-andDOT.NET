using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rohan_lab6
{
    internal class MethodOverloading
    {
        public int add(int a , int b)
        {
            return a + b;
        }
        public int add(int a, int b, int c)
        {
            return a + b + c;
        }
        public int add(int a, int b, int c, int d)
        {
            return a + b + c + d;
        }
    }

    public class OverloadingMaster
    {
        public static void Main(string[] args)
        {
            MethodOverloading m1 = new MethodOverloading();
            Console.WriteLine("Addition of two number " + m1.add(1 , 2));
            Console.WriteLine("Addition of three number " + m1.add(2 , 3  , 4));
            Console.WriteLine("Addition of four number " + m1.add (3 , 4 , 5, 5));
            Console.ReadKey();
        }
    }
}
