using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace RohanLab4
{
    public struct Company
    {
        private string name, address, phone;
        private double salary;

        
        public void setProperty(string name, string address, string phone, double salary)
        {
            this.name = name;
            this.address = address;
            this.phone = phone;
            this.salary = salary;
        }

        public void display()
        {
            Console.WriteLine("Name :" + name);
            Console.WriteLine("Address :" + address);
            Console.WriteLine("Phone :" + phone);
            Console.WriteLine("Salary :" + salary);
        }
    };

    public class MyCompany
    {
        public static void Main()
        {
            Company company = new Company();
            Console.Write("Enter the name of company:");
            string name = Console.ReadLine();

            Console.Write("\nEnter the address of company:");
            string address = Console.ReadLine();

            Console.Write("Enter the phone of company:");
            string phone = Console.ReadLine();

            Console.Write("Enter the salary :");
            double salary = double.Parse(Console.ReadLine());

            company.setProperty(name, address, phone, salary);

            company.display();

            Console.ReadKey();
        }
    }
}
