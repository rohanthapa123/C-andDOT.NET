using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RohanLab4
{
    internal class MyCircle
    {
        public static void Main(string[] args)
        {
            Circle c1 = new Circle(10);
            float area = c1.FindArea();
            float cirumference = c1.FindCircumference();

            Console.WriteLine("Area is :" + area);
            Console.WriteLine("Cirumference is :" + cirumference);
            Console.ReadKey();
        }
    }
}
