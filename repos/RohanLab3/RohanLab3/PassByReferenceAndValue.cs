using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RohanLab3
{
    internal class PassByReferenceAndValue
    {
        static void passByValue(int a)
        {
            a++;
            Console.WriteLine("Value in passbyvalue: " + a);
        }
        static void passByReference(ref int a)
        {
            a++;
            Console.WriteLine("Value in passbyreference: " + a);
        }
        public static void Main(string[] args)
        {
            int a = 10;

            Console.WriteLine("Pass by Value:");
            Console.WriteLine("Value before pass by value: " + a);
            passByValue(a);
            Console.WriteLine("Value after pass by value: " + a);
            Console.WriteLine("\nPass by Reference:");
            Console.WriteLine("Value before pass by reference: " + a);
            passByReference(ref a);
            Console.WriteLine("Value after pass by reference: " + a);
            Console.ReadKey();
        }
    }
}
