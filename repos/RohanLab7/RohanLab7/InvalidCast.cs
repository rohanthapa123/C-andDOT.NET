using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RohanLab7
{
    internal class InvalidCast
    {
        public static void Main(string[] args)
        {
            try
            {
                Object num = 100;
                int number = (short)num;
                Console.WriteLine("The number is" + number);
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine(Console.ReadLine());
            }
        }
    }
}
