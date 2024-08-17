using System;

namespace RohanLab3
{
    internal class Determinant
    {
        public static void Main(string[] args)
        {
            int[,] arr = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 1 } };
            Console.WriteLine("A=");
            for (int l = 0; l < 3; l++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr[l, j] + " ");
                }
                Console.WriteLine();
            }

            // Extracting elements of the matrix
            int a = arr[0, 0];
            int b = arr[0, 1];
            int c = arr[0, 2];
            int d = arr[1, 0];
            int e = arr[1, 1];
            int f = arr[1, 2];
            int g = arr[2, 0];
            int h = arr[2, 1];
            int i = arr[2, 2];

            // Calculating the determinant using the formula
            int determinant = a * (e * i - f * h) - b * (d * i - f * g) + c * (d * h - e * g);
            Console.WriteLine("Determinant of matrix A = " + determinant);

            Console.ReadKey();
        }
    }
}
