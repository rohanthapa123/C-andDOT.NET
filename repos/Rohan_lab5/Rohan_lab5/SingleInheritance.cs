/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Rohan_lab5
{
    
        public class Person
        {
            public string name;
            
            public Person(string name)
            {
                this.name = name;
            }


        }

        public class Student : Person
        {
            private int roll;

            public Student(string name, int roll) : base(name)
            {
                this.roll = roll;
            }
            public void PrintDetails()
            {

                Console.WriteLine("Name = " + base.name);
                Console.WriteLine("Roll = " + this.roll);
            }
        }

        public class SingleProgramExample
        {
            public static void Main(string[] args)
            {
                Student s1 = new Student("Rohan Thapa", 18);
                s1.PrintDetails();
                Console.ReadKey();
            }
        }
    
}
*/