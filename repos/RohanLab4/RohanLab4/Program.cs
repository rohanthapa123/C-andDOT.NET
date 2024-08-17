using RohanLab4.customNamespace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RohanLab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassFromNamespace c1 = new ClassFromNamespace();
            c1.printName("Rohan Thapa");
            Console.ReadKey();
        }
    }
}
