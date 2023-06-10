using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Classes
{
    internal class Program
    {
        static void Main()
        {
            LinkedList<int> list = new LinkedList<int>();

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            Console.WriteLine();
            Console.WriteLine("LINKED LIST");
            Console.WriteLine();
            Console.WriteLine("List Size = " + list.Add(7));
            Console.WriteLine();
            Console.WriteLine("Removed = " + list.Remove(3));
            Console.WriteLine();
            Console.WriteLine("Checked = " + list.Check(3));
            Console.WriteLine();
            Console.WriteLine("Index = " + list.Index(2));
            Console.WriteLine();


            Stack<int> stack = new Stack<int>();

            Console.WriteLine("STACK");
            Console.WriteLine();
            Console.WriteLine(stack.IsEmpty());

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            Console.WriteLine();
            Console.WriteLine(stack.IsEmpty());
            Console.WriteLine();
            Console.WriteLine(stack.Size());
            Console.WriteLine();
            Console.WriteLine(stack.Peek());
            Console.WriteLine();
            Console.WriteLine(stack.Pop());
            Console.WriteLine();
            Console.WriteLine(stack.Peek());
            Console.WriteLine();
            Console.WriteLine(stack.Size());
            Console.WriteLine();


            Queue<int> queue = new Queue<int>();

            Console.WriteLine("QUEUE");
            Console.WriteLine();
            Console.WriteLine(queue.IsEmpty());

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(queue.IsEmpty());
            Console.WriteLine();
            Console.WriteLine(queue.Size());
            Console.WriteLine();
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine();
            Console.WriteLine(queue.Size());
            Console.WriteLine();





        }
    }
}
