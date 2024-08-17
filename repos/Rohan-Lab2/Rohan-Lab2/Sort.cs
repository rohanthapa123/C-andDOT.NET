using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rohan_Lab2
{
    internal class Sort
    {
        public static void Main(string[] args)
        {
            int[] nums = { 1, 3, 5, 2, 8, 3, 6, 45, 23, 233, 12, 53 };

            

            for(int i = 0 ; i < nums.Length - 1 ; i++)
            {
                int min = i;
                for(int j = i + 1 ; j < nums.Length; j++)
                {
                    if(nums[j] < nums[min])                    {
                        min = j;
                    }
                }
                int temp = nums[i];
                nums[i] = nums[min];
                nums[min] = temp;

                
            }
            foreach(int i in nums)
            {
                Console.Write(i + "\t");
            }
            Console.ReadKey();
        }
    }
}
