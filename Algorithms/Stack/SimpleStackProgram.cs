using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class SimpleStackProgram
    {
        static void Main(string[] args)
        {
            // Initialize new stack with 4 element size.
            Stack stack = new Stack(4);

            // Push data to stack
            stack.push(" City.");
            stack.push(" Aveiro");
            stack.push(" Like");
            stack.push("I");

            // Pop stack data
            while (!stack.isEmpty())
            {
                string temp = stack.pop();
                Console.Write(temp);
            }

            Console.ReadKey();
        }

        public class Stack
        {
            private int maxSize;
            private int top;
            private string[] stackArray;

            private Stack(){}
            public Stack(int _maxSize)
            {
                maxSize = _maxSize;
                stackArray = new string[_maxSize];
                top = -1;
            }

            public void push(string data)
            {
                if (isFull())
                {
                    Console.WriteLine("Stack is full.");
                }
                else
                {
                    top++;
                    stackArray[top] = data;
                }
            }

            public string pop()
            {
                if (isEmpty())
                {
                    Console.WriteLine("Stack is Empty");
                    return "--";
                }
                else
                {
                    int tmp = top;
                    top--;
                    return stackArray[tmp];
                }
            }

            public string peek()
            {
                return stackArray[top];
            }
            public bool isFull()
            {
                return ((maxSize - 1) == top);
            }

            public bool isEmpty()
            {
                return (top == -1);
            }
        }
    }
}
