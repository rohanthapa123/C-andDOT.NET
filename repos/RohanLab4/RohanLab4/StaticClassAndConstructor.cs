using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RohanLab4
{
    public static class StaticClass
    {
        static string name;
        static StaticClass()
        {
            name = "Rohan"; 
        
        }

        public static void printName()
        {
            Console.WriteLine("My name is " + name);
        }
    }

    public class StaticClassAndConstructor
    {
        public static void Main(string[] args)
        {

            StaticClass.printName();
            Console.ReadKey();
        }
    }
}
