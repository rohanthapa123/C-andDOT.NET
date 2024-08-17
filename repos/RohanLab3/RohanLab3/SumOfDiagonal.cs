using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RohanLab3
{
    internal class SumOfDiagonal
    {
        public static void Main(string[] args)
        {

            int[  , ] arr = {
                {1 , 5 , 7 },
                {5 , 8, 1},
                { 4, 9, 12}
            };
            int sum = 0;
            for (int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    if(i == j)
                    {
                        sum += arr[i, j];
                    }
                }
            }
            Console.WriteLine("The sum of the diagonal element is " + sum);
            Console.ReadKey();
        }
    }
}
