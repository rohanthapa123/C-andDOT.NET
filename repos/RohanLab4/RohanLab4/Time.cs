using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RohanLab4
{
    internal class Time
    {
        private int hours, min, sec;

        public Time()
        {

        }
        public Time(int h , int m , int s)
        {
            hours = h;
            min = m;
            sec = s;
            normalize();
        }

        public int getHours()
        {
            return hours;
        }
        public int getMin()
        {
            return min;
        }

        public int getSecond()
        {
            return sec;
        }
        public  void addTime(Time t1)
        {
            this.hours += t1.getHours();
            this.min += t1.getMin();
            this.sec += t1.getSecond();

            normalize();
        }

        public void substractTime(Time t1)
        {
            this.hours -= t1.getHours();
            this.min -= t1.getMin();
            this.sec -= t1.getSecond();

            normalize();
        }

        private void normalize()
        {
            if (sec >= 60)
            {
                min += sec / 60;
                sec %= 60;
            }
            else if (sec < 0)
            {
                min -= (Math.Abs(sec) / 60) + 1;
                sec = 60 - (Math.Abs(sec) % 60);
            }

            if (min >= 60)
            {
                hours += min / 60;
                min %= 60;
            }
            else if (min < 0)
            {
                hours -= (Math.Abs(min) / 60) + 1;
                min = 60 - (Math.Abs(min) % 60);
            }

            if (hours < 0)
            {
                hours = 0;
                min = 0;
                sec = 0;
            }
        }
        public void displayTime()
        {
            Console.WriteLine(hours+ ":" + min+":"+sec);
        }
    }

    public class MyTime
    {
        public static void Main(string[] args)
        {
            Time t1 = new Time(3 , 5 , 15);
            Console.WriteLine("Initial Time");
            t1.displayTime();

            Console.WriteLine("Adding Time");
            t1.addTime(new Time(5,59,8));

            t1.displayTime();

            Console.WriteLine("Substracting Time");
            t1.substractTime(new Time(6,25,10));

            t1.displayTime();
            

            Console.ReadKey();

        }    
    }
}
