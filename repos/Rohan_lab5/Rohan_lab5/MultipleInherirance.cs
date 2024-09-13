using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rohan_lab5
{

    interface IFirst
    {
        void MethodA();
    }

    interface ISecond
    {
        void MethodB();
    }

    class MyClass : IFirst, ISecond
    {
        public void MethodA()
        {
            Console.WriteLine("MethodA from IFirst");
        }

        public void MethodB()
        {
            Console.WriteLine("MethodB from ISecond");
        }
    }
    internal class MultipleInherirance
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();

            obj.MethodA();
            obj.MethodB();
            Console.ReadKey();
        }
    }
}
