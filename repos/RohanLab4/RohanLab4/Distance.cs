using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RohanLab4
{
    public class Distance
    {
        private int feet, inch;

        public Distance()
        {

        }
        public Distance(int f , int i) { 
            feet = f;
            inch = i;
        }

        public void addDistance(int f , int i )
        {
            feet += f;
            inch += i;
            if(inch >= 12)
            {
                feet += inch / 12;
                inch %= 12;

            }
        }

        public void substractDistance(int f, int i)
        {
            feet += f;
            inch += i;
            if (inch < 0)
            {
                feet -= (Math.Abs(inch) / 12) + 1;
                inch = 12 - (Math.Abs(inch) % 12);
            }
        }

        public void displayDistance()
        {
            Console.WriteLine("The distance is " + feet + " feet and " + inch + " inch");
        }

    }
}
