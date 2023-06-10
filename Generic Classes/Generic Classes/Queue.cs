using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Classes
{
    internal class Queue<T>
    {
        private readonly LinkedList<T> linkedList;

        public Queue()

        {
            linkedList = new LinkedList<T>();
        }

        public bool IsEmpty()
        {
            return linkedList.Size == 0;
        }

           public void Enqueue(T val)
            {
                linkedList.Add(val);
            }

        public T Dequeue()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Queue is empty");

            T val = linkedList.listHead.Value;
            linkedList.Remove(val);
            return val;
        }

        public int Size()
        {
            return linkedList.Size;
        }
        }
    }
