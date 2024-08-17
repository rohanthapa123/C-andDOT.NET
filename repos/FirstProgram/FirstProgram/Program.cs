using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number");
            int num = int.Parse(Console.ReadLine());
            if (num % 5 == 0)
            {
                Console.WriteLine("Input number is divisible by 5");
            }
            Console.WriteLine("End of program");
            Console.ReadKey();
        }
    }
}
