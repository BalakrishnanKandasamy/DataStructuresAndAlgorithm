using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerEarthPracticeProbs
{
    class CustomStackImpl
    {
        static void Main()
        {
            StackImplementation<int> stack = new StackImplementation<int>(3);
            stack.Push(5);
            stack.Push(10);
            stack.Push(24);
            stack.Push(12);

            int topElement = stack.Peek();

            for (int removeCounter = 0; removeCounter < 3; removeCounter++)
            {
                stack.Pop();
            }

            stack.Pop();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
        }
    }
    class StackImplementation<T>
    {
        T[] _stack = null;
        int _size = 0;
        //Denotes the Stack is Empty
        int top = -1;
        public StackImplementation(int size)
        {
            this._stack = new T[size];
            this._size = size;
        }
        public void Push(T element)
        {
            if (IsOverFlow())
            {
                Console.WriteLine(string.Format("The Stack is full.Cannot push element : {0} into the stack", element));
            }
            else
            {
                ++this.top;
                this._stack[top] = element;
            }
        }

        public void Pop() 
        {
            if (IsUnderFlow())
            {
                Console.WriteLine("The Stack is Empty.Cannot perform Pop");
            }
            else
            {
                --this.top;
            }
        }

        public T Peek() 
        {
            return this._stack[top];
        }

        private bool IsOverFlow()
        {
            return top == _size - 1;
        }

        private bool IsUnderFlow() 
        {
            return top == -1;
        }
    }
}
