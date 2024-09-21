using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RohanLab7
{
    internal class Qnsno4
    {
        public static void Main(string[] args)
        {

            try{
                Console.WriteLine("Enter any number");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the divisor");
                int b = int.Parse(Console.ReadLine());
                int d = a / b;
                Console.WriteLine("The quotient is " + d);
            }catch(DivideByZeroException ex){
                Console.WriteLine(ex.Message);
            }catch(Exception ex){
                Console.WriteLine(ex.Message);
            }finally{
                Console.WriteLine(Console.ReadLine()); 
            }
        }
    }
}
