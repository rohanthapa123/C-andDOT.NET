﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RohanLab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            int sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] % 2 != 0)
                {
                    sum += arr[i];
                }
            }

            Console.WriteLine("The sum of odd elements of array is " + sum);
            Console.ReadKey();
        }
    }
}
