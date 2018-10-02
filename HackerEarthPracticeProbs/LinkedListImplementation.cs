using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerEarthPracticeProbs
{
    class CustomLinkedListImpl
    {
        static void Main()
        {
            LinkedListImplementation<int> linkedList = new LinkedListImplementation<int>(1);
            linkedList.Append(2);
            linkedList.Append(3);
            linkedList.Append(4);
            linkedList.Prepend(0);
            linkedList.Prepend(-1);
            linkedList.Prepend(-2);
            linkedList.DeleteWithValue(0);
            linkedList.DeleteWithValue(4);
            linkedList.DeleteWithValue(-2);
        }
    }
    class LinkedListImplementation<T>
    {
        Node<T> _head = null;
        public LinkedListImplementation(T data)
        {
            _head = new Node<T>(data);
        }

        public void Append(T data)
        {
            Node<T> current = _head;
            while (current.next != null)
            {
                current = current.next;
            }
            current.next = new Node<T>(data);
            current.next.prev = current;
        }

        public void Prepend(T data)
        {
            Node<T> newHead = new Node<T>(data);
            newHead.next = _head;
            _head.prev = newHead;
            _head = newHead;
        }

        public void DeleteWithValue(T data) 
        {
            Node<T> current = _head;
            if ((dynamic)current.data == (dynamic)data)
            {
                _head = current.next;
                _head.prev = null;
            }
            else
            {
                while (current.next != null)
                {
                    if ((dynamic)current.next.data == (dynamic)data)
                    {
                        current.next = current.next.next;
                        if (current.next != null)
                        {
                            current.next.prev = current;
                        }
                        break;
                    }
                    else
                    {
                        current = current.next;
                    }
                }
            }
        }
    }

    class Node<T>
    {
        public T data = default(T);
        public Node<T> next = null;
        public Node<T> prev = null;
        public Node(T data)
        {
            this.data = data;
        }
    }
}
