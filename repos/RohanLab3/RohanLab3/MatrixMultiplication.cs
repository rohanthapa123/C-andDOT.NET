using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RohanLab3
{
    internal class MatrixMultiplication
    {
        public static void Main(string[] args)
        {

            int[,] arr1 = {
                {1 , 5 , 7 },
                {5 , 8, 1},
                { 4, 9, 12}
            };
            int[,] arr2 = {
                {5 , 9 ,  6},
                {5 , 5, 8},
                { 0, 7, 11}
            };
            int[,] res = new int[3,3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    res[i, j] = 0; 
                    for (int k = 0; k < 3; k++)
                    {
                        res[i, j] += arr1[i, k] * arr2[k, j];
                    }
                }
            }
            Console.WriteLine("The resultant matrix is  " );

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(res[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
