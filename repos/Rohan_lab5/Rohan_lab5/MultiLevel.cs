/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rohan_lab5
{
    public class School: Student
    {
        private string schoolName;
        public School(string schoolName, string name , int roll):base(name , roll)
        {
            this.schoolName = schoolName;
        }

        public void getAllDetails()
        {
            base.PrintDetails();
            Console.WriteLine("School name is " + this.schoolName);
        }
    }
    internal class MultiLevel
    {
        public static void Main(string[] args)
        {
            School s1 = new School("KMC", "Rohan Thapa", 18);
            s1.getAllDetails();
            Console.ReadKey();
        }
    }
}
*/