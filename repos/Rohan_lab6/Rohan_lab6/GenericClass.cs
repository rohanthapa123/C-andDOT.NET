using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rohan_lab6
{

    internal class GenericClass
    {
        public static void Main(string[] args)
        {

            List<String> list = new List<String>();
            list.Add("DotNet Technology");
            list.Add("Computer Network");
            list.Add("Computer Graphics");

            Console.WriteLine("Total element in  list is : " + list.Count);

            Console.WriteLine("List elements are");
            foreach(String s in list) 
                Console.WriteLine(s);
            Console.WriteLine();
            list.RemoveAt(1);

            Console.WriteLine("List elements are after removing");
            
            foreach (String s in list)
                Console.WriteLine(s);


            Console.WriteLine();
            Console.WriteLine("Stack");
            Stack<string> stack = new Stack<string>();
            stack.Push("Apple");
            stack.Push("Ball");
            stack.Push("Cat");
            stack.Push("Dog");
            Console.WriteLine();
            Console.WriteLine("After push");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            stack.Pop();
            Console.WriteLine("After pop");
            Console.WriteLine();
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("Item at the top of stack is " + stack.Peek());
            
            stack.Clear();
            Console.WriteLine("After clear");
            Console.WriteLine(stack.Count);

            Console.WriteLine();

            Console.WriteLine("Queue");
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(2);
            queue.Enqueue(7);
            queue.Enqueue(8);
            queue.Enqueue(9);

            Console.WriteLine("After enqueing:");
            
            foreach (var item in queue)
                Console.WriteLine(item);
            queue.Dequeue();
            
            Console.WriteLine("After dequing:");
            foreach (var item in queue)
                Console.WriteLine(item);
            
            Console.WriteLine("Count =" + queue.Count);
            Console.WriteLine();
            Console.WriteLine("LinkedList");
            LinkedList<string> ll = new LinkedList<string>();
            ll.AddFirst("Item One");
            ll.AddLast("Item Two");
            ll.AddLast("Rohan");
            ll.AddBefore(ll.Last.Previous, "Java");


            foreach (string s in ll)
            {
                Console.WriteLine(s);
            }


            Console.WriteLine();
            
            Console.WriteLine("Dictornary");


            Dictionary<String, String> dist = new Dictionary<String, String>();
            dist.Add("fname", "Rohan");
            dist.Add("lname", "Thapa");
            dist.Add("address", "Sanepa");
            dist.Add("phone", "1458965321");

            dist.Remove("address");

            string phone = dist["phone"];

            Console.WriteLine(phone);
            Console.WriteLine();
            
            

            Console.ReadKey();

        }

    }
}
