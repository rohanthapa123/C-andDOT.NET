using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RohanLab4
{
    internal class MyDistance
    {
        public static void Main(string[] args)
        {
            Distance d1 = new Distance(10, 5);
            Console.WriteLine("Initial Display:");
            d1.displayDistance();
            d1.addDistance(10, 5);
            Console.WriteLine("Adding Distance");
            d1.displayDistance();
            d1.substractDistance(1, 2);
            Console.WriteLine("Substracting Distance");
            d1.displayDistance();
            Console.ReadKey(); 
        }
    }
}
