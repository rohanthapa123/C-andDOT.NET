using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RohanLab3
{
    internal class OptionalAndNamedParameter
    {
        static int sum(int x , int y , int z = 6)
        {
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
            Console.WriteLine("z = " + z);
            return x + y + z;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Optional Parameter");
            Console.WriteLine(sum(1 , 3));
            Console.WriteLine("Named Parameter");
            Console.WriteLine(sum(z:1, y:2 , x:7));
            Console.ReadKey();
        }
    }
}
