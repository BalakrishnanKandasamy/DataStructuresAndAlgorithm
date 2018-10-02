using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerEarthPracticeProbs
{
    class CustomQueueImpl 
    {
        static void Main() 
        {
            QueueImplementation<int> queue = new QueueImplementation<int>(3);
            Console.WriteLine(string.Format("{0} Enqueued", queue.EnQueue(1)));
            Console.WriteLine(string.Format("{0} Enqueued", queue.EnQueue(2)));
            Console.WriteLine(string.Format("{0} Enqueued", queue.EnQueue(3)));
            Console.WriteLine(string.Format("{0} Dequeued", queue.DeQueue()));
            Console.WriteLine(string.Format("{0} Enqueued", queue.EnQueue(4)));
            int firstElement = queue.Peek();

            for (int removeCounter = 0; removeCounter < 3; removeCounter++)
            {
                Console.WriteLine(string.Format("{0} Dequeued", queue.DeQueue()));
            }
            Console.WriteLine(string.Format("{0} Enqueued", queue.EnQueue(5)));
            Console.WriteLine(string.Format("{0} Enqueued", queue.EnQueue(6)));
            Console.WriteLine(string.Format("{0} Enqueued", queue.EnQueue(7)));
            Console.WriteLine(string.Format("{0} Enqueued", queue.EnQueue(7)));
            for (int removeCounter = 0; removeCounter < 3; removeCounter++)
            {
                Console.WriteLine(string.Format("{0} Dequeued", queue.DeQueue()));
            }
            Console.WriteLine(string.Format("{0} Dequeued", queue.DeQueue()));
            Console.ReadLine();
        }
    }
    class QueueImplementation<T>
    {
        T[] _queue = null;
        int _size = 0;
        int _front = 0;
        int _rear = 0;
        int _queueSize = 0;

        public QueueImplementation(int size) 
        {
            _queue = new T[size];
            _size = size;
        }

        public T EnQueue(T element)
        {
            T enqueuedElement = default(T);
            if (IsFull())
            {
                Console.WriteLine("Queue  is full");
            }
            else
            {
                this._queue[_rear] = element;
                ++_queueSize;
                if (++_rear == _size)
                {
                    _rear = 0;
                };
                enqueuedElement = element;
            }
            return enqueuedElement;
        }

        public T DeQueue()
        {
            T dequeuedElement = default(T);
            if (IsEmpty())
            {
                Console.WriteLine("Queue is Empty");
            }
            else
            {
                dequeuedElement = this._queue[_front];
                this._queue[_front] = default(T);
                --_queueSize;
                if (++_front == _size) 
                {
                    _front = 0;
                }
            }
            return dequeuedElement;
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is Empty");
                return default(T);
            }
            else
            {
                return this._queue[_front];
            }
        }
        private bool IsEmpty()
        {
            return this._queueSize == 0;
        }

        private bool IsFull()
        {
            return ((this._size - this._queueSize) - 1) == -1;
        }

    }
}
