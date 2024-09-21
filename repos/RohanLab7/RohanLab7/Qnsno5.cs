using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace RohanLab7
{
    public class BalanceException : Exception
    {
        public BalanceException(string message) : base(message) {
            
        }
        internal class Qnsno5
        {
            public static void Main(string[] args)
            {
                try
                {
                    Console.WriteLine("Enter balance and amount to withdraw");
                    double balance = double.Parse(Console.ReadLine());
                    double withdraw = double.Parse(Console.ReadLine());

                    if (balance > withdraw)
                    {
                        balance -= withdraw;
                        Console.WriteLine("Remaining balance = " + balance);

                    }
                    else
                    {
                        throw new BalanceException("Insuffecient Balance");
                    }
                }
                catch (BalanceException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    Console.WriteLine("End of the program");
                    Console.ReadKey();
                }


            }
        }
    }
}
