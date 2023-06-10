using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Classes
{
    internal class LinkedList<T>
    {
        public class Node
        {
            public T Value;
            public Node Next;

            public Node(T value)
            {
                Value = value;
                Next = null;
            }
        }
        public Node listHead;
        public Node listTail;
        private int listSize;

        public int Size { get { return listSize; } }

        public int Add(T val)
        {
            Node node = new Node(val); //val are in place of items

            if (listHead == null)
            {
                listHead = node;
               listTail = node;
            }
            else
            {
                listTail.Next = node;
                listTail = node;
            }
            listSize++;
            return listSize;
        }

        public bool Remove(T val)
        {
            Node current = listHead;
            Node previous = null;

            while (current != null)
            {
                if (current.Value.Equals(val))
                {
                    if (previous == null)
                    {
                        listHead = current.Next;
                        if (listHead == null)
                            listTail = null;
                    }
                    else
                    {
                        previous.Next = current.Next;
                        if (current.Next == null)
                            listTail = previous;
                    }
                    listSize--;
                    return true;
                }
                previous = current;
                current = current.Next;
            }
        return false;
        }

        public bool Check(T val)
        {
            Node current = listHead;

            while(current != null)
            {
                if(current.Value.Equals(val))
                    return true;

                current = current.Next;
            }
            return false;
        }


        public int Index(T val)
        {
            Node current = listHead;
            int index = 0;
            while(current != null)
            {
                if(current.Value.Equals(val))
                    return index;

                current = current.Next;
                index++;

            }
            return -1;
        }
    }
}
