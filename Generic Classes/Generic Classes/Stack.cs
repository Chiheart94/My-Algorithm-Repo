using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Classes
{
    internal class Stack<T>
    {
        private readonly LinkedList<T> linkedList;

        public Stack()
        {
            linkedList = new LinkedList<T>();
        }

        public bool IsEmpty()
        {
            return linkedList.Size == 0;
        }

        public void Push(T val)
        {
            linkedList.Add(val);
        }

        public T Pop()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Stack is empty");

            T val = linkedList.listTail.Value;
            linkedList.Remove(val);
            return val;
        }

        public T Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Stack is empty");

            return linkedList.listTail.Value;
        }

        public int Size()
        {
            return linkedList.Size;
        }
    }
}
