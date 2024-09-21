using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RohanLab7
{
    internal class Lambda
    {
        delegate void DisplayMessage(string message);

        static void Main(string[] args)
        {
            DisplayMessage anonymousMethod = delegate (string msg)
            {
                Console.WriteLine("Anonymous Method: " + msg);
            };

             DisplayMessage lambdaExpression = (msg) =>
            {
                Console.WriteLine("Lambda Expression: " + msg);
            };

            anonymousMethod("Hello from Anonymous Method!");

            lambdaExpression("Hello from Lambda Expression!");

            Console.ReadLine();
        }
    }
}
