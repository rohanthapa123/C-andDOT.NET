using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rohan_lab6
{
    class shapes
    {
        public virtual double Area()
        {
            Console.WriteLine("Shape is not defined");
            return 0;
        }
    }
    class square : shapes
    {
        double width, height;
        public square(double width, double height)
        {
            this.width= width;
            this.height = height;
        }

        public override double Area()
        {
            return (double)(width * height);
        }
    }

    internal class MethodOverriding
    {
        static void Main(string[] args)
        {
            shapes s = new shapes();
            s.Area();
            square sq = new square(20,10);
            double area = sq.Area();
            Console.WriteLine("Area = " + area);
            Console.ReadKey();
        }
    }
}
