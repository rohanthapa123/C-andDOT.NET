using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RohanLab4
{
    public class Circle
    {
        private float radius;

        public Circle(float radius)
        {
            this.radius = radius;
        }

        public float FindArea()
        {
            return (float)Math.PI * radius * radius;
        }

        public float FindCircumference()
        {
            return 2 * (float)Math.PI * radius;
        }

    }
}
