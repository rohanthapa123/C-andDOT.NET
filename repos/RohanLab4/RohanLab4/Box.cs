using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RohanLab4
{
    internal class Box
    {

        private int width, height, depth;
        public Box(int w, int h , int d) { 
            width = w;
            height = h;
            depth = d;
        }

        public int findVolume()
        {
            return width * height * depth;
        }

        public int findSurfaceArea()
        {
            return 2 * ((width * height) + (height * depth) + (depth * width));
        }
    }

    public class MyBox
    {
        public static void Main(string[] args)
        {
            Box b1 = new Box(5, 10, 15);
            int surface = b1.findSurfaceArea();
            int volume = b1.findVolume();

            Box b2 = new Box(15, 25, 6);
            int surface2 = b2.findSurfaceArea();
            int volume2 = b2.findVolume();

            Console.WriteLine("The surface area is :" + surface);
            Console.WriteLine("The volume is :" + volume);

            Console.WriteLine("The surface area is :" + surface2);
            Console.WriteLine("The volume is :" + volume2);

            Console.ReadKey();
        }
    }
}
