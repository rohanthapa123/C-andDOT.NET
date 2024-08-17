using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RohanLab3
{
    internal class PrimeIN1D
    {

        static bool isPrime(int number)
        {
            if (number <= 1)
                return false; 
            if (number == 2)
                return true; 
            if (number % 2 == 0)
                return false;

            
            for (int i = 3; i * i <= number; i += 2)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23 };

            Console.WriteLine("Prime numbers in the array:");

            foreach (int num in arr)
            {
                if (isPrime(num))
                {
                    Console.Write(num + " ");
                }
            }
            Console.ReadKey();
        }
    }
}
