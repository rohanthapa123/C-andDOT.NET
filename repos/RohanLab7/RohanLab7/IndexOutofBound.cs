using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RohanLab7
{
    internal class IndexOutofBound
    {
        public static void Main(string[] args)
        {

            try
            {
                int[] arr = { 1, 2, 3, };
                Console.WriteLine("The value at index 6 i s " + arr[6]);
            }
            catch (IndexOutOfRangeException ex)
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
