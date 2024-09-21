using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rohan_lab6
{
    public class Complex
    {
        double real;
        double imag;
        public Complex() { }
        public Complex(double real, double imag)
        {
            this.real = real;
            this.imag = imag;
        }
        public static Complex operator *(Complex c1, Complex c2)
        {
            Complex c = new Complex();
            c.real = c1.real * c2.real - c1.imag * c2.imag;
            c.imag = c1.real * c2.imag + c1.imag * c2.real;
            return c;
        }

        public static Complex operator /(Complex c1, Complex c2)
        {
            Complex c = new Complex();
            double denominator = c2.real * c2.real + c2.imag * c2.imag;
            c.real = (c1.real * c2.real + c1.imag * c2.imag) / denominator;
            c.imag = (c2.real * c1.imag - c1.real * c2.imag) / denominator;
            return c;
        }

        public static Complex operator -(Complex c1)
        {
            Complex temp = new Complex();
            temp.real = -c1.real;
            temp.imag = -c1.imag;
            return temp;
        }

        public static bool operator ==(Complex c1, Complex c2)
        {
            if(c1.real == c2.real &&  c1.imag == c2.imag)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Complex c1, Complex c2)
        {
            if (c1.real != c2.real || c1.imag != c2.imag)
            {
                return true;
            }
            return false;
        }
        public void display()
        {
            Console.WriteLine("Complex:" + real + "+ " + imag + "i");
        }
    }
    internal class OperatorOverloadng
    {
        static void Main(string[] args)
        {
            Complex a = new Complex(2, 4);
            Complex b = new Complex(9, 2);

            Console.WriteLine("A=");
            a.display();
            
            Console.WriteLine("B=");
            b.display();
            
            Complex c = a * b;
            Complex d = a / b;
            
            Console.WriteLine("A X B=");
            c.display();
            
            Console.WriteLine("A/B=");
            d.display();
            
            Complex e = -a;
            Console.WriteLine("-A = ");
            e.display();
            
            if(a == b)
            {
                Console.WriteLine("A is equal to B");
            }
            else
            {
                Console.WriteLine("A is not equal to B");
            }
            Console.ReadKey();
        }
    }
}
