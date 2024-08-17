using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RohanLab3
{
    internal class MinimumAndMaximum
    {
        public static void Main(string[] args)
        {

            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            int min = arr[0];
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }

            Console.WriteLine("The maximum element is  " + max + " and the minimum element is " + min);
            Console.ReadKey();
        }
    }
}
