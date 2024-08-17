using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Rohan_Lab2
{
    internal class CubeOfNumber
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter number upto which to compute cube ");
            int num = int.Parse(Console.ReadLine());
            int i = 1;
        Label:
            Console.WriteLine(i * i * i);
            i++;
            if(i <= num)
            {

            goto Label;
            }
            Console.ReadKey();

        }
    }
}
