using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RohanLab7
{
    internal class Qnsno6
    {
        public class LongNameException : Exception
        {
            public LongNameException(string msg) : base(msg)
            {

            }
        }
        public static void Main(string[] args)
        {
                try
                {
                Console.WriteLine("Enter name");
                    string name = Console.ReadLine();
                    if (name.Length > 10)
                    {
                        throw new LongNameException("Name length is too exception");
                    }
                }
                catch (LongNameException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    Console.WriteLine("Finally done");
                Console.ReadKey();
                }

        }
    }
}
