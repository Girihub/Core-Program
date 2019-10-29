//----------------------------------------------------
// <copyright file="Stack.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------
namespace DataStructure.Utility
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Stack as a class
    /// </summary>
    public class Stack
    {
        int top = -1;
        static int limit = 1000;
        Object[] stack = new Object[limit];

        public void push(Object data)
        {
            if (top >= limit-1)
            {
                Console.WriteLine("Stack Overflow");
            }
            else
            {
                top = top + 1;
                stack[top] = data;
            }
        }

        public void pop()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack underflow");
            }
            else
            {                
                top--;
            }
        }

        public void peek()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack underflow");
                return;
            }
            Console.WriteLine(stack[top]);
            return;
        }

        public bool IsEmpty()
        {
            return top < 0;
        }

        public void print()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack underflow");
            }
            else
            {
                for (int i = top; i >= 0; i--)
                {
                    Console.Write(stack[i] + " ");
                }
            }
        }

        public int size()
        {
            return top + 1;
        }
    }
}
