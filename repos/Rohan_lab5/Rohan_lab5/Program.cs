using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rohan_lab5
{
    public abstract class AbstractExample
    {
        public string name;

        public AbstractExample(string name)
        {
            this.name = name;
        }
        public abstract string GetName();



    }

    public class Second : AbstractExample
    {

        public Second(string name):base(name)
        {
        }
        public override string GetName()
        {
            return base.name;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Second s1 = new Second("Rohan Thapa");
            Console.WriteLine(s1.GetName());
            Console.ReadKey();
        }
    }
}
