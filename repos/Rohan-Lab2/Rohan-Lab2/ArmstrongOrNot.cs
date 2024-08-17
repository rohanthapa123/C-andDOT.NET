using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Rohan_Lab2
{
    internal class ArmstrongOrNot
    {
        public static void Main(string[] args) {
            Console.WriteLine("Enter any number to check armstrong");
            int num = int.Parse(Console.ReadLine());
            int dub = num ;
            int sum = 0;
            int numofdigit = 0;
            while (dub != 0)
            {
                numofdigit++;
                dub /= 10;
            }
            dub = num;
            while (dub != 0)
            {
                int rem = dub % 10;
                sum += (int)Math.Pow(rem, numofdigit);
                dub /= 10;
            }
            
            if (num == sum)
            {
                Console.WriteLine("Armstrong");
            }
            else
            {
                Console.WriteLine("not armstrong");
            }
            Console.ReadKey();
        }
    }
}
