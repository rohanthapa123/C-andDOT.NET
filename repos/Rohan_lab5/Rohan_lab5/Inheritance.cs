using System;
using System.Collections.Generic;
using System.Linq;
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

    public class School : Student
    {
        private string schoolName;
        public School(string schoolName, string name, int roll) : base(name, roll)
        {
            this.schoolName = schoolName;
        }

        public void getAllDetails()
        {
            base.PrintDetails();
            Console.WriteLine("School name is " + this.schoolName);
        }
    }

    public class Employee : Person
    {
        private string eid;

        public Employee(string eid , string name):base(name)
        {
            this.eid = eid;
        }

        public void PrintDetails()
        {
            Console.WriteLine("Name = " + base.name);
            Console.WriteLine("Employee Id = " + this.eid);
        }
    }
    
    public class Inheritanc
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Single Inheritance");
            Student st1 = new Student("Rohan Thapa", 18);
            st1.PrintDetails();
            Console.WriteLine();
            Console.WriteLine("Multiple Inheritance");
            School s1 = new School("KMC", "Rohan Thapa", 18);
            s1.getAllDetails();
            Console.WriteLine();
            Console.WriteLine("Hierarchical Inheritance");
            Employee e1 = new Employee("Emp101", "Rohan Thapa");
            e1.PrintDetails();


            Console.ReadKey();
        }
    }
}
